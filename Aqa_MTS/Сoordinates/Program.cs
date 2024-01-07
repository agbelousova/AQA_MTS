/*
 Задание 1:
Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
внутренние поля x, y;
конструктор с 2 параметрами;
свойства доступа к внутренним полям класса;
метод, выводящий значения внутренних полей класса.
*/

using Сoordinates;

Random random = new Random();
Point<int> pointInt = new Point<int>(random.Next(100), random.Next(100));
Point<double> pointFloat = new Point<double>(random.NextDouble(), random.NextDouble());

Console.WriteLine("Координаты точек:");

pointInt.PrintValues();
pointFloat.PrintValues();