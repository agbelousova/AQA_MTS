namespace DelegateHM;

public class CalculateCircle
{
    //длина окружности
    public double LengthCircle(double r)
    {
        return 2 * Math.PI * r;
    }

    //площадь круга
    public double AreaCircle(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }
    
    //объем шара
    public double VolumeBall(double r)
    {
        //V = 4/3 · π · R3
        return 4 / 3 * Math.PI * Math.Pow(r, 3);
    }
}