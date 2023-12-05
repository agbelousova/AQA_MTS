using Encapsulation;

namespace Abstraction;

public class ChildState : State
{
    void Test()
    {
        base.PrintProtectedInternal();  //метод из проекта Encapsulation из класса State
    }
    
}