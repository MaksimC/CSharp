using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrst_Console_App
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            int a = 3;

            string result = Console.ReadLine();

            //String sugu = "mees";

         

            Sugu sugu = Sugu.Mees;
        }

        int arv1 = 0;
        int arv2 = 0;

        public static int arvuta(int arv1, int arv2)
        {
            return arv1 + arv2;
        }


    }

    /*
     * Loo meetodi
     * 1. Mida Meetod tagastab?
     * int
     * 2.Mis on meetodi nimi?
     * arvuta
     * 3. Kas meetodile on vaja anda kaasa parameetrid?
     * kaks taisarvu
     * 

    */

    public enum Sugu : int
    {
        Naine = 0,
        Mees = 1
    }

}
