namespace Login_Cadastro_windows_forms
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            titleLogin = new Label();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordCheckBoxLogin = new CheckBox();
            btnSubmitLogin = new Button();
            SuspendLayout();
            // 
            // titleLogin
            // 
            resources.ApplyResources(titleLogin, "titleLogin");
            titleLogin.FlatStyle = FlatStyle.Popup;
            titleLogin.Name = "titleLogin";
            // 
            // EmailLabel
            // 
            resources.ApplyResources(EmailLabel, "EmailLabel");
            EmailLabel.Name = "EmailLabel";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(EmailTextBox, "EmailTextBox");
            EmailTextBox.Name = "EmailTextBox";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(PasswordLabel, "PasswordLabel");
            PasswordLabel.Name = "PasswordLabel";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // PasswordCheckBoxLogin
            // 
            resources.ApplyResources(PasswordCheckBoxLogin, "PasswordCheckBoxLogin");
            PasswordCheckBoxLogin.Cursor = Cursors.Hand;
            PasswordCheckBoxLogin.Name = "PasswordCheckBoxLogin";
            PasswordCheckBoxLogin.UseVisualStyleBackColor = true;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = SystemColors.AppWorkspace;
            btnSubmitLogin.Cursor = Cursors.Hand;
            resources.ApplyResources(btnSubmitLogin, "btnSubmitLogin");
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSubmitLogin);
            Controls.Add(PasswordCheckBoxLogin);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(titleLogin);
            Name = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLogin;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private CheckBox PasswordCheckBoxLogin;
        private Button btnSubmitLogin;
    }
}
