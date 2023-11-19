// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

/*int[] array = { 1, 9, 3, 6, 5 };

int[] array1;
int n = 4;
array1 = new int[n];

int[] array2 = new int[5] { 1, 9, 3, 6, 5 };


Console.WriteLine($"Last item in array: {array[^2]}");

Console.WriteLine(array[0]);
Console.WriteLine("Lengh: " + array.Length);  //кол-во элементов в массве
Console.WriteLine("Rank: " + array.Rank);     //ранк массива
Console.WriteLine("GetLength: " + array.GetLength(0));     //кол-во строк
Console.WriteLine("GetUpperBound: " + array.GetUpperBound(0));     //верхний индекс строк - ииндекс первого элемента строки
Console.WriteLine("GetLowerBound: " + array.GetLowerBound(0));     //нижнй индекс строк - ииндекс последнего элемента строки

//поск элемента массива по индексам

for (int i = 0; i < array.GetLength(0) ; i++)
{
    Console.Write($"{array [i]} ");
}

Console.WriteLine();*/

/*
int[] array = { 1, 9, 3, 6, 5 };

//поск элемента массива по индексам - обращение к элементу массива для дальнейшей работы с элементом найденого массива
// в for можно задать новое значение элементу массива
for (int i = 0; i <= array.GetUpperBound(0) ; i++)
{
    array[i] = new Random().Next(100);    //присвоение элементу массива новое рандомное число
    Console.Write($"{array [i]} ");
}
Console.WriteLine();

//перебор каждого элемента (не индекса) массива (для каждого элемента из массива выполнить действие)
//получение значение массва, задать новое нельзя
foreach (int item in array)
{
    Console.Write($"{item} ");
}

//вывод на экран десять раз слово
for (int i = 1; i <= 10; i++)
{
    Console.Write($"{i} Hello!");
}

//все четные числа от 0 до 10 
for (int i = 0; i <= 10; i +=2 )   //шаг 2
{
    if (i == 6)
        break;  //прервать цикл  когда i = 6 и выходим из него
    //continue - пропуск дальнейших действй если if (i == 6) с элементом массива  переход к следующему
        Console.Write($"{i} ");
    
}

//вывести массив строки по буквам
string text = "Hello!";
foreach (char ch in text)
{
    
    Console.Write($"{ch} ");
}

int [] arr2 = new int[6];

int u = 6;
bool flag = true;

do
{
    if (u < 0)
    {
        flag = false;
    }
    Console.WriteLine($"{u} ");
    u--;
}
while(flag);

//while (условие);
//{выполнить}
int u = 6;
do
{
    Console.WriteLine($"{u} ");
    u--;
}
while (u >= 0);

//двумерные [строка, столбцы]
int[,] array2 = new int[4, 5];
//задание значений
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = i + j;
    }
}

//вывод массива

int rows = array2.GetLength(0);
int columns = array2.Length / rows;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array2[i,j]} \t");
    }
    Console.WriteLine();
}
*/


//Задание 1
//Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, 
//входит ли заданное число в массив или нет. 
//Пусть число для поиска задается с консоли.
/*
int[] array = { 10, -6, 3, -9, 5 , -7 , 0, 9};

Console.Write("Введите целое число от -10 до 10: ");
string? chisloString = Console.ReadLine();
int chislo = Convert.ToInt32(chisloString);

int i = 0;      //дополнительная переменная 
bool flag = false;

while (i < array.GetLength(0))   
{
    foreach (int item in array)
            {
                if (item == chislo)
                    {
                        flag = true;
                        break;
                     } 
                }
    i++;
}

if (flag == true)
    {Console.Write("Введенное число входит в массив"); }
else {
    Console.WriteLine("Введенное число НЕ входит в массив");
}
*/
      
/*
Задание 2
Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.
*/

/*
int[] array = {10, 6, 3, 9, 5 , 7 , 0, 9, 0 , 8};
int i = 0;      //дополнительная переменная 

Console.Write("Есть массив целых чисел:\n");

for (i = 0; i < array.GetLength(0) ; i++)
{
    Console.Write($"{array [i]} ");
}
    Console.WriteLine();

Console.Write("Введите целое число от 0 до 10, чтобы исключить его из массива ");
string? chisloString = Console.ReadLine();
int chislo = Convert.ToInt32(chisloString);

int sovpadenie = 0;   //переменная для подсчета совпадений введенного числа

for (i = 0; i <= array.GetUpperBound(0) ; i++)
    {
        if (array[i] != chislo)    
        {
            Console.Write($"{array [i]} ");
            sovpadenie++;
         }
    }

if (sovpadenie == 10)
      {  
        Console.WriteLine();
        Console.Write("Введенное число НЕ входит в массив!"); 
      }
*/

/*
Задание 3
Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random() . 
Пусть будет возможность создавать массив произвольного размера. 
Пусть размер массива вводится с консоли.
*/

/*
Console.Write("Введите размер массива ");
string? razmerArrString = Console.ReadLine();
int razmerArr = Convert.ToInt32(razmerArrString);

int sred;   //среднее значение
int sum = 0;    //подсчет суммы элементов массива

int[] array = new int[razmerArr];

Console.Write("Массив из случайных чисел: \n");

for (int i = 0; i <= array.GetUpperBound(0) ; i++)
{
    array[i] = new Random().Next(100);    //присвоение элементу массива новое рандомное число
    Console.Write($"{array [i]} ");
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine();

sred = sum / razmerArr;

Console.WriteLine("Минимальное число из массива " + array.Min());
Console.WriteLine("Максимальное число из массива " + array.Max());
Console.WriteLine("Среднее арифметическое значение элементов массива " + sred);

*/

/*
Задание 4
Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
*/

/*
int[] array1 = new int[5];
int[] array2 = new int[5];
int sred1;   //среднее значение
int sum1 = 0;    //подсчет суммы элементов массива
int sred2;   //среднее значение
int sum2 = 0;    //подсчет суммы элементов массива

Console.Write("Первый массив из случайных чисел: \n");

for (int i = 0; i <= 4 ; i++)
{
    array1[i] = new Random().Next(100);    //присвоение элементу массива новое рандомное число
    Console.Write($"{array1 [i]} ");
    sum1 = sum1 + array1[i];
}
Console.WriteLine();
Console.Write("Второй массив из случайных чисел: \n");

for (int i = 0; i <= 4 ; i++)
{
    array2[i] = new Random().Next(100);    //присвоение элементу массива новое рандомное число
    Console.Write($"{array2 [i]} ");
    sum2 = sum2 + array2[i];
}
Console.WriteLine();

sred1 = sum1 / 5;
sred2 = sum2 / 5;

if (sred1 == sred2) 
    {
        Console.WriteLine("Среднее арифметическое значение элементов обоих массивов РАВНО!");
    }
    else if (sred1 > sred2) 
        {
                Console.WriteLine("Среднее арифметическое значение элементов ПЕРВОГО массива больше!");
            }
        else {
                     Console.WriteLine("Среднее арифметическое значение элементов ВТОРОГО массива больше!");
                 }

*/