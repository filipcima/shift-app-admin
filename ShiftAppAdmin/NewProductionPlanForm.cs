using ShiftAppAdmin.Helpers;
using ShiftAppAdmin.Models;
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
    public partial class NewProductionPlanForm : Form
    {
        private string IdPlan { get; set; }
        private string IdOwner { get; set; }
        public NewProductionPlanForm()
        {
            var settings = Properties.Settings.Default;
            IdOwner = settings.idUser;
            InitializeComponent();
            SuperiorPlan superiorPlan = new SuperiorPlan
            {
                IdOwner = IdOwner,
                Status = "pending"
            };
            createNewPlan(superiorPlan);
        }

        private async Task createNewPlan(SuperiorPlan superiorPlan)
        {
            await new SuperiorPlanTDG().AddSuperiorPlanAsync(superiorPlan);
            SuperiorPlan newPlan = await new SuperiorPlanTDG().GetLatestSuperiorPlanByIdOwner(IdOwner);
            IdPlan = newPlan.Id;
        }

        private async void addShiftButton_Click(object sender, EventArgs e)
        {
            String timeFrom = newShiftFromTextBox.Text;
            String timeTo = newShiftToTextBox.Text;
            DateTime date = newShiftToDatePicker.Value;
            if (timeFrom != "" && timeTo != "" && int.TryParse(newShiftMaxWorkersTextLabel.Text, out int workersCount))
            {
                String datetimeFrom = $"{date.ToString("dd/MM/yy").Replace('.', '/')} {timeFrom}:00";
                String datetimeTo = $"{date.ToString("dd/MM/yy").Replace('.', '/')} {timeTo}:00";

                Shift shift = new Shift
                {
                    IdSuperiorPlan = IdPlan,
                    DateFrom = datetimeFrom,
                    DateTo = datetimeTo,
                    WorkersCount = workersCount
                };
                await new ShiftTDG().AddShiftAsync(shift);
                PopulateListView();                
            }
        }

        private async void PopulateListView()
        {
            shiftsByPlanListView.Items.Clear();
            List<Shift> shifts = await new ShiftTDG().GetShiftsByIdSuperiorPlanAsync(IdPlan);
            foreach (Shift s in shifts)
            {
                ListViewItem lvi = new ListViewItem(s.Id);
                lvi.SubItems.Add(s.DateFrom);
                lvi.SubItems.Add(s.DateTo);
                lvi.SubItems.Add(s.WorkersCount.ToString());

                List<User> workers = await s.GetWorkers();
                if (workers != null && workers.Count > 0)
                {
                    lvi.SubItems.Add(Formatter.GetWorkersString(workers));
                }
                shiftsByPlanListView.Items.Add(lvi);
            }
        }

        private async void removeShiftButton_Click(object sender, EventArgs e)
        {
            
            if (shiftsByPlanListView.SelectedItems.Count == 1)
            {
                Shift shift = new Shift
                {
                    Id = shiftsByPlanListView.SelectedItems[0].Text
                };
                await new ShiftTDG().DeleteShiftAsync(shift);
                PopulateListView();
            }
        }
    }
}
