using Login_Cadastro_windows_forms.Models;
using Login_Cadastro_windows_forms.Views;

namespace Login_Cadastro_windows_forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ChangeVisibility(object sender, EventArgs e)
        {
            if (PasswordCheckBoxLogin.Checked)
            {
                PasswordTextBoxLogin.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBoxLogin.PasswordChar = '*';
            }
        }

        private void SubmitLogin(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBoxLogin.Text;

            if (DataBaseHelper.VerifyLogin(email, password))
            {
                MainApplication application = new MainApplication();
                application.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou Senha incorretos");
                EmailTextBox.Clear();
                PasswordTextBoxLogin.Clear();
            }
        }

        private void OpenSingUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.Show();
            this.Hide();
        }
    }
}
