namespace Hospital;
//Дантист
public class Dantist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Вас успешно вылечил дантист.");
    }
}