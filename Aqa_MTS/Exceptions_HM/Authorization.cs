using System.Text.RegularExpressions;

namespace Exceptions_HM;

public class Authorization ()
{
    private string login;
    private string password;
    private string confirmPassword;
 

    public string Login
    {
        get => login;
        set
        {
            if (value.Length > 19 || value.Length==0 || value.IndexOf(' ') > -1)
                throw new WrongLoginException(value,$"login - поле должно быть не более 20 символов и не содержать пробелы!");
                login = value;
        }
    }

    public string Password
    {
        get => password;
        set
        {
            string pattern = @"\d";
            bool isNumber;
            isNumber = Regex.IsMatch(value, pattern);

            if (!isNumber || value.Length > 19 || value.Length == 0 || value.IndexOf(' ') > -1)
                throw new WrongPasswordException(value,
                    $"{value} - поле должно быть не более 20 символов, содержать хотя бы одну цифру и не должно содержать пробелы!");
                password = value;
        }
    }

    public string ConfirmPassword
    {
        get => confirmPassword;
        set
        {
            if (value != password)
                Console.WriteLine("Поля password и confirmPassword должны быть одинаковыми!");
            confirmPassword = value;
        }
    }
    
}