using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = insertInt();
            Console.WriteLine("Your insterted number is: " + a);

        }

        public static int insertInt()
        {
            int a = 0;
            bool status = false;
            while (status == false)
                {
                Console.WriteLine("Please insert a number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out a))
                {
                    status = true;
                }  
            }
            return a;
        }


    }
}
