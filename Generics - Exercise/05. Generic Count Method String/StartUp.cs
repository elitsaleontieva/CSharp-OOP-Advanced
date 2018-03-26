using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var listString = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            listString.Add(input);
        }

        var stringToCompare = Console.ReadLine();

        Box<string> boxObjToCompare = new Box<string>();
        Console.WriteLine(boxObjToCompare.Compare(listString, stringToCompare));


    }

    
}
