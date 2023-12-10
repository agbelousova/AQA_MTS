namespace Exceptions_HM;

public class WrongPasswordException : Exception
{
    public string Value { get; }

    public WrongPasswordException(string value, string message)
        : base($"Неверный ввод в поле {message}")
    {
        Value = value;
    }


    public WrongPasswordException()
    {
    }
}