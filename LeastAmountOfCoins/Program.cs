using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        
        decimal  coins50 = 0;
        int  coins20 = 0;
        int  coins10 = 0;
        int  coins5 = 0;
        int  coins2 = 0;
        int  coins1 = 0;
        decimal  price = Convert.ToDecimal(Console.ReadLine());
        decimal  paid = Convert.ToDecimal(Console.ReadLine());
        
        decimal  change = paid - price;
        int leva = Convert.ToInt32(Math.Floor(change));

        Console.WriteLine($"Change normal: {change}");
        Console.WriteLine($"change modulo: {change % 1}");

        change = (change % 1); //0.51

        

        if (change > 0)
        {
            coins50 = change / 0.5m;
            Console.WriteLine($"50 stotinki: {coins50}");

            if ((coins50 % 1) > 0 && (coins50 % 1) >= 0.2m)
            {
                coins20 = (int)((coins50 % 1) / 0.2m);
            } else if ((coins50 % 1) > 0 && (coins50 % 1) < 0.2m && (coins50 % 1) >= 0.1m)
            {
                coins10 = (int)((coins50 % 1) / 0.1m);
            } else if ((coins50 % 1) > 0 && (coins50 % 1) < 0.2m && (coins50 % 1) < 0.1m && (coins50 % 1) >= 0.05m)
            {
                coins5 = (int)((coins50 % 1) / 0.05m);
            } else if ((coins50 % 1) > 0 && (coins50 % 1) < 0.2m && (coins50 % 1) < 0.1m && (coins50 % 1) < 0.05m && (coins50 % 1) >= 0.02m)
            {
                coins2 = (int)((coins50 % 1) / 0.02m);
            } else if ((coins50 % 1) > 0 && (coins50 % 1) < 0.2m && (coins50 % 1) < 0.1m && (coins50 % 1) < 0.05m && (coins50 % 1) < 0.02m && (coins50 % 1) >= 0.01m)
            {
                coins1 = (int)((coins50 % 1) / 0.01m);
            } 


        }
        Console.WriteLine($"Change is: {change}");
        Console.WriteLine($"Coins in leva: {leva}");
        Console.WriteLine($"Coins in .50 is: {coins50:F0}");
        Console.WriteLine($"Coins in .20 is: {coins20:F0}");
        Console.WriteLine($"Coins in .10 is: {coins10:F0}");
        Console.WriteLine($"Coins in .5 is: {coins5:F0}");
        Console.WriteLine($"Coins in .2 is: {coins2:F0}");
        Console.WriteLine($"Coins in .1 is: {coins1:F0}");




        //if (change > 0)
        //{
        //    coins50 = change / 0.5;
        //}

        // Console.WriteLine($"Change: {change}");





        //Console.WriteLine($"50 st: {coins50} change {change}");



    }
}





/*
double coins50 = coins / 0.5;
double coins20 = coins / 0.2;
double coins10 = coins / 0.1;
double coins5 = coins / 0.05;
double coins2 = coins / 0.02;
double coins1 = coins / 0.01;
*/

//int coins50 = (int)(change / 0.50);


/*
Console.WriteLine($"Change is: {change}");
Console.WriteLine($"Coins in leva: {leva}");
Console.WriteLine($"Coins in .50 is: {coins50:F0}");
Console.WriteLine($"Coins in .20 is: {coins20:F0}");
Console.WriteLine($"Coins in .10 is: {coins10:F0}");
Console.WriteLine($"Coins in .5 is: {coins5:F0}");
Console.WriteLine($"Coins in .2 is: {coins2:F0}");
Console.WriteLine($"Coins in .1 is: {coins1:F0}");

 */





//  price 4.49
//  paid 7
//  change is = 2.51
//
//  result:
//  1, 1, 50, 0.01
