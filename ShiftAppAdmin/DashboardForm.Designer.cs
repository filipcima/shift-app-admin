namespace ShiftAppAdmin
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inferiorsListView = new System.Windows.Forms.ListView();
            this.idInferior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameInferior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addInferiorButton = new System.Windows.Forms.Button();
            this.deleteInferiorButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nextShiftLabel = new System.Windows.Forms.Label();
            this.newPlanButton = new System.Windows.Forms.Button();
            this.shiftDateTimeLabel = new System.Windows.Forms.Label();
            this.shiftWorkersLabel = new System.Windows.Forms.Label();
            this.cancelShiftButton = new System.Windows.Forms.Button();
            this.requestsListView = new System.Windows.Forms.ListView();
            this.idRequest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeRequest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shiftText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestsLabel = new System.Windows.Forms.Label();
            this.generateProductionPlanButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inferiorsListView
            // 
            this.inferiorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idInferior,
            this.nameInferior});
            this.inferiorsListView.FullRowSelect = true;
            this.inferiorsListView.GridLines = true;
            this.inferiorsListView.Location = new System.Drawing.Point(943, 53);
            this.inferiorsListView.Name = "inferiorsListView";
            this.inferiorsListView.Size = new System.Drawing.Size(232, 526);
            this.inferiorsListView.TabIndex = 2;
            this.inferiorsListView.UseCompatibleStateImageBehavior = false;
            this.inferiorsListView.View = System.Windows.Forms.View.Details;
            this.inferiorsListView.SelectedIndexChanged += new System.EventHandler(this.inferiorsListView_SelectedIndexChanged);
            // 
            // idInferior
            // 
            this.idInferior.Text = "ID";
            this.idInferior.Width = 47;
            // 
            // nameInferior
            // 
            this.nameInferior.Text = "NAME";
            this.nameInferior.Width = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(939, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inferiors";
            // 
            // addInferiorButton
            // 
            this.addInferiorButton.Location = new System.Drawing.Point(943, 585);
            this.addInferiorButton.Name = "addInferiorButton";
            this.addInferiorButton.Size = new System.Drawing.Size(117, 30);
            this.addInferiorButton.TabIndex = 2;
            this.addInferiorButton.Text = "ADD";
            this.addInferiorButton.UseVisualStyleBackColor = true;
            this.addInferiorButton.Click += new System.EventHandler(this.addInferiorButton_Click);
            // 
            // deleteInferiorButton
            // 
            this.deleteInferiorButton.ForeColor = System.Drawing.Color.Red;
            this.deleteInferiorButton.Location = new System.Drawing.Point(1066, 585);
            this.deleteInferiorButton.Name = "deleteInferiorButton";
            this.deleteInferiorButton.Size = new System.Drawing.Size(109, 30);
            this.deleteInferiorButton.TabIndex = 3;
            this.deleteInferiorButton.Text = "DELETE";
            this.deleteInferiorButton.UseVisualStyleBackColor = true;
            this.deleteInferiorButton.Click += new System.EventHandler(this.deleteInferiorButton_ClickAsync);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Location = new System.Drawing.Point(22, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(199, 26);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Welcome, @name!";
            // 
            // nextShiftLabel
            // 
            this.nextShiftLabel.AutoSize = true;
            this.nextShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextShiftLabel.Location = new System.Drawing.Point(23, 76);
            this.nextShiftLabel.Name = "nextShiftLabel";
            this.nextShiftLabel.Size = new System.Drawing.Size(80, 20);
            this.nextShiftLabel.TabIndex = 5;
            this.nextShiftLabel.Text = "Next shift";
            // 
            // newPlanButton
            // 
            this.newPlanButton.Location = new System.Drawing.Point(27, 585);
            this.newPlanButton.Name = "newPlanButton";
            this.newPlanButton.Size = new System.Drawing.Size(107, 30);
            this.newPlanButton.TabIndex = 6;
            this.newPlanButton.Text = "ADD NEW PLAN";
            this.newPlanButton.UseVisualStyleBackColor = true;
            this.newPlanButton.Click += new System.EventHandler(this.newPlanButton_Click);
            // 
            // shiftDateTimeLabel
            // 
            this.shiftDateTimeLabel.AutoSize = true;
            this.shiftDateTimeLabel.Location = new System.Drawing.Point(27, 100);
            this.shiftDateTimeLabel.Name = "shiftDateTimeLabel";
            this.shiftDateTimeLabel.Size = new System.Drawing.Size(102, 13);
            this.shiftDateTimeLabel.TabIndex = 7;
            this.shiftDateTimeLabel.Text = "12/12 14:00 - 21:00";
            // 
            // shiftWorkersLabel
            // 
            this.shiftWorkersLabel.AutoSize = true;
            this.shiftWorkersLabel.Location = new System.Drawing.Point(30, 117);
            this.shiftWorkersLabel.Name = "shiftWorkersLabel";
            this.shiftWorkersLabel.Size = new System.Drawing.Size(133, 13);
            this.shiftWorkersLabel.TabIndex = 8;
            this.shiftWorkersLabel.Text = "David Krumnikl, Petr Heinz";
            // 
            // cancelShiftButton
            // 
            this.cancelShiftButton.ForeColor = System.Drawing.Color.Red;
            this.cancelShiftButton.Location = new System.Drawing.Point(529, 585);
            this.cancelShiftButton.Name = "cancelShiftButton";
            this.cancelShiftButton.Size = new System.Drawing.Size(380, 30);
            this.cancelShiftButton.TabIndex = 9;
            this.cancelShiftButton.Text = "CANCEL";
            this.cancelShiftButton.UseVisualStyleBackColor = true;
            this.cancelShiftButton.Click += new System.EventHandler(this.cancelShiftButton_Click);
            // 
            // requestsListView
            // 
            this.requestsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRequest,
            this.typeRequest,
            this.requestorName,
            this.shiftText});
            this.requestsListView.FullRowSelect = true;
            this.requestsListView.GridLines = true;
            this.requestsListView.Location = new System.Drawing.Point(529, 53);
            this.requestsListView.Name = "requestsListView";
            this.requestsListView.Size = new System.Drawing.Size(380, 526);
            this.requestsListView.TabIndex = 2;
            this.requestsListView.UseCompatibleStateImageBehavior = false;
            this.requestsListView.View = System.Windows.Forms.View.Details;
            this.requestsListView.SelectedIndexChanged += new System.EventHandler(this.requestsListView_SelectedIndexChanged);
            // 
            // idRequest
            // 
            this.idRequest.Text = "ID";
            this.idRequest.Width = 30;
            // 
            // typeRequest
            // 
            this.typeRequest.Text = "TYPE";
            this.typeRequest.Width = 45;
            // 
            // requestorName
            // 
            this.requestorName.Text = "REQUESTOR";
            this.requestorName.Width = 75;
            // 
            // shiftText
            // 
            this.shiftText.Text = "SHIFT";
            this.shiftText.Width = 226;
            // 
            // requestsLabel
            // 
            this.requestsLabel.AutoSize = true;
            this.requestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.requestsLabel.Location = new System.Drawing.Point(525, 26);
            this.requestsLabel.Name = "requestsLabel";
            this.requestsLabel.Size = new System.Drawing.Size(89, 24);
            this.requestsLabel.TabIndex = 11;
            this.requestsLabel.Text = "Requests";
            // 
            // generateProductionPlanButton
            // 
            this.generateProductionPlanButton.Location = new System.Drawing.Point(306, 585);
            this.generateProductionPlanButton.Name = "generateProductionPlanButton";
            this.generateProductionPlanButton.Size = new System.Drawing.Size(201, 30);
            this.generateProductionPlanButton.TabIndex = 12;
            this.generateProductionPlanButton.Text = "GENERATE PRODUCTION PLAN";
            this.generateProductionPlanButton.UseVisualStyleBackColor = true;
            this.generateProductionPlanButton.Click += new System.EventHandler(this.generateProductionPlanButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1100, 24);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 627);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.generateProductionPlanButton);
            this.Controls.Add(this.requestsLabel);
            this.Controls.Add(this.requestsListView);
            this.Controls.Add(this.cancelShiftButton);
            this.Controls.Add(this.shiftWorkersLabel);
            this.Controls.Add(this.shiftDateTimeLabel);
            this.Controls.Add(this.newPlanButton);
            this.Controls.Add(this.nextShiftLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.deleteInferiorButton);
            this.Controls.Add(this.addInferiorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inferiorsListView);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView inferiorsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addInferiorButton;
        private System.Windows.Forms.Button deleteInferiorButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nextShiftLabel;
        private System.Windows.Forms.Button newPlanButton;
        private System.Windows.Forms.Label shiftDateTimeLabel;
        private System.Windows.Forms.Label shiftWorkersLabel;
        private System.Windows.Forms.Button cancelShiftButton;
        private System.Windows.Forms.ListView requestsListView;
        private System.Windows.Forms.Label requestsLabel;
        private System.Windows.Forms.ColumnHeader idInferior;
        private System.Windows.Forms.ColumnHeader nameInferior;
        private System.Windows.Forms.ColumnHeader idRequest;
        private System.Windows.Forms.ColumnHeader typeRequest;
        private System.Windows.Forms.ColumnHeader requestorName;
        private System.Windows.Forms.ColumnHeader shiftText;
        private System.Windows.Forms.Button generateProductionPlanButton;
        private System.Windows.Forms.Button refreshButton;
    }
}