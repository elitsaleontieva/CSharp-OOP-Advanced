using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Box<T> : IBox<T>
{

    private List <T> data;
      
    public Box()
    {
        this.data = new List<T>();
    }

    public T this[int index]
    {
          get
          {
            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return this.data[index];
            }
    }

    public int Count => this.data.Count;




    public void Add(T element)
    {
        this.data.Add(element);

        //  this.data.ToArray();



    }

    public T Remove()
    {
        var last = this.data.Last();
        this.data.RemoveAt(this.data.Count-1);

        return last;
    }
}

