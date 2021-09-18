using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Degrees in Celcius");

    var x = Console.ReadLine();

    int num1 = Convert.ToInt32(x);

    double num2 = 1.8;

    int num3 = 32;

    Console.Write("Farenheit is equivilent for ");
    Console.Write(x);
    Console.Write(" Celsius is ");
    Console.WriteLine((num1*num2)+num3);
    
    double num4 = ((num1*num2)+num3);
    Console.WriteLine(num4);

     if (num4 > 212)
     {
      Console.WriteLine("The temperature is above boiling temperature of 212 degrees farenheit");
     }

     if (num4 < 32)
     {
      Console.WriteLine("The temperature is below freezing temperature of 32 degrees farenheit");
     }
  }
}