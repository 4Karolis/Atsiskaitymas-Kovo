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

            while (true)
            {               
                Console.WriteLine("----------------------------------< MENIU >----------------------------------");
                Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus, [3] ATASKAITA");
                int pirktiKurti = int.Parse(Console.ReadLine());

                //int bilietuPo10Kiekis = BilietaiPo10Eur.Sum();
                //int bilietuPo20Kiekis = BilietaiPo20Eur.Sum();
                //int bilietuPo30Kiekis = BilietaiPo30Eur.Sum();

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
                                parduotiBilietaiPo10Eur.Add(-1);
                            }
                        }
                        else if (pasirinkimasPirkti == 2)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisPirkti2 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisPirkti2; i++)
                            {
                                parduotiBilietaiPo20Eur.Add(-1);
                            }
                        }
                        else if (pasirinkimasPirkti == 3)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisPirkti3 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisPirkti3; i++)
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
                        Console.WriteLine("-----------------------< Pasirinkite bilieto tipa >--------------------------");
                        Console.WriteLine("[1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur");
                        int pasirinkimasKurti = int.Parse(Console.ReadLine());
                        if (pasirinkimasKurti == 1)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti1 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti1; i++)
                            {
                                sukurtiBilietaiPo10Eur.Add(1);
                            }
                        }
                        else if (pasirinkimasKurti == 2)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti2 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti2; i++)
                            {
                                sukurtiBilietaiPo20Eur.Add(1);
                            }
                        }
                        else if (pasirinkimasKurti == 3)
                        {
                            Console.WriteLine("-----------------------------< Iveskite kieki >------------------------------");
                            int kiekisKurti3 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekisKurti3; i++)
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
                        Console.WriteLine($"Bilietai po 10 EUr: sukurta [{sukurtapo10}], parduota [{parduotaPo10}], likutis [{likutisPo10}]");
                        Console.WriteLine($"Bilietai po 20 EUr: sukurta [{sukurtapo20}], parduota [{parduotaPo20}], likutis [{likutisPo20}]");
                        Console.WriteLine($"Bilietai po 30 EUr: sukurta [{sukurtapo30}], parduota [{parduotaPo30}], likutis [{likutisPo30}]");
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
         //public static void MainMenu()
         //{
         //    Console.WriteLine("----------------------------------< MENIU >----------------------------------");
         //    Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus.");
         //    int pirktiKurti = int.Parse(Console.ReadLine());
         //    //return pirktiKurti;
        //}
    }
}