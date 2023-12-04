namespace ClassesHM;

public class CreditCard
{
    public string accountNumber;
    private double amountAccount;

    public CreditCard(string accountNumber)
    {
        this.accountNumber = accountNumber;
        amountAccount = 0;
    }

    public CreditCard(string accountNumber, double amountAccount) : this(accountNumber)
    {
        this.accountNumber = accountNumber;
        this.amountAccount = amountAccount;
    }


    // метод зачисляет сумму на кредитную карту
    public void AddAmount(double amount) => amountAccount += amount;


    // метод позволяет снимать некоторую сумму с карты
    public void TakeAmount(double amount)
    {
        if (amountAccount >= amount)
        {
            amountAccount -= amount;
        }
        else
        {
            Console.WriteLine(
                $"На счёте {this.accountNumber} недостаточно денежных средств.\nТекущий баланс: {amountAccount}");
        }
    }


    // метод выводит текущую информацию о карточке
    public void GetInfo()
    {
        Console.WriteLine($"Номер счета: {this.accountNumber}\nБаланс: {this.amountAccount}");
    }
}