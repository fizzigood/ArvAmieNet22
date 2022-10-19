using System;
using System.Collections.Generic;
using System.Text;

namespace ArvAmieNet22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instans av KrälDjur:
            KrälDjur Krokodil = new KrälDjur(
                "Krokodil",
                "Krokus",
                4,
                "Avlånga pupiller. Täcks av en hinna när den är under vatten.",
                "Avlång och spetsig nos",
                "Fyra tår fram och fem bak.",
                "Grrr!! Blubb, blubb!"); 

            //Kallar på metoderna från DjurBase och KrälDjur:
            Krokodil.Introduction();
            Krokodil.MakeSound();
            Krokodil.WalkAround();
            Krokodil.Eat();
            Krokodil.Dance();
            Krokodil.Sleep();

            Console.WriteLine();

            //Instans av FågelDjur;
            FågelDjur Påfågel = new FågelDjur(
                "Påfågel",
                "Anki", 
                2, 
                "Större ögon än hos däggdjur", 
                "Spetsig näbb", "Klor. Tuppfågel har sporrar", 
                "Kahka, kahka! Väääs, väääs!");

            //Kallar på metoderna från basklassen och den ärvda klassen
            Påfågel.Introduction();
            Påfågel.MakeSound();
            Påfågel.WalkAround();
            Påfågel.LayEgg();
            Påfågel.Fly();

            Console.WriteLine();

            //Instans av DäggDjursklassen:
            DäggDjur Varg = new DäggDjur(
                "Varg", 
                "Wolfie ",
                4, 
                " framåtriktade, som hos rovdjur. ", 
                " rund nos", 
                " fyra tår", 
                "Aaaaawooooooo! Sniff, sniff.");

            //Kallar på metoderna som DäggDjuret har tillgång till:
            Varg.Introduction();
            Varg.MakeSound();
            Varg.GetFluff();
            Varg.GetKull();
            Varg.Sleep();

            Console.WriteLine();

            //Instans av KattDjur som ärver från basklassen och DäggDjur:
            KattDjur katt = new KattDjur(
                "Katt", 
                "Tiger", 
                4, 
                " rovdjursögon med avlånga pupiller.", 
                "kort nos", 
                " tassar med utfällbara", 
                " Mjaaaaaaaaaoooouuuuuuu!!!!");

            //Några av metoderna som KattDjur har tillgång till:
            katt.Introduction();
            katt.MakeSound();
            katt.GetFluff();
            katt.MakeSense();
            katt.GetLives();

            Console.WriteLine();

            //Instans av HundDjur som också ärver från både basklassen och DäggDjur:
            HundDjur hund = new HundDjur("Hund ",
                                         "Voffas ",
                                         4,
                                         " runda pupiller ",
                                         " avlång och dunderbra luktsinne ",
                                         " hunden har tassar ",
                                         " Woff, woff! ");

            //Några metoder som Hunddjur har tillgång tll:
            hund.Introduction();
            hund.MakeSound();
            hund.WiggleTale();
            hund.GetFluff();
            hund.Sleep();

            Console.ReadLine();//For good measure
        }
    }
}
