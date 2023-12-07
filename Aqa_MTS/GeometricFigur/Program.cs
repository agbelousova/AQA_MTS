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

/*
Задание 1:
Создать класс для подсчета площади треугольников
     реализовать классы для равнобедренного, равностороннего, 
прямоугольного и разностороннего треугольника
     для каждого использовать свою формулу для подсчета площади
     площадь разностороннего треугольника считаем по формуле герона
Создать отдельный класс который будет отвечать за логину создания 
треугольников. В нем вернуть нужный объект треугольника проверив его стороны
     добавить класс квадрат и прямоугольник и логику подсчета площади для него
     добавить класс для реализации иерархии фигур
     создавь массив квадратов, прямоугольник и треугольников и вывести их площади
*/

using GeometricFigures;

//TriangleCreate triangle = new TriangleCreate();
//int i = triangle.FormTriangling(100,50,10);
//triangle.FormTriangling();
//Console.WriteLine($"Здравствуйте, {i}!");
GeometricFigures[] triangle = new[] { };

GeometricFigures[] triangle = new GeometricFigures[]
{
 10,20,30
};
//triangle1.TriangleArea(11,15,10);


Transport[] transports = new Transport[]
{
 new TransportVid.TransportTrolleybus(10, "Иваново", 15, new DateTime(2023, 7, 1)),
 new TransportVid.TransportBus(15, "Москва", 20, DateTime.Now),
 new TransportVid.TransportTram(10, "Иваново", 15, new DateTime(2023, 5, 1)),
 new TransportVid.TransportBus(15, "Москва"),
 new TransportVid.TransportBus(55, "Новгород", 55, DateTime.Now),
 new TransportVid.TransportTrolleybus(1, "Москва", 35, new DateTime(2023, 8, 11))
};
//triangle1.TriangleArea();
/*string FormTriangling() 
{
 if (LengthA <= 0 || LengthB <= 0 || LengthC <= 0 || 
     LengthA + LengthB <= LengthC || LengthA + LengthC <= LengthB || 
     LengthC + LengthB <= LengthA) 
 {
  Console.WriteLine("Треугольника с такими сторонами не существует!!!");
  return "нет";
 }
 if (LengthA == LengthB && LengthA == LengthC && LengthB == LengthC) 
 {
  Console.WriteLine("Треугольник равносторонний!");
  return "равносторонний";
 }
 if (((LengthA * LengthA) == (LengthB * LengthB) + (LengthC * LengthC)) ||
     ((LengthB * LengthB) == ((LengthA * LengthA) + (LengthC * LengthC)) || 
      ((LengthC * LengthC) == (LengthB * LengthB) + (LengthA * LengthA)))) 
 {
  Console.WriteLine("Треугольник прямоугольный!");
  return "прямоугольный";
 }
 if ((LengthA == LengthB && LengthA != LengthC) || 
     (LengthB == LengthC && LengthB != LengthA) || 
     (LengthA == LengthC && LengthA != LengthB)) 
 {
  Console.WriteLine("Треугольник равнобедренный!");
  return "равнобедренный";
 }
 Console.WriteLine("Треугольник разносторонний!");
 return "разносторонний";
}*/


