using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Size\t\tSeat Capacity\tCost (PHP)");
      Console.WriteLine("Small (S)\t5\t\t\t\t5000");
      Console.WriteLine("Medium (M)\t10\t\t\t\t8000");
      Console.WriteLine("Large (L)\t15\t\t\t\t12000");
      
      Console.WriteLine("Please input number (seat):");
      string input = Console.ReadLine();
      
      if (int.TryParse(input, out int seats))
      {
        if (seats <= 5)
        {
          Console.WriteLine("Small (S)");
          Console.WriteLine("Cost: 5000 PHP");
        }
        else if (seats <= 10)
        {
          Console.WriteLine("M x");
          Console.WriteLine("Cost: 8000 PHP");
        }
        else if (seats <= 15)
        {
          Console.WriteLine("Large (L)");
          Console.WriteLine("Cost: 12000 PHP");
        }
        else
        {
          int mediumCount = (seats + 10) / 10; 
          Console.WriteLine($"M x {mediumCount}");
          Console.WriteLine($"Total Cost: {mediumCount * 8000} PHP");
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid number.");
      }
    }
  }
}
