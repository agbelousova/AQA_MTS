// See https://aka.ms/new-console-template for more information
/*
 * Задание 1:
 /*
Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать метод подсчета площади и периметра для каждого типа фигуры.
Создать массив из 5 фигур.
Вывести на экран сумму периметра и площади всех фигур в массиве.
*/

using GeometricFigures;

GeometricFigure[] geometricFigure = 
{
 new Rectangle(10.5, 15),
 new Triangle(5, 7.5, 6.5),
 new Triangle(15, 17.5, 16.5),
 new Circle(10.5),
 new Circle(15.0)
};

double sumP = 0;
double sumS = 0;

foreach (GeometricFigure figure in geometricFigure)
{
 sumP = sumP + figure.GetPerimetr();
 sumS = sumS + figure.GetArea();
}

Console.WriteLine($"Сумма периметра всех фигур = {sumP}");
Console.WriteLine($"Сумма площадей всех фигур = {sumS}");