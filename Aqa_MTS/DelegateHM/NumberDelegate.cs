namespace DelegateHM;

public class NumberDelegate
{
    public delegate int NumberRandomDeligate();

    public void Run()
    {
        NumberRandomDeligate numberRandomDeligate = new (NumberRandom);
        Console.WriteLine($"Случайное число от 0 до 10: {numberRandomDeligate()}");
        
    }
    private int NumberRandom()
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число (в диапазоне от 0 до 10)
        return rnd.Next(0, 10);
    }
}