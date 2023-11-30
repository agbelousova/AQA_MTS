namespace ClassesHM
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[3];
            //три экземпляра класса используя разные конструкторы
            phones[0] = new Phone();
            phones[1] = new Phone("+7(960)-500-1010", "google");
            phones[2] = new Phone("+7(960)-500-1010", "google", 150);
            //Вывод на консоль значения их переменных
            foreach (var phone in phones)
            {
                Console.Write($"Телефон: {phone.number}, Модель: {phone.model}, Вес: {phone.weight}");
                Console.WriteLine();
            }
            Console.WriteLine();

            string[] name = { "Саша", "Лена", "Антон" };

            foreach (var call in name)
            {
                new Phone().receiveCall(call);
                Console.WriteLine(new Phone().getNumber());
            }
            Console.WriteLine();

            string[] phonesMess1 = new string[2];
            for (int i = 0; i < 2; i++)
            {
                phonesMess1[i] = new Phone().getNumber();
                new Phone().sendMessage(phonesMess1[i]);
            }
            Console.WriteLine();
            
            string[] phonesMess2 = new string[5];
            for (int i = 0; i < 5; i++)
            {
                phonesMess2[i] = new Phone().getNumber();
                new Phone().sendMessage(phonesMess2[i]);
            }
        }
    }
}