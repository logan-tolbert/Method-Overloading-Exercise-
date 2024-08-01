using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // variable declaration and initialization
            int num1 = 8;
            int num2 = 8;
            decimal decNum1 = 3.14m;
            decimal decNum2 = 5.3434m;
            int sum = Add(num1, num2);
            decimal decSum = Add(decNum1, decNum2);
            bool enableMessage = true;
            
            // messages
            string message = $"{num1} + {num2} = {sum}\n";
            string message2 = $"{decNum1} + {decNum2} = {decSum}\n";
            string message3 = Add(num1 = 1, num2 = 0, enableMessage);
            string message4 = Add(num1 = 6, num2 = 8, enableMessage);
            string message5 = Add(num1, num2, enableMessage = false);

            // ouput
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            Console.WriteLine(message5);
           
            
        }

        // method definitions
        public static int Add(int x, int y)
        {
            return x + y;
        }
            
        
        public static decimal Add(decimal x, decimal y) 
        { 
            return (decimal)x + y;
        }


        public static string Add(int x, int y, bool enableMessage)
        {
            int sum = x + y;
            string message1 = $"{sum} dollar\n";
            string message2 = $"{sum} dollars\n";
            string message3 = $"Message output disabled.\n";

            if (enableMessage == false)
            {
                return message3;
            }

            do
            {
                if (sum == 1)
                {
                    return message1;
                }
                else
                {
                    return message2;
                }

            } while (enableMessage);
           
        }
    }    
}
