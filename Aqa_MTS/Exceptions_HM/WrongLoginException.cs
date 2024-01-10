namespace Exceptions_HM;

public class WrongLoginException : Exception
{
    public string Value { get; }

    public WrongLoginException(string value, string message)
        : base($"Неверный ввод в поле {message}")
    {
        Value = value;
    }

    public WrongLoginException()
    {
    }
}