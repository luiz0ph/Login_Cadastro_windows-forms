using Login_Cadastro_windows_forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Cadastro_windows_forms.Views
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void OpenLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ChangeVisibility(object sender, EventArgs e)
        {
            if (PasswordCheckBoxSingUp.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void SubmitSingUp(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (DataBaseHelper.CreateUser(name, email, password))
                {
                    MessageBox.Show("Usuario criado com sucesso!");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possível criar o usuario!");
                    NameTextBox.Clear();
                    EmailTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
        }
    }
}
