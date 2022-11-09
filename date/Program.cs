using System;

  Console.WriteLine("Enter Date in format dd/MMM/yy");
    string userDate = Console.ReadLine();
    dateFunction(userDate);
    static void dateFunction(string userDate)
    {
      DateTime UserDate = DateTime.Parse(userDate);
      DateTime solution =UserDate.AddDays(7);
      Console.WriteLine($"{solution.ToString("dd/MMM/yy")}");
    }

