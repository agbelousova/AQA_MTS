namespace Hospital;
//Терапевт
public class Therapist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Вас успешно вылечил терапевт.");
    }
}