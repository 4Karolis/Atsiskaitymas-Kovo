using System;
using System.Collections.Generic;

namespace Atsiskaitymas_Kovo_men_
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<int> BilietaiPo10Eur = new List<int>();
            List<int> BilietaiPo20Eur = new List<int>();
            List<int> BilietaiPo30Eur = new List<int>();

            Console.WriteLine("----------------------------------< MENIU >----------------------------------");
            Console.WriteLine("[1] PIRKTI bilietus, [2] KURTI bilietus. Q - iseiti ir programos.");
            int pirmasPasirinkimas = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------");

            //bool pirmasTeisingasPasirinkimas = (pirmasPasirinkimas == "1" || "2" || "Q" || "q");
            //int pirmasPasirinkimasInt = int.Parse(pirmasPasirinkimas());
            //bool notQ1 = pirmasPasirinkimas != "q" || "Q";

            switch (pirmasPasirinkimas)
            {
                case 1: Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur. Q - iseiti is programos.");
                    int pirktiPasirinkimas = int.Parse(Console.ReadLine());
                    break;                    
                        switch (pirktiPasirinkimas)
                        {
                            case 1:
                                Console.WriteLine("Iveskite kieki: ");
                                int kiekis1 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < kiekis1; i++)
                            {
                                BilietaiPo10Eur.Add(1);
                            }                                                                                         
                                break;
                            case 2:
                                Console.WriteLine("Iveskite kieki: ");
                                int kiekis2 = int.Parse(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Iveskite kieki: ");
                                int kiekis3 = int.Parse(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Kazka neteisingai ivedete. Bankykite dar karta.");
                                break;
                        }                    
                case 2: Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10 Eur, [2] Po 20 Eur, [3] Po 30 Eur. Q - iseiti is programos.");
                    int kurtiPasirinkimas = int.Parse(Console.ReadLine());
                    break;
                    switch (kurtiPasirinkimas)
                    {
                        case 1:
                            Console.WriteLine("Iveskite kieki: ");
                            int kiekis1 = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Iveskite kieki: ");
                            int kiekis2 = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Iveskite kieki: ");
                            int kiekis3 = int.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Kazka neteisingai ivedete. Bankykite dar karta.");
                            break;
                    }
                default: Console.WriteLine("Kazka neteisingai ivedete. Bankykite dar karta.");
                    break;

            }
            //Console.WriteLine("Nupirkta:");
            //foreach (var item in BilietaiPo10Eur)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
