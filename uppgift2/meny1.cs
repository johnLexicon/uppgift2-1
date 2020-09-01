using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ex2
{
    
        
        
    
    class Program2
    {
    static int FindPrice(int num)
    {
        int upris = 80;
        int ppris = 90;
        int stpris = 120;

        if (num < 21)
        {
            return upris;


        }
        else if (num > 64)
        {
            return ppris;
        }
        else
        {
            return stpris;
        }
    }
        static void Main(string[] args)
        {
            while (true)
            {
                string choiceinput;

                int upris = 80;
                int ppris = 90;
                int stpris = 120;

                Console.WriteLine("Welcome! this is the main menu - 0 = quit, 1 = calculate price for your age g = calculate price for a group ");
                Console.WriteLine("2 = for loop, 3 = split a sentence in parts");
              choiceinput = Console.ReadLine();

                switch (choiceinput)
                {
                    case "0":
                        Console.WriteLine("program exits!");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("invalid option/ please make onother option");
                        break;
                    case "1":
                        Console.WriteLine("Please enter your age to calculate price");
                        string agechoice = Console.ReadLine();
                        int agechoicex = int.Parse(agechoice);
                        if (agechoicex < 21)
                        {
                            Console.WriteLine("ungdomspris:" + upris);


                        }
                        else if (agechoicex > 64)
                        {
                            Console.WriteLine("pensionärspris:"+ ppris);
                        }
                        else
                        {
                            Console.WriteLine("standrdpris:"+ stpris);
                        }
                        break;
                    case "g":
                        string xnr;
                        int i = 0;
                        List<int> ages = new List<int>();
                        
                        Console.WriteLine("input number of people");
                        xnr = Console.ReadLine();
                        int xnrconverted = int.Parse(xnr);
                        while (i< xnrconverted)
                        {
                            i += 1;
                        Console.WriteLine("input age of person" + i);
                        string agex = Console.ReadLine();
                        int agexint = int.Parse(agex);
                        ages.Add(agexint);
                        }
                        i = 0;
                        int totprice = 0;
                        while (i < xnrconverted)
                        { int el = ages.ElementAt(i);
                        int price = FindPrice(el);
                            totprice = totprice + price;
                            
                        i += 1;
                        }
                        Console.WriteLine("Antal:" + i);
                        Console.WriteLine("Pris:" + totprice);
                        Console.WriteLine(" ");
                        break;
                    case "2":
                        Console.WriteLine("Skriv in något ");
                        
                        Console.WriteLine("Skriv in något som ska upprepas x 10");
                        choiceinput = Console.ReadLine();
                        for (int r = 0; r < 11; r++)

                        {
                            Console.WriteLine(r + "." + choiceinput);

                        }

                        break;
                    case "3":
                        
                        Console.WriteLine("Write any sentence with min 3 words");
                        var sent = Console.ReadLine();
                        string[] words = sent.Split(" ");
                        Console.WriteLine(words[2]);


                        break;
                }
            }
        }
    }
}
