using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Helpers;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.Properties;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftAppAdmin
{
    public partial class DashboardForm : Form
    {
        private Settings settings;

        public DashboardForm()
        {
            InitializeComponent();
            InitViewAsync();
        }

        public async Task InitViewAsync()
        {
            settings = Properties.Settings.Default;
            var nextShift = await new ShiftTDG().GetNextShift();
            var workers = await nextShift.GetWorkers();
            var inferiors = await new UserTDG().GetInferiorsAsync(settings.idUser);
            var requests = await new RequestTDG().GetRequestsAsync(new MyParams { Query = $"{{\"$and\":[{{\"resolved\":false}},{{\"request_type\":\"cancel\"}}]}}"});

            welcomeLabel.Text = $"Welcome, {settings.nameUser}";
            shiftDateTimeLabel.Text = Formatter.GetShiftInfoString(nextShift.DateFrom, nextShift.DateTo);
            shiftWorkersLabel.Text = Formatter.GetWorkersString(workers);

            foreach (User inferior in inferiors)
            {
                ListViewItem lvi = new ListViewItem(inferior.Secondname);
                lvi.SubItems.Add($"{inferior.Firstname} {inferior.Secondname}");

                inferiorsListView.Items.Add(lvi);
            }

            foreach (Request request in requests)
            {
                User requestor = await request.GetCreatedBy();
                Shift shift = await request.GetShift();
                List<User> workersOnShift = await shift.GetWorkers();
                String shiftDateInfo = Formatter.GetShiftInfoString(shift.DateFrom, shift.DateTo);
                String shiftWorkers = Formatter.GetWorkersString(workersOnShift);
                ListViewItem lvi = new ListViewItem(request.Id);
                lvi.SubItems.Add(request.RequestType);
                lvi.SubItems.Add(requestor.Secondname);
                lvi.SubItems.Add($"{shiftDateInfo}, {shiftWorkers}");

                requestsListView.Items.Add(lvi);
            }
        }

        private void ClearLayout()
        {
            inferiorsListView.Items.Clear();
            requestsListView.Items.Clear();
        }

        private void requestsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inferiorsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newPlanButton_Click(object sender, EventArgs e)
        {
            new NewProductionPlanForm().ShowDialog();
        }

        private async void generateProductionPlanButton_Click(object sender, EventArgs e)
        {
            settings = Properties.Settings.Default;
            MyParams myParams;

            // Hledame nejnovejsi plan, ktery je od prihlaseneho uzivatele a je active
            myParams = new MyParams
            {
                Query = $"{{\"$and\":[{{\"owner\": \"{settings.idUser}\"}},{{\"status\":\"active\"}}]}}",
                Limit = "1",
                Sort = "-created"
            };
            SuperiorPlan activePlan = (await new SuperiorPlanTDG().GetSuperiorPlansAsync(myParams))[0];
            activePlan.Status = "done";

            // Hledame nejnovejsi plan, ktery je od prihlaseneho uzivatele a je pending
            myParams = new MyParams
            {
                Query = $"{{\"$and\":[{{\"owner\": \"{settings.idUser}\"}},{{\"status\":\"pending\"}}]}}",
                Limit = "1",
                Sort = "-created"
            };
            SuperiorPlan pendingPlan = (await new SuperiorPlanTDG().GetSuperiorPlansAsync(myParams))[0];
            pendingPlan.Status = "active";

            List<Shift> shifts = await new ShiftTDG().GetShiftsByIdSuperiorPlanAsync(pendingPlan.Id);
            Random rnd = new Random();
            foreach (Shift shift in shifts)
            {
                bool changed = false;
                while (shift.IdWorkers.Count > shift.WorkersCount)
                {
                    changed = true;
                    shift.IdWorkers.RemoveAt(rnd.Next(0, shift.IdWorkers.Count));
                }
                if (changed)
                {
                    new ShiftTDG().PatchShiftAsync(shift);
                }
            }
            new SuperiorPlanTDG().PatchSuperiorPlanAsync(pendingPlan);
            new SuperiorPlanTDG().PatchSuperiorPlanAsync(activePlan);
        }

        private async void cancelShiftButton_Click(object sender, EventArgs e)
        {
            if (requestsListView.SelectedItems.Count == 1)
            {
                settings = Properties.Settings.Default;

                string idRequest = requestsListView.SelectedItems[0].SubItems[0].Text;
                Request request = await new RequestTDG().GetRequestByIdAsync(idRequest);
                string idRequestor = request.IdCreatedBy;
                string idShift = request.IdForShift;

                // PATCH REQUEST
                request.Accepted = true;
                request.Resolved = true;
                new RequestTDG().PatchRequestAsync(request);

                // PATCH SHIFT
                Shift shift = await new ShiftTDG().GetShiftByIdAsync(idShift);
                var idWorkers = shift.IdWorkers;
                var itemToRemove = idWorkers.Single(r => r == idRequestor);
                idWorkers.Remove(itemToRemove);
                shift.IdWorkers = idWorkers;
                new ShiftTDG().PatchShiftAsync(shift);

                // POST NOTIF            
                Notification notification = new Notification
                {
                    IdForUsers = new List<string> { idRequestor },
                    NotificationType = "informational",
                    Show = true,
                    IdShift = idShift,
                    Message = "Smena ti byla zrusena.",
                    IdFromUser = settings.idUser
                };
                new NotificationTDG().AddNotificationAsync(notification);
            }
        }

        private void addInferiorButton_Click(object sender, EventArgs e)
        {
            new AddUserForm().ShowDialog();
        }

        private async void deleteInferiorButton_ClickAsync(object sender, EventArgs e)
        {
            if (inferiorsListView.SelectedItems.Count == 1)
            {
                string surname = inferiorsListView.SelectedItems[0].Text;
                User user = await new UserTDG().GetUserByIdAsync(surname);
                new UserTDG().DeleteUserAsync(user);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ClearLayout();
            InitViewAsync();
        }
    }
}
