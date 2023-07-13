using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditonal operator

            /*int num1, num2;
            Console.WriteLine("enter first number");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2=int.Parse(Console.ReadLine());
            var result = num1 > num2 ? "First number is greater" : "seconde number is greater";
            Console.WriteLine(result);
            Console.ReadKey();
*/

            //1st excersize
            int pre;
            int final;
            Console.WriteLine("Enter marks in the preexam:");
             pre= int.Parse(Console.ReadLine());

            if (pre> 60)
            {
                Console.WriteLine("Enter marks in the final exam:");
                final = int.Parse(Console.ReadLine());

                if (final > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
                Console.ReadKey();
            }
        }
    }
}
    