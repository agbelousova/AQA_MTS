namespace Сoordinates;
internal class Point<T>
{
    private T _x;
    private T _y;

    public T X
    {
        get { return _x; }
    }

    public T Y
    {
        get { return _y; }
    }

    public Point(T x, T y)
    {
        _x = x;
        _y = y;
    }

    public void PrintValues()
    {
        Console.WriteLine($"X: {_x}, Y: {_y}");
    }
}