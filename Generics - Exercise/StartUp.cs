using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var list = new List<Box<string>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            
            Box<string> boxObj = new Box<string>(input);

            list.Add(boxObj);
            
        }

        var swapCommand = Console.ReadLine().Split(' ').ToArray();
        var firstIndex = int.Parse(swapCommand[0]);
        var secondIndex = int.Parse(swapCommand[1]);

        Box<string> box = new Box<string>();
        box.Swap(list, firstIndex, secondIndex);

        foreach (var boxItem in list)
        {
            Console.WriteLine($"{boxItem.ToString()}");
        }

    }
}
