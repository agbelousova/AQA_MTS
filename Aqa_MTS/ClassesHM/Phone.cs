namespace ClassesHM;

public class Phone
{
    public string number;
    public string model;
    public int weight;

    public Phone()
    {
        number = "+7(950)-300-5010";
        model = "apple";
        weight = 200;
    }

    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
    }

    public Phone(string number, string model, int weight) : this(number, model)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public void receiveCall(string name)
    {
        Console.Write($"Звонит {name}: ");
    }

    public string getNumber()
    {
        Random rand = new Random();
        int num = rand.Next(000, 999);
        int num2 = rand.Next(00, 99);
        int num3 = rand.Next(00, 99);
        return number = "+7 (987)" + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString();
    }

    public void sendMessage(params string[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.WriteLine($"Сообщение отправлено: {num}");
        }
    }
}