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
            //PasirinktiBilietuTipa();

        }//---------------------------------------------------------------------------------------------------------------------------
         //public static void MainMenu()
         //{
         //    Console.WriteLine("----------------------------------< MENIU >----------------------------------");
         //    Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus.");
         //    int pirktiKurti = int.Parse(Console.ReadLine());
         //    //return pirktiKurti;
         //}
        public static int PasirinktiBilietuTipa2(int parduotiKurti)
        {
            parduotiKurti = MainMenu();

            Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
            Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
            int pasirinkimasPirkti = int.Parse(Console.ReadLine());
            if(pasirinkimasPirkti == 1)
            {
                Console.WriteLine("Iveskite kieki: ");
                int pirkti = int.Parse(Console.ReadLine());
                return pirkti;
            }
            else if(pasirinkimasPirkti == 2)
            {
                Console.WriteLine("Iveskite kieki: ");
                int pirkti = int.Parse(Console.ReadLine());
            }
            else if(pasirinkimasPirkti == 3)
            {
                Console.WriteLine("Iveskite kieki: ");
                int pirkti = int.Parse(Console.ReadLine());
            }
        }
        //public static void PasirinktiBilietuTipa(int parduotiKurti)
        //{
        //    parduotiKurti = MainMenu();

        //    Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
        //    Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
        //    int pasirinkimasPirkti = int.Parse(Console.ReadLine());
        //    switch (pasirinkimasPirkti)
        //    {
        //       case 1:
        //            Console.WriteLine("Iveskite kieki:");
        //            int kiekisPirkti1 = int.Parse(Console.ReadLine());
        //            //return kiekisPirkti1;
        //            break;

        //        case 2:
        //            Console.WriteLine("Iveskite kieki:");
        //            int kiekisPirkti2 = int.Parse(Console.ReadLine());
        //           // return kiekisPirkti2;
        //            break;
        //        case 3:
        //            Console.WriteLine("Iveskite kieki:");
        //            int kiekisPirkti3 = int.Parse(Console.ReadLine());
        //           // return kiekisPirkti3;
        //            break;
        //    }
        //}
        public static int MainMenu()
        {
            Console.WriteLine("----------------------------------< MENIU >----------------------------------");
            Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
            int parduotiKurti = int.Parse(Console.ReadLine());
            return parduotiKurti;
        }
    }
}