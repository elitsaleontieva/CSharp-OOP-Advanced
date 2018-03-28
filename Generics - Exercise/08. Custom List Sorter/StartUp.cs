using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        CustomList<string> customList = new CustomList<string>();

        var command = Console.ReadLine().Split(' ').ToArray();

        var commandParts = command[0];
        string element;

        while (command[0] != "END")
        {

            switch (command[0])
            {
                case "Add":
                    element = command[1];
                    customList.AddElement(element);
                    break;

                case "Remove":
                    var index = int.Parse(command[1]);
                    customList.RemoveElement(index);
                    break;


                case "Contains":
                    element = command[1];
                    Console.WriteLine(customList.ContainsElement(element));
                    break;

                case "Swap":
                    var index1 = int.Parse(command[1]);
                    var index2 = int.Parse(command[2]);
                    customList.Swap(index1, index2);
                    break;

                case "Greater":
                    element = command[1];
                    Console.WriteLine(customList.CountGreaterThan(customList.cList, element));
                    break;

                case "Max":
                    Console.WriteLine(customList.Max());
                    break;

                case "Min":
                    Console.WriteLine(customList.Min());
                    break;

                case "Print":
                    Console.WriteLine(customList.ToString());
                    break;

                case "Sort":
                    customList.SortElements();

                    break;
            }

            command = Console.ReadLine().Split(' ').ToArray();

        }

    }
}

