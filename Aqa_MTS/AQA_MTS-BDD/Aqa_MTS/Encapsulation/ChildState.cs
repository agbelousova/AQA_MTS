namespace Encapsulation;

public class ChildState : State
{
    void Print()
    {
        protectedVar = "protected";   //переменная из класса State
    }
}