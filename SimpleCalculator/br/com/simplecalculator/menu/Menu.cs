using SimpleCalculator.br.com.simplecalculator.operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.br.com.simplecalculator.menu
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            Sum sum = new Sum();
            Subtraction sub = new Subtraction();
            Multiplication multi = new Multiplication();
            Division divi = new Division();
            int op;
            Console.WriteLine("Hello");
            Console.WriteLine("This program is a simple calculator, that can operate with two numbers");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            do
            {
                Console.WriteLine("Type the option you want to operate");
                Console.WriteLine("======================================");
                Console.WriteLine("= 1) Sum                             =");
                Console.WriteLine("= 2) Subtraction                     =");
                Console.WriteLine("= 3) Multiplication                  =");
                Console.WriteLine("= 4) Division                        =");
                Console.WriteLine("= 0) Exit                            =");
                Console.WriteLine("======================================");

                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        sum.SumMenu();
                        sum.WriteResult();
                        Environment.Exit(0);
                        break;
                    case 2:
                        sub.SubtractionMenu();
                        sub.WriteResult();
                        Environment.Exit(0);
                        break;
                    case 3:
                        multi.MultiplicationMenu();
                        multi.WriteResult();
                        Environment.Exit(0);
                        break;
                    case 4:
                        divi.DivisionMenu();
                        divi.WriteResult();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Option not available, try again");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (op > 0);
        }

    }
}
