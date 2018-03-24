using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class ArrayCreator
{

    public static T[] Create<T>(int length, T item)
    {
        return new T[length];
       
    }
    
}

