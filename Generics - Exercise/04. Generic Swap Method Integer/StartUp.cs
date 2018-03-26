using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var list = new List<Box<int>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            
            Box<int> boxObj = new Box<int>(int.Parse(input));

            list.Add(boxObj);
            
        }

        var swapCommand = Console.ReadLine().Split(' ').ToArray();
        var firstIndex = int.Parse(swapCommand[0]);
        var secondIndex = int.Parse(swapCommand[1]);

        Box<int> box = new Box<int>();
        box.Swap(list, firstIndex, secondIndex);

        foreach (var boxItem in list)
        {
            Console.WriteLine($"{boxItem.ToString()}");
        }

    }
}

