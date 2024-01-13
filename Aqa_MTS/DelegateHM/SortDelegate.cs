namespace DelegateHM;

public class SortDelegate
{
    delegate int[] Sorting(int[] result);

    public void Run()
    {
        SortingType[] sortingTypes = (SortingType[])Enum.GetValues(typeof(SortingType));
        int[] array = {5,3,4,9,7,2,1,8,6 };
        Console.WriteLine($"Начальный массив:");
        foreach (int item in array) Console.Write($" {item}");
        Console.WriteLine();
        Sorting sorting;
        Console.WriteLine($"Отсортированный массив:");
        
        foreach (SortingType type in sortingTypes)
        {
            sorting = SelectSorting(type);
            Console.WriteLine($"{type} ");
            foreach (int e in sorting(array))
                Console.Write($" {e}");
            Console.WriteLine();
        }
    }
    
    private Sorting SelectSorting (SortingType sortingType)
    {
        switch (sortingType)
        {
            case SortingType.BubbleSorting: 
                return BubbleSorting;
            default: return SelectionMethodSort;
        }
    }

    private int[] SelectionMethodSort(int[] result)
    {
        int tmp, min_key;
        for (int j = 0; j < result.Length - 1; j++)
        {
            min_key = j;
 
            for (int k = j + 1; k < result.Length; k++)
            {
                if (result[k] < result[min_key])
                {
                    min_key = k;
                }
            }
            tmp = result[min_key];
            result[min_key] = result[j];
            result[j] = tmp;
        }
        return result;
    }
    
    private int[] BubbleSorting(int[] result)
    {
       for (int i = 0; i < result.Length; i++)
            for (int j = 0; j < result.Length - 1; j++)
                if (result[j] > result[j + 1])
                {
                    int t = result[j + 1];
                    result[j + 1] = result[j];
                    result[j] = t;
                }
       return result;
    }
}