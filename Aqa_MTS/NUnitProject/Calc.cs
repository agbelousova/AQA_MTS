namespace NUnitProject;

public static class Calc
{
    public static int Sum(int x, int y) => x + y;

    public static int DivInt(int x, int y) => x / y;

    public static double DivDouble(double x, double y) => Math.Round(x / y, 2);
}