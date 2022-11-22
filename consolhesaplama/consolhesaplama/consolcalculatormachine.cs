using System;

namespace Calculator
{
    class Calculator01
    {
        static void Main(string[] args)
        {
            do
            {
                double start_value = 0;
                double second_value = 0;
                double result = 0;

                Console.WriteLine("---------------------");
                Console.WriteLine("--Simple Calculator--");
                Console.WriteLine("---------------------");
                Console.Write("Enter the First Number");
                start_value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");
                second_value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an Option");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = start_value + second_value;
                        Console.WriteLine($"Your Result:{start_value}+{second_value}=" + result);
                        break;

                    case "-":
                        result = start_value - second_value;
                        Console.WriteLine($"Your Result:{start_value}-{second_value}=" + result);
                        break;

                    case "*":
                        result = start_value * second_value;
                        Console.WriteLine($"Your Result:{start_value}*{second_value}=" + result);
                        break;
                    case "/":
                        result = start_value / second_value;
                        Console.WriteLine($"Your Result:{start_value}/{second_value}=" + result);
                        break;
                }
                Console.WriteLine("Do you want calculate more? Y=Yes N=No");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("See you later again");
            Console.ReadKey();
        }
    }
}
