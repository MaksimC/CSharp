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
            selectFunction();
            
        }

        public static void selectFunction()
        {
            Console.WriteLine("Select what you would like to do: \n" + 
                "1. Insert integer number and make sure that it is INT. Press 1 to select. \n" +
                "2. Convert Kelvins to Fahrenheit. Press 2 to select. \n" +
                "3. Convert Celsius to Fahrenheit. Press 3 to select. \n" +
                "4. Check if you are adult or not. Press 4 to select. \n" +
                "5. Check if number can create a triangle. Press 5 to select. \n" +
                "6. Count word in sentence. Press 6 to select. \n" +
                "7. Revert string. Press 7 to select. \n" +
                "8. Exit. Press 6 to select. \n"
                );
            int response = System.Convert.ToInt16(Console.ReadLine());

            switch (response) {
                case 1:
                    Console.WriteLine("Your insterted number is: " + insertInt() +"\n");
                    selectFunction();
                    break;
                case 2:
                    Console.WriteLine("Inserted temperature in Kelvins is: " + FarToKel() + " Kelvins");
                    selectFunction();
                    break;
                case 3:
                    Console.WriteLine("Inserted temperature in Fahrenheits is: " + celsiusToFahrenit() + " Fahrenheits");
                    selectFunction();
                    break;
                case 4:
                    Console.WriteLine(adult());
                    selectFunction();
                    break;
                case 5:
                    Console.WriteLine(triangle());
                    selectFunction();
                    break;
                case 6:
                    Console.WriteLine(countWordsInString());
                    selectFunction();
                    break;
                case 7:
                    Console.WriteLine(reverseString());
                    selectFunction();
                    break;
                case 8:
                    exitApp();
                    break;
                default:
                    exitApp();
                    break;
            }

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

        public static string countWordsInString()
        {
            string input;
            int count = 0;
            string result;
            Console.WriteLine("Insert sentence");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input[i])){
                    count++;
                }
                
            }
            result = "There are " + (count + 1) + " word in this sentence.";
            return result;
        }

        public static StringBuilder reverseString()
        {
            string input;
            StringBuilder result = new StringBuilder();

            Console.WriteLine("Please insert sentence.");
            input = Console.ReadLine();

            for (int i = input.Length; i > 0; i--)
            {
                result.Append(input[i-1]);
            }

            return result;
        }

        public static void exitApp()
        {
            Environment.Exit(0);
        }

    }
}
