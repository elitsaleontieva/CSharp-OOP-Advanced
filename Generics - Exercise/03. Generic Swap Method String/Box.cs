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

  
    public void Swap(List<Box<string>> list, int indexA, int indexB)
    {

        Box<string> tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
    }



    public override string ToString()
    {
        return $"{this.Field.GetType().FullName.ToString()}: {this.Field}";
    }
}

