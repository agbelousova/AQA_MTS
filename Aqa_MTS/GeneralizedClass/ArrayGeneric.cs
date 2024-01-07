namespace GeneralizedClass;

internal class ArrayGeneric<T>
{
    public ArrayGeneric(int length)
    {
        Length = length;
        ArrayValues = new T[length];
    }

    public int Length { get; set; }
    public T[] ArrayValues { get; set; }

    public void Add(T value)
    {
        Length++;
        var tmp = new List<T>(ArrayValues);
        tmp.Add(value);
        ArrayValues = tmp.ToArray();
    }

    public void Remove(T value)
    {
        //если значение переданное для удаления есть в массиве, то создаем новый массив со значениями существующего,
        //затем удаляем все совадения переданного значение из массива
        //присваиваем новые значения для свойств длины и данным массива
        if (Array.IndexOf(ArrayValues, value) > -1)
        {
            var tmp = new List<T>(ArrayValues);
            tmp.RemoveAll(element => element.Equals(value));
            Length = tmp.Count;
            ArrayValues = tmp.ToArray();
        }
    }

    public T GetByIndex(int index)
    {
        return ArrayValues[index];
    }

    public int GetLenth()
    {
        return Length;
    }
}