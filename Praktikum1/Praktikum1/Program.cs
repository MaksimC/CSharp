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
            
            //Console.WriteLine("Your insterted number is: " + insertInt());
            //Console.WriteLine("Inserted temperature in Kelvins is: " + FarToKel() + " Kelvins");
            //Console.WriteLine("Inserted temperature in Fahrenheits is: " + celsiusToFahrenit() + " Fahrenheits");
            //Console.WriteLine(adult());
            Console.WriteLine(triangle());
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

        public static double FarToKel()
        {
            double KelTemp = 0;
            double FarTemp = 0;

            Console.WriteLine("Insert temperature in Farenheit: ");
            FarTemp = System.Convert.ToDouble(Console.ReadLine());
            KelTemp = (FarTemp + 459.57) * 5/9;

            return KelTemp;
        }

        public static double celsiusToFahrenit()
        {
            double farTemp = 0;
            double celTemp = 0;

            Console.WriteLine("Insert temperature in Celsius degrees: ");
            celTemp = System.Convert.ToDouble(Console.ReadLine());
            farTemp = (celTemp*9/5) + 32;

            return farTemp;
        }

        public static string adult()
        {

            int age = 0;
            string maturness;
            Console.WriteLine("Please insert your age: ");
            age = System.Convert.ToInt16(Console.ReadLine());
            if (age >= 18){
                maturness = "You are adult person, go and get job!!";
            }
            else
            {
                maturness = "You are too young, go to school, it semptember already!";
            }
            return maturness;
        }

        public static string triangle()
        {
            string isTriangle;
            int temp = 0;
            int[] triangle = new int[3];
            
        
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insert size of side " + (i+1));
                temp = System.Convert.ToInt32(Console.ReadLine());
                triangle[i] = temp;
            }
            Array.Sort(triangle);

            if ((triangle[0] + triangle[1]) > triangle[2]) {
                isTriangle = "Congratulations! This is a triangle!";
            } else {
                isTriangle = "Damn! That cannot be a triangle. At least not in this universe geometry...";
            }

            return isTriangle;
        }

    }
}
