namespace Exceptions_HM;

public class ExceptionAuthhorization
{
    public bool ExceptionAuthhoriz()
    {
        try
        {
            Authorization person = new Authorization { Login = "Tom ", Password = "eop", ConfirmPassword = "eop" };
        }
        catch (WrongLoginException login)
        {
            Console.WriteLine($"Ошибка: {login.Message}");
            Console.WriteLine($"Некорректное значение: {login.Value}");
            return false;
        }

        catch (WrongPasswordException password)
        {
            Console.WriteLine($"Ошибка: {password.Message}");
            Console.WriteLine($"Некорректное значение: {password.Value}");
            return false;
        }
        
        return true;
    }
}