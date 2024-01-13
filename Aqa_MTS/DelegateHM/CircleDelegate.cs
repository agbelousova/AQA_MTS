namespace DelegateHM;

public class CircleDelegate
{
    public delegate double CircleCalc(double radius);

    public void Run()
    {
        CircleCalc areaCircle = new CalculateCircle().AreaCircle ;
        CircleCalc lengthCircle = new CalculateCircle().LengthCircle;
        CircleCalc volumeBall = new CalculateCircle().VolumeBall;
   
        Console.WriteLine($"Длина круга: {lengthCircle(5.5)}");
        Console.WriteLine($"Площадь круга: {areaCircle(5.5)}");
        Console.WriteLine($"Объем шара: {volumeBall(5.5)}");
        
    }
}