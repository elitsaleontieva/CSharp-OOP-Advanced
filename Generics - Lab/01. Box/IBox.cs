using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public interface IBox<T>
{
    int Count { get; }

    T this[int index] { get; }

    void Add(T element);

    T Remove();
}
