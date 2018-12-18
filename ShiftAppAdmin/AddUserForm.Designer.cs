namespace ShiftAppAdmin
{
    partial class AddUserForm
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
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.newUserFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserEmailLabel = new System.Windows.Forms.Label();
            this.newUserEmailTextBox = new System.Windows.Forms.TextBox();
            this.newUserPasswordLabel = new System.Windows.Forms.Label();
            this.newUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(12, 218);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(275, 23);
            this.createNewUserButton.TabIndex = 0;
            this.createNewUserButton.Text = "CREATE NEW USER";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButton_Click);
            // 
            // newUserFirstNameTextBox
            // 
            this.newUserFirstNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.newUserFirstNameTextBox.Name = "newUserFirstNameTextBox";
            this.newUserFirstNameTextBox.Size = new System.Drawing.Size(275, 20);
            this.newUserFirstNameTextBox.TabIndex = 1;
            // 
            // newUserFirstName
            // 
            this.newUserFirstName.AutoSize = true;
            this.newUserFirstName.Location = new System.Drawing.Point(12, 13);
            this.newUserFirstName.Name = "newUserFirstName";
            this.newUserFirstName.Size = new System.Drawing.Size(55, 13);
            this.newUserFirstName.TabIndex = 2;
            this.newUserFirstName.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Second name";
            // 
            // newUserSecondNameTextBox
            // 
            this.newUserSecondNameTextBox.Location = new System.Drawing.Point(12, 68);
            this.newUserSecondNameTextBox.Name = "newUserSecondNameTextBox";
            this.newUserSecondNameTextBox.Size = new System.Drawing.Size(275, 20);
            this.newUserSecondNameTextBox.TabIndex = 3;
            // 
            // newUserEmailLabel
            // 
            this.newUserEmailLabel.AutoSize = true;
            this.newUserEmailLabel.Location = new System.Drawing.Point(12, 91);
            this.newUserEmailLabel.Name = "newUserEmailLabel";
            this.newUserEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.newUserEmailLabel.TabIndex = 6;
            this.newUserEmailLabel.Text = "Email";
            // 
            // newUserEmailTextBox
            // 
            this.newUserEmailTextBox.Location = new System.Drawing.Point(12, 107);
            this.newUserEmailTextBox.Name = "newUserEmailTextBox";
            this.newUserEmailTextBox.Size = new System.Drawing.Size(275, 20);
            this.newUserEmailTextBox.TabIndex = 5;
            // 
            // newUserPasswordLabel
            // 
            this.newUserPasswordLabel.AutoSize = true;
            this.newUserPasswordLabel.Location = new System.Drawing.Point(12, 130);
            this.newUserPasswordLabel.Name = "newUserPasswordLabel";
            this.newUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.newUserPasswordLabel.TabIndex = 8;
            this.newUserPasswordLabel.Text = "Password";
            // 
            // newUserPasswordTextBox
            // 
            this.newUserPasswordTextBox.Location = new System.Drawing.Point(12, 146);
            this.newUserPasswordTextBox.Name = "newUserPasswordTextBox";
            this.newUserPasswordTextBox.Size = new System.Drawing.Size(275, 20);
            this.newUserPasswordTextBox.TabIndex = 7;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 265);
            this.Controls.Add(this.newUserPasswordLabel);
            this.Controls.Add(this.newUserPasswordTextBox);
            this.Controls.Add(this.newUserEmailLabel);
            this.Controls.Add(this.newUserEmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserSecondNameTextBox);
            this.Controls.Add(this.newUserFirstName);
            this.Controls.Add(this.newUserFirstNameTextBox);
            this.Controls.Add(this.createNewUserButton);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.TextBox newUserFirstNameTextBox;
        private System.Windows.Forms.Label newUserFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserSecondNameTextBox;
        private System.Windows.Forms.Label newUserEmailLabel;
        private System.Windows.Forms.TextBox newUserEmailTextBox;
        private System.Windows.Forms.Label newUserPasswordLabel;
        private System.Windows.Forms.TextBox newUserPasswordTextBox;
    }
}