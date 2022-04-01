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

            List<int> parduotiBilietaiPo10Eur = new List<int>();
            List<int> parduotiBilietaiPo20Eur = new List<int>();
            List<int> parduotiBilietaiPo30Eur = new List<int>();

            List<int> sukurtiBilietaiPo10Eur = new List<int>();
            List<int> sukurtiBilietaiPo20Eur = new List<int>();
            List<int> sukurtiBilietaiPo30Eur = new List<int>();

            int sukurtapo10 = sukurtiBilietaiPo10Eur.Count();
            int sukurtapo20 = sukurtiBilietaiPo20Eur.Sum();
            int sukurtapo30 = sukurtiBilietaiPo30Eur.Sum();

            int parduotaPo10 = parduotiBilietaiPo10Eur.Sum();
            int parduotaPo20 = parduotiBilietaiPo20Eur.Sum();
            int parduotaPo30 = parduotiBilietaiPo30Eur.Sum();

            int likutisPo10 = sukurtapo10 - parduotaPo10;
            int likutisPo20 = sukurtapo20 - parduotaPo20;
            int likutisPo30 = sukurtapo30 - parduotaPo30;

            //int desimtukai = 0;
            //for (int i = 0; i < sukurtiBilietaiPo10Eur.Count; i++)
            //{
            //    desimtukai++;
            //}
            List<int> nupirktiPo10 = new List<int>();

            while (true)
            {
                //int bilietuPo10Kiekis = BilietaiPo10Eur.Sum();
                //int bilietuPo20Kiekis = BilietaiPo20Eur.Sum();
                //int bilietuPo30Kiekis = BilietaiPo30Eur.Sum();

                //Console.WriteLine("----------------------------------< MENIU >----------------------------------");
                //Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
                //int pirktiKurti = int.Parse(Console.ReadLine());

                //Rodo main meniu, gauna PIRKTI KURTI
                int pirktiKurti = MainMenu();
                switch (pirktiKurti)
                {
                    case 1:
                        //Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
                        //Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
                        //int pasirinkimasPirkti = int.Parse(Console.ReadLine());

                        //Duoda PIRKTI, ima inputa is main menu:
                        int bilietoTipasPirkti = Pirkti(pirktiKurti);
                        if (bilietoTipasPirkti == 1)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisPirkti1 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasPirkti);
                            for (int i = 0; i < kiekis; i++)
                            {
                                parduotiBilietaiPo10Eur.Add(-1);
                            }
                        }
                        else if (bilietoTipasPirkti == 2)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisPirkti2 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasPirkti);
                            for (int i = 0; i < kiekis; i++)
                            {
                                parduotiBilietaiPo20Eur.Add(-1);
                            }
                        }
                        else if (bilietoTipasPirkti == 3)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisPirkti3 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasPirkti);
                            for (int i = 0; i < kiekis; i++)
                            {
                                parduotiBilietaiPo30Eur.Add(-1);
                            }
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
                        int bilietoTipasKurti = Pirkti(pirktiKurti);
                        if (bilietoTipasKurti == 1)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisKurti1 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasKurti);

                            for (int i = 0; i < kiekis; i++)
                            {
                                sukurtiBilietaiPo10Eur.Add(1);
                            }
                        }
                        else if (bilietoTipasKurti == 2)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisKurti2 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasKurti);
                            for (int i = 0; i < kiekis; i++)
                            {
                                sukurtiBilietaiPo20Eur.Add(1);
                            }
                        }
                        else if (bilietoTipasKurti == 3)
                        {
                            //Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            //int kiekisKurti3 = int.Parse(Console.ReadLine());
                            int kiekis = IveskiteEuruKieki(bilietoTipasKurti);
                            for (int i = 0; i < kiekis; i++)
                            {
                                sukurtiBilietaiPo30Eur.Add(1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Neteisinga ivestis.Bandyk.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Bilietai po 10 EUr: sukurta [], parduota [], likutis []");
                        Console.WriteLine($"Bilietai po 20 EUr: sukurta [], parduota [], likutis []");
                        Console.WriteLine($"Bilietai po 30 EUr: sukurta [], parduota [], likutis []");
                        //Console.WriteLine(desimtukai);
                        break;
                }                
            }

            

            //int visoSukurta10 = bilietuKiekis.Count("1");
           

            //panaudosiu veliau, paziuret ar nesu minuse su bilietais
            //arba geriau atskirus daryt pirkimo / pardavimo listus...
            //int rezultatasPo10 = BilietaiPo10Eur.Sum();
            //Console.WriteLine(rezultatasPo10);
            //Console.WriteLine($"po 10 yra: {BilietaiPo10Eur.Count}, 20: {BilietaiPo20Eur.Count}, po 30: {BilietaiPo30Eur.Count}");

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
        public static int IveskiteEuruKieki(int pasirinkimasPirkti)
        {
            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
            int kiekis = int.Parse(Console.ReadLine());
            return kiekis;
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