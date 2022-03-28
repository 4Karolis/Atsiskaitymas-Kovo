using System;
using System.Collections.Generic;
using System.Linq;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

        }//---------------------------------------------------------------------------------------------------------------------------
         //public static void MainMenu()
         //{
         //    Console.WriteLine("----------------------------------< MENIU >----------------------------------");
         //    Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus.");
         //    int pirktiKurti = int.Parse(Console.ReadLine());
         //    //return pirktiKurti;
         //}
        public static int PasirinktiBilietuTipa(int parduotiKurti)
        {
            parduotiKurti = MainMenu();

            Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
            Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
            int pasirinkimasPirkti = int.Parse(Console.ReadLine());
            switch (parduotiKurti)
            {
               case 1: 
                    break;
                default;
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("----------------------------------< MENIU >----------------------------------");
            Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
            int parduotiKurti = int.Parse(Console.ReadLine());
        }
    }
}