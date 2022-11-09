using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            int ops;
            Console.WriteLine("enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("main menu");
            Console.WriteLine("1. addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine(" please select one of the above opreate 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division ");
            ops = int.Parse(Console.ReadLine());

            if (ops == 1)
            {
                result = Add(num1, num2);

            }
            else if
                (ops == 2)
            {
                result = subtract(num1, num2);
            }
            else if
                (ops == 3)
            {
                result = multiply(num1, num2);

            }
            else if
                (ops == 4)
            {
                result = divide(num1, num2);
            }
             else
            { 
                Console.WriteLine("please enter the number 1 to 4");
                 result = 0;
              } 
        
                Console.WriteLine("the result is :" + result);
                Console.ReadLine();
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int subtract(int n1, int n2)
        {
            return n1 - n2;

        }
        static int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static int divide(int n1, int n2)
        { 
          if (n2==0)
            {
                Console.WriteLine("please correct num1");
                return n1;
            }
             else           
                return n1 / n2;
            
        }
    }
}
