using System.Text.RegularExpressions;

namespace Exceptions_HM;

public class Authorization()
{
    public void Run()
    {
        try
        {
            Console.Write("Введите логин: ");
            string? login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string? password = Console.ReadLine();

            Console.Write("Введите пароль повторно: ");
            string? confirmPassword = Console.ReadLine();

            if (IsCorrectRegistration(login, password, confirmPassword))
                Console.WriteLine("Все данные корректны");
        }
        catch (WrongLoginException exLogin)
        {
            Console.WriteLine($"Ошибка при вводе логина: {exLogin.Message}");
        }
        catch (WrongPasswordException exPassword)
        {
            Console.WriteLine($"Ошибка при вводе пароля: {exPassword.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    private static bool IsCorrectRegistration(string? login, string? password, string? confirmPassword)
    {
        bool result = true;

        if (String.IsNullOrWhiteSpace(login))
        {
            result = false;
            throw new WrongLoginException(login, "Задана пустая строка");
        }

        if (login.Length > 19 || login.Length == 0 || login.IndexOf(' ') > -1)
        {
            result = false;
            throw new WrongLoginException(login,
                $"login - поле должно быть не более 20 символов и не содержать пробелы!");
        }

        string pattern = @"\d";
        bool isNumber;
        isNumber = Regex.IsMatch(password, pattern);

        if (String.IsNullOrWhiteSpace(password))
        {
            result = false;
            throw new WrongPasswordException(password, "Задана пустая строка");
        }

        if (!isNumber || password.Length > 19 || password.Length == 0 || password.IndexOf(' ') > -1)
        {
            result = false;
            throw new WrongPasswordException(password,
                $"{password} - поле должно быть не более 20 символов, содержать хотя бы одну цифру и не должно содержать пробелы!");
        }

        if (password != confirmPassword)
        {
            result = false;
            Console.WriteLine("Пароли не совпадают");
        }
        return result;
    }
}