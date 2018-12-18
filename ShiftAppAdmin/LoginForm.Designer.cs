namespace ShiftAppAdmin
{
    partial class LoginForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ShiftAppLabel = new System.Windows.Forms.Label();
            this.administraceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(21, 236);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(248, 37);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Heslo";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(19, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(19, 189);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // ShiftAppLabel
            // 
            this.ShiftAppLabel.AutoSize = true;
            this.ShiftAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShiftAppLabel.ForeColor = System.Drawing.Color.Red;
            this.ShiftAppLabel.Location = new System.Drawing.Point(72, 19);
            this.ShiftAppLabel.Name = "ShiftAppLabel";
            this.ShiftAppLabel.Size = new System.Drawing.Size(140, 38);
            this.ShiftAppLabel.TabIndex = 5;
            this.ShiftAppLabel.Text = "ShiftApp";
            this.ShiftAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administraceLabel
            // 
            this.administraceLabel.AutoSize = true;
            this.administraceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.administraceLabel.Location = new System.Drawing.Point(109, 69);
            this.administraceLabel.Name = "administraceLabel";
            this.administraceLabel.Size = new System.Drawing.Size(67, 13);
            this.administraceLabel.TabIndex = 6;
            this.administraceLabel.Text = "Administrace";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 324);
            this.Controls.Add(this.administraceLabel);
            this.Controls.Add(this.ShiftAppLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label ShiftAppLabel;
        private System.Windows.Forms.Label administraceLabel;
    }
}

