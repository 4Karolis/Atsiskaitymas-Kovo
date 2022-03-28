using System;
using System.Collections.Generic;
using System.Linq;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> BilietaiPo10Eur = new List<int>();
            List<int> BilietaiPo20Eur = new List<int>();
            List<int> BilietaiPo30Eur = new List<int>();

            //int bilietai10 = 0;
            //int bilietai20 = 0;
            //int bolietai30 = 0;

            while (true)
            {
                Console.WriteLine("----------------------------------< MENIU >----------------------------------");
                Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
                int pirktiKurti = int.Parse(Console.ReadLine());

                int bilietuPo10Kiekis = BilietaiPo10Eur.Sum();
                int bilietuPo20Kiekis = BilietaiPo20Eur.Sum();
                int bilietuPo30Kiekis = BilietaiPo30Eur.Sum();

                //int visoSukurta10 = 0;
                //int visoSukurta20 = 0;
                //int visoSukurta30 = 0;

                //int visoParduota10 = 0;
                //int visoParduota20 = 0;
                //int visoPardduota30 = 0;


                switch (pirktiKurti)
                {
                    case 1:
                        Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
                        Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
                        int pasirinkimasPirkti = int.Parse(Console.ReadLine());
                        if (pasirinkimasPirkti == 1)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisPirkti1 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisPirkti1; i++)
                            {
                                BilietaiPo10Eur.Add(-1);
                            }
                        }
                        else if (pasirinkimasPirkti == 2)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisPirkti2 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisPirkti2; i++)
                            {
                                BilietaiPo20Eur.Add(-1);
                            }
                        }
                        else if (pasirinkimasPirkti == 3)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisPirkti3 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisPirkti3; i++)
                            {
                                BilietaiPo30Eur.Add(-1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Neteisinga ivestis. Bandykite dar karta");
                        }
                        break;
                    case 2:
                        Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
                        Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
                        int pasirinkimasKurti = int.Parse(Console.ReadLine());
                        if (pasirinkimasKurti == 1)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti1 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti1; i++)
                            {
                                BilietaiPo10Eur.Add(1);
                            }
                        }
                        else if (pasirinkimasKurti == 2)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti2 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti2; i++)
                            {
                                BilietaiPo20Eur.Add(1);
                            }
                        }
                        else if (pasirinkimasKurti == 3)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti3 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti3; i++)
                            {
                                BilietaiPo30Eur.Add(1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Neteisinga ivestis.Bandyk.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Esamu bilietu kiekis: Po 10 Eur [{bilietuPo10Kiekis}], Po 20 Eur [{bilietuPo20Kiekis}], Po 30 Eur [{bilietuPo30Kiekis}]");
                        break;                    
                }
            }

            int visoSukurta10 = bilietuKiekii.Count("1");
           

            //panaudosiu veliau, paziuret ar nesu minuse su bilietais
            //arba geriau atskirus daryt pirkimo / pardavimo listus...
            //int rezultatasPo10 = BilietaiPo10Eur.Sum();
            //Console.WriteLine(rezultatasPo10);
            //Console.WriteLine($"po 10 yra: {BilietaiPo10Eur.Count}, 20: {BilietaiPo20Eur.Count}, po 30: {BilietaiPo30Eur.Count}");

        }//---------------------------------------------------------------------------------------------------------------------------
         //public static void MainMenu()
         //{
         //    Console.WriteLine("----------------------------------< MENIU >----------------------------------");
         //    Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus.");
         //    int pirktiKurti = int.Parse(Console.ReadLine());
         //    //return pirktiKurti;
        //}
    }
}