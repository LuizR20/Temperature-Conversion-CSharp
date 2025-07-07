using System;

public class Temperature
{
  public static void Main (string[] args)
  {
    Console.WriteLine("=== Converting Temperatures ===");
    Console.WriteLine();
    
    Console.WriteLine("Welcome to the Temperature Converter! First, which temperature unit do you want to convert?");
    Console.WriteLine();
    
    Console.WriteLine("Celsius (C)");
    Console.WriteLine();
    
    Console.WriteLine("Fahrenheit (F)");
    Console.WriteLine();
    
    Console.WriteLine("Kelvin (K)");
    Console.WriteLine();
    string Unit;
    
    while (true)
    {
      Unit = Console.ReadLine().ToUpper();
      switch (Unit)
      {
        case "C":
        case "CELSIUS":
        Console.WriteLine();
        Console.WriteLine("Ok! Let's convert Celsius to other temperatures!");
        break;
        
        case "F":
        case "FAHRENHEIT":
        Console.WriteLine();
        Console.WriteLine("Alright! Let's check the conversion from Fahrenheit!");
        break;
        
        case "K":
        case "KELVIN":
        Console.WriteLine();
        Console.WriteLine("Ok, mr. 'Kelvin', let's see your conversion!");
        break;
        
        default:
        Console.WriteLine();
        Console.WriteLine("Sorry, but that's not a valid option... Try again.");
        continue;
      }
      break;
    }
    
    if (Unit == "C" || Unit == "CELSIUS")
    {
      Console.WriteLine();
      Console.WriteLine("Now, enter the temperature value...");
      double CT = Convert.ToDouble(Console.ReadLine());
      
      double FT = (CT * 9.0 / 5.0) + 32;
      double KT = CT + 273.15;
      Console.WriteLine();
      
      Console.WriteLine("Your temperature in Fahrenheit and Kelvin is:");
      Console.WriteLine();
      
      Console.WriteLine($"Fahrenheit: {FT} °F");
      Console.WriteLine();
      
      Console.WriteLine($"Kelvin: {KT} K");
    }
    
    else if (Unit == "F" || Unit == "FAHRENHEIT")
    {
      Console.WriteLine();
      Console.WriteLine("Now, enter the temperature value...");
      double FT = Convert.ToDouble(Console.ReadLine());
      
      double CT = (FT - 32) * 5.0 / 9.0;
      double KT = CT + 273.15;
      Console.WriteLine();
      
      Console.WriteLine("Your temperature in Celsius and Kelvin is:");
      Console.WriteLine();
      
      Console.WriteLine($"Celsius: {CT} °C");
      Console.WriteLine();
      
      Console.WriteLine($"Kelvin: {KT} K");
    }
    
    else if (Unit == "K" || Unit == "KELVIN")
    {
     Console.WriteLine();
      Console.WriteLine("Now, enter the temperature value...");
      double KT = Convert.ToDouble(Console.ReadLine());
      
      double CT = KT - 273.15;
      double FT = (KT - 273.15) * 9 / 5 + 32;
      Console.WriteLine();
      
      Console.WriteLine("Your temperature in Celsius and Fahrenheit is:");
      Console.WriteLine();
      
      Console.WriteLine($"Celsius: {CT} °C");
      Console.WriteLine();
      
      Console.WriteLine($"Fahrenheit: {FT} °F");
    }
  }
}