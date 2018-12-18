namespace ShiftAppAdmin
{
    partial class NewProductionPlanForm
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
            this.newShiftToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newShiftMaxWorkersTextLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shiftsByPlanListView = new System.Windows.Forms.ListView();
            this.idShift = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxWorkers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addShiftButton = new System.Windows.Forms.Button();
            this.removeShiftButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newShiftFromTextBox = new System.Windows.Forms.TextBox();
            this.newShiftToTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newShiftToDatePicker
            // 
            this.newShiftToDatePicker.CustomFormat = "";
            this.newShiftToDatePicker.Location = new System.Drawing.Point(12, 521);
            this.newShiftToDatePicker.Name = "newShiftToDatePicker";
            this.newShiftToDatePicker.Size = new System.Drawing.Size(154, 20);
            this.newShiftToDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add new shift";
            // 
            // newShiftMaxWorkersTextLabel
            // 
            this.newShiftMaxWorkersTextLabel.Location = new System.Drawing.Point(571, 521);
            this.newShiftMaxWorkersTextLabel.Name = "newShiftMaxWorkersTextLabel";
            this.newShiftMaxWorkersTextLabel.Size = new System.Drawing.Size(100, 20);
            this.newShiftMaxWorkersTextLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maximum workers:";
            // 
            // shiftsByPlanListView
            // 
            this.shiftsByPlanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idShift,
            this.dateFrom,
            this.dateTo,
            this.maxWorkers,
            this.workers});
            this.shiftsByPlanListView.Location = new System.Drawing.Point(12, 12);
            this.shiftsByPlanListView.Name = "shiftsByPlanListView";
            this.shiftsByPlanListView.Size = new System.Drawing.Size(924, 479);
            this.shiftsByPlanListView.TabIndex = 7;
            this.shiftsByPlanListView.UseCompatibleStateImageBehavior = false;
            this.shiftsByPlanListView.View = System.Windows.Forms.View.Details;
            // 
            // idShift
            // 
            this.idShift.Text = "ID";
            this.idShift.Width = 34;
            // 
            // dateFrom
            // 
            this.dateFrom.Text = "DATE FROM";
            this.dateFrom.Width = 132;
            // 
            // dateTo
            // 
            this.dateTo.Text = "DATE TO";
            this.dateTo.Width = 133;
            // 
            // workers
            // 
            this.workers.Text = "WORKERS";
            this.workers.Width = 525;
            // 
            // maxWorkers
            // 
            this.maxWorkers.Text = "MAX WORKERS";
            this.maxWorkers.Width = 94;
            // 
            // addShiftButton
            // 
            this.addShiftButton.Location = new System.Drawing.Point(693, 519);
            this.addShiftButton.Name = "addShiftButton";
            this.addShiftButton.Size = new System.Drawing.Size(75, 23);
            this.addShiftButton.TabIndex = 8;
            this.addShiftButton.Text = "ADD SHIFT";
            this.addShiftButton.UseVisualStyleBackColor = true;
            this.addShiftButton.Click += new System.EventHandler(this.addShiftButton_Click);
            // 
            // removeShiftButton
            // 
            this.removeShiftButton.Location = new System.Drawing.Point(788, 519);
            this.removeShiftButton.Name = "removeShiftButton";
            this.removeShiftButton.Size = new System.Drawing.Size(97, 23);
            this.removeShiftButton.TabIndex = 9;
            this.removeShiftButton.Text = "REMOVE SHIFT";
            this.removeShiftButton.UseVisualStyleBackColor = true;
            this.removeShiftButton.Click += new System.EventHandler(this.removeShiftButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "From:";
            // 
            // newShiftFromTextBox
            // 
            this.newShiftFromTextBox.Location = new System.Drawing.Point(181, 521);
            this.newShiftFromTextBox.Name = "newShiftFromTextBox";
            this.newShiftFromTextBox.Size = new System.Drawing.Size(169, 20);
            this.newShiftFromTextBox.TabIndex = 11;
            // 
            // newShiftToTextBox
            // 
            this.newShiftToTextBox.Location = new System.Drawing.Point(364, 521);
            this.newShiftToTextBox.Name = "newShiftToTextBox";
            this.newShiftToTextBox.Size = new System.Drawing.Size(189, 20);
            this.newShiftToTextBox.TabIndex = 12;
            // 
            // NewProductionPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 609);
            this.Controls.Add(this.newShiftToTextBox);
            this.Controls.Add(this.newShiftFromTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeShiftButton);
            this.Controls.Add(this.addShiftButton);
            this.Controls.Add(this.shiftsByPlanListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newShiftMaxWorkersTextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newShiftToDatePicker);
            this.Name = "NewProductionPlanForm";
            this.Text = "NewProductionPlanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker newShiftToDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newShiftMaxWorkersTextLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView shiftsByPlanListView;
        private System.Windows.Forms.ColumnHeader idShift;
        private System.Windows.Forms.ColumnHeader dateFrom;
        private System.Windows.Forms.ColumnHeader dateTo;
        private System.Windows.Forms.ColumnHeader maxWorkers;
        private System.Windows.Forms.ColumnHeader workers;
        private System.Windows.Forms.Button addShiftButton;
        private System.Windows.Forms.Button removeShiftButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newShiftFromTextBox;
        private System.Windows.Forms.TextBox newShiftToTextBox;
    }
}