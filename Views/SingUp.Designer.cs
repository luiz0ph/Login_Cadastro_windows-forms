namespace Login_Cadastro_windows_forms.Views
{
    partial class SingUp
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
            TitleSingUp = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordCheckBoxSingUp = new CheckBox();
            btnSubmitSingUp = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // TitleSingUp
            // 
            TitleSingUp.AutoSize = true;
            TitleSingUp.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            TitleSingUp.Location = new Point(63, 9);
            TitleSingUp.Name = "TitleSingUp";
            TitleSingUp.Size = new Size(103, 25);
            TitleSingUp.TabIndex = 0;
            TitleSingUp.Text = "Sing Up";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Verdana", 10F, FontStyle.Bold);
            NameLabel.Location = new Point(34, 61);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(57, 17);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(34, 83);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name";
            NameTextBox.Size = new Size(177, 23);
            NameTextBox.TabIndex = 2;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Verdana", 10F, FontStyle.Bold);
            EmailLabel.Location = new Point(34, 130);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(55, 17);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(34, 152);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "email@exemplo.com";
            EmailTextBox.Size = new Size(177, 23);
            EmailTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Verdana", 10F, FontStyle.Bold);
            PasswordLabel.Location = new Point(34, 197);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(90, 17);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(34, 217);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(177, 23);
            PasswordTextBox.TabIndex = 6;
            // 
            // PasswordCheckBoxSingUp
            // 
            PasswordCheckBoxSingUp.AutoSize = true;
            PasswordCheckBoxSingUp.Cursor = Cursors.Hand;
            PasswordCheckBoxSingUp.Location = new Point(34, 246);
            PasswordCheckBoxSingUp.Name = "PasswordCheckBoxSingUp";
            PasswordCheckBoxSingUp.Size = new Size(108, 19);
            PasswordCheckBoxSingUp.TabIndex = 7;
            PasswordCheckBoxSingUp.Text = "Show Password";
            PasswordCheckBoxSingUp.UseVisualStyleBackColor = true;
            PasswordCheckBoxSingUp.CheckedChanged += ChangeVisibility;
            // 
            // btnSubmitSingUp
            // 
            btnSubmitSingUp.BackColor = SystemColors.AppWorkspace;
            btnSubmitSingUp.Cursor = Cursors.Hand;
            btnSubmitSingUp.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnSubmitSingUp.Location = new Point(49, 296);
            btnSubmitSingUp.Name = "btnSubmitSingUp";
            btnSubmitSingUp.Size = new Size(127, 26);
            btnSubmitSingUp.TabIndex = 8;
            btnSubmitSingUp.Text = "Submit";
            btnSubmitSingUp.UseVisualStyleBackColor = false;
            btnSubmitSingUp.Click += SubmitSingUp;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(151, 247);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += OpenLogin;
            // 
            // SingUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 361);
            Controls.Add(linkLabel1);
            Controls.Add(btnSubmitSingUp);
            Controls.Add(PasswordCheckBoxSingUp);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(TitleSingUp);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(251, 400);
            MinimumSize = new Size(251, 400);
            Name = "SingUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SingUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleSingUp;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private CheckBox PasswordCheckBoxSingUp;
        private Button btnSubmitSingUp;
        private LinkLabel linkLabel1;
    }
}