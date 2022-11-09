using System;
using System.Text.RegularExpressions;
 namespace exercises
{
    class exercises
    {


        static void Main(string[] args)
        {
            string user = "";
            Console.WriteLine("Please pick a book");
            user = Console.ReadLine();
            switch (user)
            {
                case "c":
                case "C":
                    Console.WriteLine("C# books");
                    break;
                case "o":
                case "O":
                    Console.WriteLine(".NET core books");
                    break;
                case "d":
                case "D":
                    Console.WriteLine("clean coding books");
                    break;
                case "e":
                case "E":
                    Console.WriteLine(".EFCore");
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }


        }
}
}



