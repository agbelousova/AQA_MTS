/*
 Задание 3:
Коллекция содержит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5". Избавиться от повторяющихся элементов в строке и вывести результат на экран.
 */

using System.Collections;
using Number;

LinkedList<int> numberList = new LinkedList<int>();
numberList.AddLast(1);
numberList.AddLast(2);
numberList.AddLast(3);
numberList.AddLast(4);
numberList.AddLast(4);
numberList.AddLast(5);

Console.WriteLine("Начальная строка:");
Helper.PrintCollection(numberList);

LinkedListNode<int> currentNode = numberList.First;

while (currentNode.Next != null)
{
    if (currentNode.Value != currentNode.Next.Value) currentNode = currentNode.Next;
    else numberList.Remove(currentNode.Value);
}

Console.WriteLine("Строка после удаления повторений:");
Helper.PrintCollection(numberList);