// See https://aka.ms/new-console-template for more information
/*
 Задание 1:
Создать класс для подсчета площади треугольников
- реализовать классы для равнобедренного, равностороннего,
прямоугольного и разностороннего треугольника
- для каждого использовать свою формулу для подсчета площади
- площадь разностороннего треугольника считаем по формуле герона
- Создать отдельный класс который будет отвечать за логику создания
треугольников. В нем вернуть нужный объект треугольника проверив его
стороны
- добавить класс квадрат и прямоугольник и логику подсчета площади для него
- добавить класс для реализации иерархии фигур
- создавь массив квадратов, прямоугольник и треугольников и вывести их площади
*/

using GeometricFigure;

GeometricFigures[] figures =
{
 TriangleCreate.CreateTriangle(3,4,5),
 TriangleCreate.CreateTriangle(20,25,10),
 TriangleCreate.CreateTriangle(5,12,13),
 TriangleCreate.CreateTriangle(1,1,3),
 TriangleCreate.CreateTriangle(3,3,3),
 TriangleCreate.CreateTriangle(6,4,4),
 TriangleCreate.CreateTriangle(15,8,15),
 new Rectangle(4,6),
 new Square(12),
 new Rectangle(14,7),
 new Square(3f)
};

foreach (var figure in figures)
 figure.PrintInfo();

