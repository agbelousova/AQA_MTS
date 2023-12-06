namespace Hospital;

public class Doctor
{
    //Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.
    public virtual void Heal()
    {
        Console.WriteLine("Вас вылечит доктор.");
    }
}