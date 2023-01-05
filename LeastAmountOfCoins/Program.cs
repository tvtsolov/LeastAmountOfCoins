using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {

        int coins50 = 0;
        int coins20 = 0;
        int coins10 = 0;
        int coins5 = 0;
        int coins2 = 0;
        int coins1 = 0;
        decimal price = Convert.ToDecimal(Console.ReadLine());
        decimal paid = Convert.ToDecimal(Console.ReadLine());

        decimal change = paid - price;
        int leva = Convert.ToInt32(Math.Floor(change));

        change = (change % 1);

        if (change > 0)
        {
            coins50 = (int)((change % 1) / 0.5m);
            decimal remainder = (change % 0.5m);

            if ((remainder % 1) > 0 && (remainder % 1) >= 0.2m)
            {
                coins20 = (int)((remainder % 1) / 0.2m);
                remainder = (remainder - coins20 * 0.2m);
            }
            if (remainder != 0 && remainder < 0.2m && remainder >= 0.1m)
            {
                coins10 = (int)((remainder % 1) / 0.1m);
                remainder = (remainder - coins10 * 0.1m);
            }
            if (remainder != 0 && remainder < 0.2m && remainder < 0.1m && remainder % 1 >= 0.05m)
            {
                coins5 = (int)((remainder % 1) / 0.05m);
                remainder = (remainder - coins5 * 0.05m);
            }
            if (remainder != 0 && remainder < 0.2m && remainder < 0.1m && remainder < 0.05m && remainder >= 0.02m)
            {
                coins2 = (int)((remainder % 1) / 0.02m);
                remainder = (remainder - coins2 * 0.02m);
            }
            if (remainder != 0 && remainder < 0.2m && remainder % 1 < 0.1m && remainder % 1 < 0.05m && remainder < 0.02m && remainder % 1 >= 0.01m)
            {
                coins1 = (int)((remainder % 1) / 0.01m);
            }
        }

        //Output
     
        if (leva >= 1)
        {
            Console.WriteLine($"{leva:F0} x 1 lev");
        }
        if (coins50 >= 1)
        {
            Console.WriteLine($"{coins50:F0} x 50 stotinki");
        }
        if (coins20 >= 1)
        {
            Console.WriteLine($"{coins20:F0} x 20 stotinki");
        }
        if (coins10 >= 1)
        {
            Console.WriteLine($"{coins10:F0} x 10 stotinki");
        }
        if (coins5 >= 1)
        {
            Console.WriteLine($"{coins5:F0} x 5 stotinki");
        }
        if (coins2 >= 1)
        {
            Console.WriteLine($"{coins2:F0} x 2 stotinki");
        }
        if (coins1 >= 1)
        {
            Console.WriteLine($"{coins1:F0} x 1 stotinka");
        }
    }
} 

// notes notes
//

