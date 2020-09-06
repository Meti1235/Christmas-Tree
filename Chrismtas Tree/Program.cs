using System;

namespace Chrismtas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a tree size:");
            int treeSize = Convert.ToInt32(Console.ReadLine());

            if (treeSize <= 81)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string treeDecoration = " @ ".PadLeft(treeSize + 4);
                Console.WriteLine(treeDecoration);
                Console.ForegroundColor = ConsoleColor.Green;
                string treeTop = " / \\ ".PadLeft(treeSize + 5);
                Console.WriteLine(treeTop);
                for (int i = 0; i < treeSize; i++)
                {


                    for (int j = 0; j < treeSize - i; j++)
                    {

                        Console.Write(" ");

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("/ ");
                    for (int j = 0; j < 1 + i; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("* ");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\\");
                }
                double trunkSize = Convert.ToDouble(treeSize + 2) / 3;
                for (int i = 0; i <= trunkSize; i++)
                {
                    for (int j = 0; j < trunkSize * 2; j++)
                    {
                        Console.Write(" ");


                    }
                    for (int j = 0; j < trunkSize; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The number you entered exceeds the maximum treeSize which is 81");
            }

            Console.ReadLine();

        }
    
    }
}
