using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDClassTestQ2_1718
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            decimal[,] prices = {   { 0.99m, 1.29m, 1.49m },
                                    { 1.49m, 1.99m, 2.29m },
                                    { 2.49m, 3.19m, 3.89m },
                                    { 3.99m, 4.99m, 5.99m },
                                    { 8.99m, 9.99m, 11.99m } };

            decimal[] weights = { 0.1m, 0.2m, 0.8m, 2.0m, 5.0m };
            decimal weight;
            string size;

            Console.WriteLine("Please enter the weight of the package");
            weight = Convert.ToDecimal(Console.ReadLine());


            // Start of your code
            bool oversize = false;
            int weightIndex = 0;
            int sizeIndex = 0;

            oversize = weight > 5 ? true : false;
            if (!oversize)
            {
                Console.WriteLine("Please enter the size of the package (S - Small, M - Medium, L - Large)");
                size = Console.ReadLine().ToUpper();
                for (int i = 0; i < weights.Length; i++)
                {
                    if (weight <= weights[i])
                    {
                        weightIndex = i;
                        break;
                    }
                }
                switch (size)
                {
                    case "S":
                        sizeIndex = 0;
                        break;
                    case "M":
                        sizeIndex = 1;
                        break;
                    case "L":
                        sizeIndex = 2;
                        break;
                    default:
                        Console.WriteLine("Incorrect size, press Enter to start again");
                        Console.ReadLine();
                        Console.Clear();
                        goto start;
                }
            }


            if (oversize)
            {
                Console.WriteLine("This package is too large for regular delivery.");
            }
            else
            {
                Console.WriteLine("The cost of delivery is {0:C}", prices[weightIndex, sizeIndex]);
            }
            //End of your code


            Console.WriteLine("Press Enter to start again"); 
            Console.ReadLine();
            Console.Clear();
            goto start;
        }
    }
}
