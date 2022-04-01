using System;
using System.Collections.Generic;
using System.Linq;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {

            //int result = list.sum();

            //int desimtukai = sukurtiBilietaiPo10Eur.Count();

            //List<int> parduotiBilietaiPo10Eur = new List<int>();
            //List<int> parduotiBilietaiPo20Eur = new List<int>();
            //List<int> parduotiBilietaiPo30Eur = new List<int>();

            //List<int> sukurtiBilietaiPo10Eur = new List<int>();
            //List<int> sukurtiBilietaiPo20Eur = new List<int>();
            //List<int> sukurtiBilietaiPo30Eur = new List<int>();

            //int sukurtapo10 = sukurtiBilietaiPo10Eur.Count();
            //int sukurtapo20 = sukurtiBilietaiPo20Eur.Sum();
            //int sukurtapo30 = sukurtiBilietaiPo30Eur.Sum();

            //int parduotaPo10 = parduotiBilietaiPo10Eur.Sum();
            //int parduotaPo20 = parduotiBilietaiPo20Eur.Sum();
            //int parduotaPo30 = parduotiBilietaiPo30Eur.Sum();

            //int likutisPo10 = sukurtapo10 - parduotaPo10;
            //int likutisPo20 = sukurtapo20 - parduotaPo20;
            //int likutisPo30 = sukurtapo30 - parduotaPo30;



            List<int> SukurtiPo10 = new List<int>();
            List<int> SukurtiPo20 = new List<int>();
            List<int> SukurtiPo30 = new List<int>();

            List<int> NupirktiPo10 = new List<int>();
            List<int> NupirktiPo20 = new List<int>();
            List<int> NupirktiPo30 = new List<int>();

            int sukurtaPo10 = SukurtiPo10.Count();
            int sukurtaPo20 = SukurtiPo20.Count();
            int sukurtaPo30 = SukurtiPo30.Count();

            int nupirktaPo10 = NupirktiPo10.Count();
            int nupirktaPo20 = NupirktiPo20.Count();
            int nupirktaPo30 = NupirktiPo30.Count();

            int likutisPo10 = sukurtaPo10 - nupirktaPo10;
            int likutisPo20 = sukurtaPo20 - nupirktaPo30;
            int likutisPo30 = sukurtaPo30 - nupirktaPo30;

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
                        //Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
                        //Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
                        //int pasirinkimasKurti = int.Parse(Console.ReadLine());
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
                        Console.WriteLine($"Bilietai po 10 EUr: sukurta [{sukurtaPo10}], parduota [{nupirktaPo10}], likutis [{likutisPo10}]");
                        Console.WriteLine($"Bilietai po 20 EUr: sukurta [{sukurtaPo20}], parduota [{nupirktaPo20}], likutis [{likutisPo20}]");
                        Console.WriteLine($"Bilietai po 30 EUr: sukurta [{sukurtaPo30}], parduota [{nupirktaPo30}], likutis [{likutisPo30}]");
                        Console.WriteLine(sukurtaPo10);
                        //Console.WriteLine($"Katik pridejau krc: {TestuojuListus}");                        
                        //Console.WriteLine(TestuojuListus2.Count);                        
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