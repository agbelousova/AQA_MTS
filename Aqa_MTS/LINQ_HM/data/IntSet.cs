using System.Collections;

namespace LINQ_HM.data;

public class IntSet : IEnumerable<int>
{
    private IEnumerable<int> _enumerableImplementation =  new List<int>(){0, 1, 2, 3, 3, 4, 5, 6, 7, 8, 8, 9};
    public IEnumerator<int> GetEnumerator()
    {
        
        return _enumerableImplementation.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}