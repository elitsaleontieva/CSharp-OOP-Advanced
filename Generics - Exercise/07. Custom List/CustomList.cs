using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class CustomList<T>
{

    public List<T> cList { get; set; }

    public CustomList()
    {
        cList = new List<T>();
    }


    public void AddElement(T element)
    {

        cList.Add(element);
    }

    public T RemoveElement(int index)
    {
        cList.RemoveAt(index);
        return cList[index];
    }

    public bool ContainsElement(T element)
    {
        return this.cList.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        T tmp = this.cList[index1];
        this.cList[index1] = this.cList[index2];
        this.cList[index2] = tmp;
    }

    public int Compare<T>(List<T> list, T element)
          where T : IComparable<T>
    {
        int counter = 0;
        foreach (var generic in list)
        {
            if (generic.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }
    public T Max()
    {
        return this.cList.Max();
    }

    public T Min()
    {
        return this.cList.Min();
    }

    public int CountGreaterThan<T>(List<T> list, T element)
         where T : IComparable<T>
    {
        int counter = 0;
        foreach (var generic in list)
        {
            if (generic.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, this.cList);
    }


}
