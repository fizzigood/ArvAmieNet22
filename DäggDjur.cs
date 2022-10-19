using System;
using System.Collections.Generic;
using System.Text;

namespace ArvAmieNet22
{
    public class DäggDjur : DjurBase //DäggDjur ärver från DjurBase.
    {
        //DäggDjur : DjurBase har utöver DjurBase-egenskaperna också egna egenskaper:
        public string Vivipari { get; set; }
        public string Fur { get; set; }

        //Constructor av DäggDjur med kraven från DjurBase:
        public DäggDjur(
            string DType,
            string DName,
            int    Legs,
            string Eyes,
            string Nose,
            string Feet,
            string Sound) 
            : base(DType, 
                  DName, 
                  Legs, 
                  Eyes, 
                  Nose, 
                  Feet, 
                  Sound)

        //Klassens egna egenskaper:
        {
            this.Vivipari = Vivipari; //"this" specifierar/pekar på variabeln som är inuti klassen
            this.Fur = Fur; //den utan "this" som efterföljer är variabeln inuti constructorn
        }

        //KLassens egna metoder:
        public void GetFluff()
        {
            Fur = " har ett redigt fluff!";
            Console.WriteLine(DName + Fur);

        }
        public void GetKull()
        {
            Vivipari = " föder levande ungar";
            Console.WriteLine(DType + Vivipari);

        }
    }

    //Arv i andra nivån där KattDjur ärver från Däggdjur
    public class KattDjur : DäggDjur
    {
        //KattDjur har utöver DjurBase och DäggDjurs-egenskaperna också egna egenskaper:
        public string Sense { get; set; }
        public int Lives { get; set; }

        //Constructor av KattDjur med de in-parametrar som krävs av sin
        public KattDjur(
            string DType,
            string DName,
            int     Legs,
            string Eyes,
            string Nose,
            string Feet,
            string Sound,
            string Sense = " makes no sense. För att ", //Defaultvärde
            int Lives = 9) //Deafaultvärde
            : base(DType,
                   DName,
                   Legs,
                   Eyes,
                   Nose,
                   Feet,
                   Sound) // Arv av egenskaper/properties från basklassens constructor
        {
            this.Sense = Sense;
            this.Lives = Lives;
        }
        //KattDjursklassens klassspecifika metoder:
        public void MakeSense()
        {
            
            Console.WriteLine(DName + Sense + DName + "är en " + DType + ". ");

        }
        public void GetLives()
        {

            Console.WriteLine("Men det gör inget för "+ DName + " är en " + DType + " och har därför " + Lives + " liv.");

        }
    }

    //HundDjur som ärver från DäggDjur, arv i andra nivån
    public class HundDjur : DäggDjur
    {
        public string DogTale = " är glad att se dig och viftar på svansen!"; //Klass-specifik egenskap för HundDjur med defaultvärde

        public HundDjur(string DType,
                        string DName,
                            int Legs,
                         string Eyes,
                         string Nose,
                         string Feet,
                         string Sound)
                : base(DType,
                        DName,
                        Legs,
                        Eyes,
                        Nose,
                        Feet,
                        Sound)
        { }

        public void WiggleTale()
        {
            Console.WriteLine(DName + DogTale);
        }
    }
}
