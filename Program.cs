using Login_Cadastro_windows_forms.Models;

namespace Login_Cadastro_windows_forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataBaseHelper.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.Run(new Login());
        }
    }
}