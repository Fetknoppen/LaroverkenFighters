using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            Console.WriteLine("Välj vilken person som du vill prata med idag!\n1:Leif GW Persson\n2:Darth Vader\n3:En ryss\n4:Abu Hassan's fru");
            String Person = Console.ReadLine();
            //Leif GW Persson
            if (Person == "1")
            {
                Console.WriteLine("Hej hej");
                Thread.Sleep(1000);
                Console.WriteLine("*Rossel* *Rossel*");
                Thread.Sleep(2000);
                Console.WriteLine("Mitt namn är Leif GW Persson....");
                Thread.Sleep(1500);
                Console.WriteLine("Men det visste du väll redan hehe...");
                Thread.Sleep(1000);
                Console.WriteLine("*Grymt* *Rossel*");
                Thread.Sleep(2000);
                Console.WriteLine("Aja men nog om mig nu\nVad heter du?");
                String dittNamn = Console.ReadLine();
                Console.WriteLine("Hmmmm\n");
                Thread.Sleep(2000);
                Console.WriteLine(dittNamn);
                Thread.Sleep(2000);
                Console.WriteLine("*Rossel* Det var då ett vedervärdigt namn");
                Thread.Sleep(2000);
                Console.WriteLine("Mitt namn är mycket bättre!");
                Thread.Sleep(2000);
                Console.WriteLine("Vi kan byta ditt namn!\n Vad vill du heta?");
                Thread.Sleep(1000);
                Console.WriteLine("1:Leif\n2:Mr.GW\n3:Mr.Persson");
                String nyaNamn = Console.ReadLine();
                if (nyaNamn == "1")
                {
                    Console.WriteLine("*Rossel* hmm bra val");
                    Thread.Sleep(2000);
                    Console.WriteLine("Det får räcka, nu har du iallafall ett bra namn");
                    Thread.Sleep(1000);
                    Console.WriteLine("*rossel*");
                    Thread.Sleep(1500);
                    Console.WriteLine("Hejdå");
                }
                else if (nyaNamn == "2")
                {
                    Console.WriteLine("*Rossel* hmm ett namn av klass");
                    Thread.Sleep(1500);
                    Console.WriteLine("Nu får det räcka, nu har du iallafall ett bra namn");
                    Thread.Sleep(1500);
                    Console.WriteLine("*rossel*");
                    Thread.Sleep(1500);
                    Console.WriteLine("Hejdå");
                }
                else if (nyaNamn == "3")
                {
                    Console.WriteLine("*Rossel* hmm exceptionellt val av namn");
                    Console.WriteLine("Nu får det räcka, nu har du iallafall ett bra namn");
                    Thread.Sleep(1500);
                    Console.WriteLine("*rossel*");
                    Thread.Sleep(1500);
                    Console.WriteLine("Hejdå");
                }
                else
                {
                    Console.WriteLine("Dumhuvud får det bli då *Rossel*");
                    Thread.Sleep(1000);
                    Console.WriteLine("Sånna som dig vill jag inte prata med\nHejdå Dumhuvud");
                }
                Thread.Sleep(3000);
                Console.Clear();
                StartGame();
                
                


            }
            //Darth vader 
            else if (Person == "2")
            {
                Console.WriteLine("\nWho is there?!\n\n");
                Thread.Sleep(1000);
                Console.WriteLine("What is your name weakling?!\n\n");
                String dittNamn2 = Console.ReadLine();
                Console.Write("\nWhat do you want from me ");
                Console.Write(dittNamn2);
                Console.WriteLine("?");
                String VadDuVill = Console.ReadLine();
                Console.WriteLine("Hmmmmm\n");
                Thread.Sleep(1000);
                Console.WriteLine("I can not grant that wish\n");
                Thread.Sleep(3000);
                Console.WriteLine("Pffft\n");
                Thread.Sleep(1000);
                Console.WriteLine(VadDuVill);
                Thread.Sleep(2000);
                Console.WriteLine("Stupid\n");
                Thread.Sleep(1000);
                Console.WriteLine("SHOOO GO!!\n");
                Thread.Sleep(1000);
                Console.WriteLine("I\n");
                Thread.Sleep(1000);
                Console.WriteLine("DONT\n");
                Thread.Sleep(1000);
                Console.WriteLine("WANT\n");
                Thread.Sleep(1000);
                Console.WriteLine("YOU\n");
                Thread.Sleep(1000);
                Console.WriteLine("HERE\n\n");
                Console.WriteLine("1:Go back\n2:Stay");
                String BackOrStay = Console.ReadLine();
                //Go back
                if (BackOrStay == "1")
                {
                    Console.WriteLine("THANK GOD!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StartGame();
                }
                //Stay
                else if (BackOrStay == "2")
                {
                    Console.WriteLine("What is your problem?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Just go.......");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StartGame();
                }

            }
            //En Ryss
            else if (Person == "3")
            {
                Console.WriteLine("AAAAAHH PRIVIET");
                Thread.Sleep(1000);
                Console.WriteLine("Vodka?");
                Thread.Sleep(1000);
                Console.WriteLine("1:DA!\n2:NIET!");
                String JaEllerNej = Console.ReadLine();
                if (JaEllerNej == "1")
                {
                    Console.WriteLine("VODKA!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StartGame();
                }
                if (JaEllerNej == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("BLYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAT");
                    }
                }

                Console.WriteLine("");
            }
            //Abu Hassan's fru
            else if (Person == "4")
            {
                Console.WriteLine("Är du säker att du vill prata med henne?");
                Console.WriteLine("1:Ja de är klart jag vill\n2:Nej");
                String EttEllerTvå = Console.ReadLine();
                if (EttEllerTvå == "1")
                {
                    Console.WriteLine("Hon är inte speciellt trevlig bara så att du vet\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Är du helt säker?");
                    Console.WriteLine("1:Ja jag är helt säker.......\n2:Okej då jag skiter väll i det :(");
                    String fruHassan = Console.ReadLine();
                    if (fruHassan == "1")
                    {
                        Thread.Sleep(800);
                        Console.WriteLine("\nDu får som du vill!");
                        Console.WriteLine("Hallå du!!");
                        Thread.Sleep(800);
                        Console.WriteLine("Vad vill du?!");
                        Thread.Sleep(900);
                        Console.WriteLine("Abu Hassan är inte här!!");
                        Thread.Sleep(800);
                        Console.WriteLine("Du kan kom in här jag ska visa du!");
                        Thread.Sleep(900);
                        Console.WriteLine("se den mycket fin");
                        Thread.Sleep(800);
                        Console.WriteLine("ojojoj du är väldigt stor om din mage!!");
                        Thread.Sleep(900);
                        Console.WriteLine("du bara äta chibse");
                        Thread.Sleep(800);
                        Console.WriteLine("du sluta äta chibse");
                        Thread.Sleep(900);
                        Console.WriteLine("vänt!\nvill du ha en lite kaka? ");
                        Thread.Sleep(900);
                        Console.WriteLine("Jag se du gilla kaka!");
                        Thread.Sleep(800);
                        Console.WriteLine("1: JA!\n2: Nej jag vill inte ha en kaka....");
                        String Kaka = Console.ReadLine();
                        if (Kaka == "1")
                        {
                            Console.WriteLine("Ja jag vet, jag se på dig du gilla kaka");
                            Console.ReadKey();
                            Console.Clear();
                            StartGame();
                        }
                        else if (Kaka == "2")
                        {
                            Console.WriteLine("Aahh mycke bra du gå på den diet");
                            Console.ReadKey();
                            Console.Clear();
                            StartGame();
                        }
                        Thread.Sleep(800);
                        Console.WriteLine("Naj nu jag inte vill prat med dig!\ndu inte trevlig med mig.");

                        Console.ReadKey();
                    }
                }
                else if (EttEllerTvå == "2");
                {
                    Console.WriteLine("Bra, hon är en riktig mara den där");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StartGame();
                }
            }






            
            Console.ReadKey();
        }
    }

}




