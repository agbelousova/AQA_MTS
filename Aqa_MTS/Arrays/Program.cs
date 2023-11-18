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

//вывод на экран дсять раз слово
for (int i = 1; i <= 10; i++)
{
    Console.Write($"{i} Hello!");
}

//все четные чсла от 0 до 10 
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
