using System;
using System.Collections.Generic;
using System.Text;


public class Box<T> 
{
    public T Field { get; set; }

    public Box()
    {
    }

    public Box(T field)
    {
        this.Field = field;
    }

    public override string ToString()
    {
        return $"{this.Field.GetType().FullName.ToString()}: {this.Field}";
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
}

