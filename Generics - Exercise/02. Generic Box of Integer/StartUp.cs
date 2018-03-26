using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Box<int> box = new Box<int>(int.Parse(input));
                Console.WriteLine(box.ToString());
            }
            else
            {
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }


        }
    }
}
