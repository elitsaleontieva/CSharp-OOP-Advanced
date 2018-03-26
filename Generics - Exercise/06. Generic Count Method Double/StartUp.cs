using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var listDouble = new List<double>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            listDouble.Add(double.Parse(input));
        }

        var doubleToCompare = double.Parse(Console.ReadLine());

        Box<double> boxObjToCompare = new Box<double>();
        Console.WriteLine(boxObjToCompare.Compare(listDouble, doubleToCompare));


    }

    
}
