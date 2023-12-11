//задание 1
//консольный калькулятор
//ввод данных


/*double otvet;

Console.Write("Вас приветствует калькулятор. \nПри вводе дробного числа введите его в формате 3,5 \nВведите число номер 1: ");
string? chislo1String = Console.ReadLine();
//string? chislo1String = string.Format("{0:f}", Console.ReadLine());
//decimal chislo1 = Convert.ToDecimal(chislo1String);
double chislo1 = Convert.ToDouble(chislo1String);


Console.Write("Введите операцию (+, -, *, /): ");
string? operasia = Console.ReadLine();

Console.Write("Введите число номер 2: ");
string? chislo2String = Console.ReadLine();
double chislo2 = Convert.ToDouble(chislo2String);

//организация выбора операци с помощью switch

switch (operasia)
{
    case "/":
        if (chislo2 != 0)
        {
            otvet = chislo1 / chislo2;
            Console.WriteLine($"Ответ: {otvet}");
        }
        else
        {
            Console.Write("На 0 делить нельзя!");
        }
        break;
    case "+":
        otvet = chislo1 + chislo2;
        Console.WriteLine($"Ответ: {otvet}");
        break;
    case "*":
        otvet = chislo1 * chislo2;
        Console.WriteLine($"Ответ: {otvet}");
        break;
    case "-":
        otvet = chislo1 - chislo2;
        Console.WriteLine($"Ответ: {otvet}");
        break;
    default:
        Console.WriteLine("Не соответствует условиям");
        break;
}
*/


//задание 2

/*
Напишите программу определения, попадает ли введенное пользователем число (от -50 до 50) в один из числовых промежутков [-40, -10] [-9, 0] [1, 10][11, 40].
    Если да, то укажите, в какой именно промежуток.
    Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
    */


/*
//Ввод числа

Console.Write("Введите целое число от -50 до 50: ");
string? chisloString = Console.ReadLine();
int chislo = Convert.ToInt32(chisloString);

//использоване оператора if для выбора промежутка

if ((chislo >= -40) && (chislo <= -10))
{
    Console.WriteLine("Введенное число попало в промежуток [-40, -10]");
} else if ((chislo >= -9) && (chislo <= 0))
{
    Console.WriteLine("Введенное число попало в промежуток [-9, 0]");
} else if ((chislo >= 1) && (chislo <= 10))
{
    Console.WriteLine("Введенное число попало в промежуток [1, 10]");
} else if ((chislo >= 11) && (chislo <= 40))
{
    Console.WriteLine("Введенное число попало в промежуток [11, 40]");
}
else
{
    Console.WriteLine("Введенное число не попало ни в один доступный промежуток");
}
*/

//Задание 3

/*
Напишите программу русско-английский переводчик.
    Программа знает 10 слов о погоде.
    Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
    Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
    */


Console.Write("Вас приветствует русско-английский переводчик. \nПрограмма знает 10 слов о погоде.\nВведите ваше слово: ");
string? slovo = Console.ReadLine();

switch (slovo)
{
    case "дождь":
        Console.WriteLine("rain");
        break;
    case "солнце":
        Console.WriteLine("the sun");
        break;
    case "ветер":
        Console.WriteLine("wind");
        break;
    case "снег":
        Console.WriteLine("snow");
        break;
    case "туман":
        Console.WriteLine("fog");
        break;
    case "жара":
        Console.WriteLine("heat");
        break;
    case "мороз":
        Console.WriteLine("frost");
        break;
    case "шторм":
        Console.WriteLine("storm");
        break;
    case "град":
        Console.WriteLine("hail");
        break;
    case "радуга":
        Console.WriteLine("rainbow");
        break;
    default:
        Console.WriteLine("Такого слова нет");
        break;
}


//задане 4
/*
Напишите программу, которая будет выполнять проверку чисел на четность.
    Предложите два варианта решения поставленной задачи.
    */

/*
Console.Write("Введите число, чтобы узнать четное оно или нет: ");
string? chisloString = Console.ReadLine();
int chislo = Convert.ToInt32(chisloString);

//первый способ

if (chislo % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("не четное");
}

//второй способ

switch (chislo % 2 == 0)
{
    case true:
        Console.WriteLine("четное");
        break;
    default:
        Console.WriteLine("не четное");
        break;
}*/