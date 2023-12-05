// See https://aka.ms/new-console-template for more information

using Properties;
//стандартный вариант работы с блоком данных
Person person = new Person();
person.SetName("Alex");
Console.WriteLine($"{person.GetName()}");

// В C# есть Свойство для доступа к полю name
person.Name = "Alex1";
person.Age = 45;
//person.Surname = "Иванов";  ошибка. свойство только для чтения
//person.Address = "Москва";  - ошибка - присвоить адрес нельзя, потому что private set { address = value; }

Console.WriteLine($"{person.Name}");
//Console.WriteLine($"{person.Age}");  ошибка получить уже нельзя, только установить
Console.WriteLine($"{person.Surname}");
Console.WriteLine($"{person.Fullname}");
Console.WriteLine($"{person.Address}");
Console.WriteLine($"{person.Salary}");

//Блок init
//Первый способ
//person.ID = "YYY-721";   - Ошибка
Console.WriteLine($"{person.ID}");

/*
//Второй способ
Person person1 = new Person("YYY-751");
Console.WriteLine($"{person1.ID}");

//третий способ с использованием базового конструктора
Person person2 = new Person(){ID = "CCC-751"};
Console.WriteLine($"{person2.ID}");
*/

//Person person3 = new Person() { Passport = "1542 154154" };
//Person person4 = new Person("1452 145120");   //ошибка
