// See https://aka.ms/new-console-template for more information

//{
    /*
    Console.WriteLine("Hello, World!");
    {
        Console.WriteLine("Hello, World!");
    }

    string name;

    name = "Bob";
    */



    /*Console.Write($"Ваш возраст:");
    string? name = Console.ReadLine();*/

    /*double x = 10;
    double z = x % 4;

    int x1 = 5;
    int z1 = --x1; //z1 = 4; x1=4
    Console.WriteLine($"x1= {x1} z1= {z1});*/

    
    
    //решение задачи
    //подготовка данных
    
    /*
     
    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milkFatPercentage = 1.2F;
    ushort icecreamPrice = 250;

    Console.Write("Введите начальную сумму: ");
    string? sumString = Console.ReadLine();
    short sum = Convert.ToInt16(sumString);

    if (sum > 0)
    {
        if (!isWhiteBreadFresh)
        {
            Console.WriteLine("Батон не свежий");
        } 
        else if (sum >= whiteBreadPrice)
            {
                sum = Convert.ToInt16(sum - whiteBreadPrice);
                Console.WriteLine($"Купли свежий батон по цене {whiteBreadPrice}");
            }
        else
        {
            Console.WriteLine("на батон денег нет");
        }

        sum = (short)(sum - butterPrice);

        if (milkFatPercentage == 1.2F)
        {
            sum =Convert.ToInt16(sum - milkPrice);
        }

        if (sum >= icecreamPrice)
        {
            sum =Convert.ToInt16(sum - icecreamPrice);
        }
    
        Console.WriteLine($"Остаток суммы: {sum}");
    }
    else
    {
        Console.Write("Сумма не может быть меньше 0");
    }
    }
    */
   


int x = 1;
if (x == 1)
{
    Console.WriteLine("1");
}
else if (x==2)
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("Не соответствует условям");
}


switch (x)
{
   case 1 :
       Console.WriteLine("1");
       break;
   case 2:
       Console.WriteLine("2");
       break;
   default:
       Console.WriteLine("Не соответствует условям");
}


string name = "Tom";

switch (name)
{
    case "Alex":
        Console.WriteLine("Alex");
        break;
    case "Tom":
        Console.WriteLine("Tom");
        break;
}

string name1 = "Tom";

switch (name1.Equals("Alex"))
{
    case true:
        Console.WriteLine("Alex");
        break;
    case false:
        Console.WriteLine("Tom");
        break;
}