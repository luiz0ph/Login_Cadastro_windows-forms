using Login_Cadastro_windows_forms.Models;

namespace Login_Cadastro_windows_forms.Controllers;

public class UserController
{
    public bool SingUp(string name, string email, string password)
    {
        return DataBaseHelper.CreateUser(name, email, password);
    }

    public bool Login(string email, string password)
    {
        return DataBaseHelper.VerifyLogin(email, password);
    }
}
