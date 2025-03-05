using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string input = Console.ReadLine();

         
        while (input != "end")
        {
            string[] cmdArg = input.Split(' ');
            string command = cmdArg[0];

            if (command == "Delete")
            {
                int elementToRemove = int.Parse(cmdArg[1]);
                 
                numbers.RemoveAll(x => x == elementToRemove);
            }
            else if (command == "Insert")
            {
                int element = int.Parse(cmdArg[1]);
                int position = int.Parse(cmdArg[2]);
                 
                numbers.Insert(position, element);
            }

            
            input = Console.ReadLine();
        }

         
        Console.WriteLine(string.Join(" ", numbers));
    }
}