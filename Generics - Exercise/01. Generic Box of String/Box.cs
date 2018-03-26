using System;
using System.Collections.Generic;
using System.Text;


public class Box<T>
{
    public T Field { get; set; }

    public Box(T field)
    {
        this.Field = field;
    }

    public override string ToString()
    {
        return $"{this.Field.GetType().FullName.ToString()}: {this.Field}";
    }
}

