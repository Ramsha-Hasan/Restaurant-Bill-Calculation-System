using System;
using System.Collections.Generic;
using System.IO;
class Program {
    static void Main(String[] args) 
    {
        double mealCost = Convert.ToDouble(Console.ReadLine());
        int tipPercent = Convert.ToInt32(Console.ReadLine());
        int taxPercent = Convert.ToInt32(Console.ReadLine());
        
        double tip = mealCost * tipPercent / 100;
        double tax = mealCost * taxPercent / 100;
        
        double totalCost = mealCost + tip + tax;
        
        double totalRoundCost = Math.Round(totalCost,0);
        Console.WriteLine("The total meal cost is {0} dollars.",totalRoundCost);
    }
}
