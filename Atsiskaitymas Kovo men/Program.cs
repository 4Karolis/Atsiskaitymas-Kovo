using System;
using System.Collections.Generic;
using System.Linq;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<int> SukurtiPo10 = new List<int>();
            List<int> SukurtiPo20 = new List<int>();
            List<int> SukurtiPo30 = new List<int>();

            List<int> NupirktiPo10 = new List<int>();
            List<int> NupirktiPo20 = new List<int>();
            List<int> NupirktiPo30 = new List<int>();            

            while (true)
            {                
                int pirktiKurti = MainMenu();
                switch (pirktiKurti)
                {
                    case 1:                       
                        int bilietoTipasPirkti = Pirkti(pirktiKurti);
                        if (bilietoTipasPirkti == 1)
                        {                            
                            IveskiteEuruKieki(bilietoTipasPirkti);
                            int kiekis = int.Parse(Console.ReadLine());
                            //GaunuKieki(bilietoTipasPirkti);//pabandyt gaut atskira metoda cw!
                            Add2(NupirktiPo10, kiekis);                            
                        }
                        else if (bilietoTipasPirkti == 2)
                        {                           
                            IveskiteEuruKieki(bilietoTipasPirkti);
                            int kiekis = int.Parse(Console.ReadLine());
                            Add2(NupirktiPo20, kiekis);
                        }
                        else if (bilietoTipasPirkti == 3)
                        {
                            IveskiteEuruKieki(bilietoTipasPirkti);
                            int kiekis = int.Parse(Console.ReadLine());
                            Add2(NupirktiPo30, kiekis);
                        }
                        else
                        {
                            Console.WriteLine("Neteisinga ivestis. Bandykite dar karta");
                        }
                        break;
                    case 2:                        
                        int bilietoTipasKurti = Kurti(pirktiKurti);
                        if (bilietoTipasKurti == 1)
                        {
                            IveskiteEuruKieki(bilietoTipasKurti);
                            int kiekis = int.Parse(Console.ReadLine());
                            Add2(SukurtiPo10, kiekis);
                        }
                        else if (bilietoTipasKurti == 2)
                        {
                            IveskiteEuruKieki(bilietoTipasKurti);
                            int kiekis = int.Parse(Console.ReadLine());
                            Add2(SukurtiPo20, kiekis);
                        }
                        else if (bilietoTipasKurti == 3)
                        {
                            IveskiteEuruKieki(bilietoTipasKurti);
                            int kiekis = int.Parse(Console.ReadLine());
                            Add2(SukurtiPo30, kiekis);
                        }
                        else
                        {
                            Console.WriteLine("Neteisinga ivestis.Bandyk.");
                        }
                        break;
                    case 3:
                        Ataskaita10(SukurtiPo10, NupirktiPo10);
                        Ataskaita20(SukurtiPo20, NupirktiPo20);
                        Ataskaita30(SukurtiPo30, NupirktiPo30);
                        break;
                }                
            }

        }//---------------------------------------------------------------------------------------------------------------------------
        //public static PridetParduota10()
        //{

        //}
        //public static int Kurti(int pirktiKurti)
        //{
        //    Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
        //    Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
        //    int pasirinkimasKurti = int.Parse(Console.ReadLine());
        //    return pasirinkimasKurti;
        //}
        public static void Ataskaita10(List<int> SukurtiPo10, List<int> NupirktiPo10)
        {
            Console.WriteLine($"Bilietai po 10 EUr: sukurta [{SukurtiPo10.Count}], parduota [{NupirktiPo10.Count}], likutis [{SukurtiPo10.Count - NupirktiPo10.Count}]");

        }
        public static void Ataskaita20(List<int> SukurtiPo20, List<int> NupirktiPo20)
        {
            Console.WriteLine($"Bilietai po 20 EUr: sukurta [{SukurtiPo20.Count}], parduota [{NupirktiPo20.Count}], likutis [{SukurtiPo20.Count - NupirktiPo20.Count}]");

        } public static void Ataskaita30(List<int> SukurtiPo30, List<int> NupirktiPo30)
        {
            Console.WriteLine($"Bilietai po 10 EUr: sukurta [{SukurtiPo30.Count}], parduota [{NupirktiPo30.Count}], likutis [{SukurtiPo30.Count - NupirktiPo30.Count}]");

        }
        public static int GaunuKieki(int pasirinkimasPirkti)
        {
            int kiekis = int.Parse(Console.ReadLine());
            return kiekis;
        }
        public static void Add2(List<int> intList, int kiekis)
        {
            //list to store elements to be added
           
            //int skaicius = int.Parse(Console.ReadLine());
            for ( int c = 0; c < kiekis; c++)
            {
                intList.Add(1);
            }
            //return c;
            //ints.AddRange(inserts);
        }
        public static void Prideti(List<int> intList, int pasirinkimasPirkti, int j)
        {
            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
            //int kiekis = int.Parse(Console.ReadLine());
            //return kiekis;
            for (int i = 0; i < j; i++)
            {
                
            }
           // Add2(List<> intList,)
        }
        public static void AddToList(List<int> intList, int skaicius)// del , 1 gal
        {
            int a = 1;
            intList.Add(a);
        }
        public static void IveskiteEuruKieki(int pasirinkimasPirkti)
        {
            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
            //int kiekis = int.Parse(Console.ReadLine());
            //return kiekis;
        }
        public static int Kurti(int pirktiKurti)
        {
            Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
            Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
            int bilietoTipasKurti = int.Parse(Console.ReadLine());
            return bilietoTipasKurti;
        }
        public static int Pirkti(int pirktiKurti)
        {
            Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
            Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
            int bilietoTipasPirkti = int.Parse(Console.ReadLine());
            return bilietoTipasPirkti;
        }
         public static int MainMenu()
        {
            Console.WriteLine("----------------------------------< MENIU >----------------------------------");
            Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
            int pirktiKurti = int.Parse(Console.ReadLine());
            return pirktiKurti;
        }
    }
}