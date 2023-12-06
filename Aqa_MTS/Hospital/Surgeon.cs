namespace Hospital;
//Хирург
public class Surgeon : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Вас успешно вылечил хирург.");
    }
}