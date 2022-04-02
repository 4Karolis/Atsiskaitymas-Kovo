using System;
using System.Collections.Generic;
using System.Linq;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LIST'ai         
            List<int> SukurtiPo10 = new List<int>();
            List<int> SukurtiPo20 = new List<int>();
            List<int> SukurtiPo30 = new List<int>();

            List<int> NupirktiPo10 = new List<int>();
            List<int> NupirktiPo20 = new List<int>();
            List<int> NupirktiPo30 = new List<int>();
            #endregion

            #region PROGRAMA
            bool dasviduli = false;
            //int pradzia = MainMenu();

            while (!dasviduli)
            {
                int pirktiKurti = MainMenu();
                switch (pirktiKurti)
                {
                    case 1:
                        Keisas(pirktiKurti, NupirktiPo10, NupirktiPo20, NupirktiPo30);
                        break;
                    case 2:
                        Keisas(pirktiKurti, SukurtiPo10, SukurtiPo20, SukurtiPo30);
                        break;
                    case 3:
                        Ataskaita10(SukurtiPo10, NupirktiPo10);
                        Ataskaita20(SukurtiPo20, NupirktiPo20);
                        Ataskaita30(SukurtiPo30, NupirktiPo30);
                        break;
                    case 4:
                        Dasviduli2();
                        break;                        
                }
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------
        #region METODAI
        public static void Dasviduli2()
        {
            Console.Clear();
            Console.WriteLine("Aciu, kad naudojates musu paslaugomis. iki kito karto!");
            Environment.Exit(0);
        }
        public static void Dasviduli()
        {
            bool dasviduli = false;
            Console.Clear();
            Console.WriteLine("Aciu, kad naudojates musu paslaugomis. Iki kito karto!");
            Atsisveikinimas();
        }
        public static void Keisas(int pirktiKurti, List<int> NupirktiPo10, List<int> NupirktiPo20, List<int> NupirktiPo30)
        {
            
            int bilietoTipasPirkti = Pirkti(pirktiKurti);
            if (bilietoTipasPirkti == 1)
            {
                IveskiteBilietuKieki(bilietoTipasPirkti);
                int kiekis = int.Parse(Console.ReadLine());
                //GaunuKieki(bilietoTipasPirkti);//pabandyt gaut atskira metoda cw!
                Add2(NupirktiPo10, kiekis);
            }
            else if (bilietoTipasPirkti == 2)
            {
                IveskiteBilietuKieki(bilietoTipasPirkti);
                int kiekis = int.Parse(Console.ReadLine());
                Add2(NupirktiPo20, kiekis);
            }
            else if (bilietoTipasPirkti == 3)
            {
                IveskiteBilietuKieki(bilietoTipasPirkti);
                int kiekis = int.Parse(Console.ReadLine());
                Add2(NupirktiPo30, kiekis);
            }
            else
            {
                Console.WriteLine("Neteisinga ivestis. Bandykite dar karta");
            }
        }
        public static void WrongInput()
        {

        }
        public static void Atsisveikinimas()
        {
            Console.WriteLine("ate");
        }
        public static void Ataskaita10(List<int> SukurtiPo10, List<int> NupirktiPo10)
        {
            Console.WriteLine($"Bilietai po 10 EUr: sukurta [{SukurtiPo10.Count}], parduota [{NupirktiPo10.Count}], likutis [{SukurtiPo10.Count - NupirktiPo10.Count}]");

        }
        public static void Ataskaita20(List<int> SukurtiPo20, List<int> NupirktiPo20)
        {
            Console.WriteLine($"Bilietai po 20 EUr: sukurta [{SukurtiPo20.Count}], parduota [{NupirktiPo20.Count}], likutis [{SukurtiPo20.Count - NupirktiPo20.Count}]");

        }
        public static void Ataskaita30(List<int> SukurtiPo30, List<int> NupirktiPo30)
        {
            Console.WriteLine($"Bilietai po 10 EUr: sukurta [{SukurtiPo30.Count}], parduota [{NupirktiPo30.Count}], likutis [{SukurtiPo30.Count - NupirktiPo30.Count}]");

        }
        public static int GaunuKieki()
        {
            int kiekis = int.Parse(Console.ReadLine());
            return kiekis;
        }
        public static void Add2(List<int> intList, int kiekis)
        {
            for (int c = 0; c < kiekis; c++)
            {
                intList.Add(1);
            }
        }
        public static void AddToList(List<int> intList, int skaicius)// del , 1 gal
        {
            int a = 1;
            intList.Add(a);
        }
        public static void IveskiteBilietuKieki(int pasirinkimasPirkti)
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
            Console.Clear();
            Console.WriteLine("------------------------------------< MENIU >------------------------------------");
            Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA, [4] ISEITI is programos");
            //int.TryParse(Console.ReadLine(), out int pirktiKurti);
            int pirktiKurti;
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int inputas);
                bool gerasInputas = inputas == 1 || inputas == 2 || inputas == 3 || inputas == 4;
                if (gerasInputas)
                {
                    pirktiKurti = inputas;
                    break;
                }
                else
                {
                    Console.WriteLine("\nNeteisingai ivestas pasirinkimas!");
                }
            }
            return pirktiKurti;
        }        
        #endregion
    }
}