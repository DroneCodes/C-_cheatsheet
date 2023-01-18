using System;

class Program {
  public static void Main (string[] args) {
    double fahrenheit;

        Console.Write("Enter temperature in Fahrenheit: ");
        fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * (5.0 / 9);

        Console.WriteLine("Temperature in Celsius: {0:F2}", celsius);
  }
}