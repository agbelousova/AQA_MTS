namespace ClassesHM
{
    class Program
    {
        static void Main(string[] args)
        {
            //======= Первая задача
            //три экземпляра класса используя разные конструкторы
            Phone phone1 = new();
            Phone phone2 = new("+7(912)-500-1010", "google");
            Phone phone3 = new("+7(911)-500-5010", "samsung", 150);

            Phone[] phones = { phone1, phone2, phone3 };


            //Вывод на консоль значения их переменных
            foreach (var phone in phones)
            {
                Console.Write($"Телефон: {phone.number}, Модель: {phone.model}, Вес: {phone.weight}");
                Console.WriteLine();
            }
            Console.WriteLine();

            string[] name = { "Саша", "Лена", "Антон" };


            //вызов методов receiveCall и getNumber для каждого из объектов

            foreach (Phone p in phones)
            {
                p.receiveCall("Sasha");
                Console.Write($" звонит с номера {p.getNumber()}\n");
            }


            //второй способ вызова методов
            /*
            foreach (var call in name)
            {
                new Phone().receiveCall(call);
                Console.WriteLine(new Phone().getNumber());
            }
            */
            Console.WriteLine();

            phone1.sendMessage("79115002010", "+79501001010");
            phone1.sendMessage("79115002111", "+79501001222", "+79501001333", "+79501001444", "+79501001555");


            //второй способ вызова метода sendMessage
            /*
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
            */
            //======= Вторая задача
            //три объекта класса CreditCard у которых заданы номер счета и начальная сумма
            CreditCard creditCard1 = new("15000000000150001", 500);
            CreditCard creditCard2 = new("15000000000150002", 1000);
            CreditCard creditCard3 = new("15000000000150003", 1500);
            CreditCard[] creditCards = { creditCard1, creditCard2, creditCard3 };
            // положить деньги на первые два счета и снять с третьего
            creditCard1.AddAmount(150);
            creditCard2.AddAmount(500);
            creditCard3.TakeAmount(1600);
            //вывод текущего состояния карточек
            foreach (var creditCard in creditCards)
            {
                creditCard.GetInfo();
                Console.WriteLine();
            }
        }
    }
}