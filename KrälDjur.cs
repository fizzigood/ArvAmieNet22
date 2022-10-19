using System;
using System.Collections.Generic;
using System.Text;

namespace ArvAmieNet22
{
    public class KrälDjur : DjurBase //KrälDjur ärver från DjurBase.
    {
        //KrälDjur : DjurBase har utöver DjurBase-egenskaperna också Tale och Scales.
        public string Tale { get; set; }
        public string Scales { get; set; }

        public KrälDjur(
            string DType, 
            string DName, 
            int    Legs, 
            string Eyes, 
            string Nose, 
            string Feet, 
            string Sound) //Constructor/krav från DjurBase.
            :base(
                 DType, 
                 DName, 
                 Legs, 
                 Eyes, 
                 Nose, 
                 Feet, 
                 Sound)
        {
            this.DType = DType; //"this" specifierar/pekar på variabeln som är inuti klassen
            this.DName = DName; //den utan "this" är variabeln inuti constructorn
            this.Legs = Legs;
            this.Eyes = Eyes;
            this.Nose = Nose;
            this.Feet = Feet;
            this.Sound = Sound;

        }
        public void Dance()
        {
            Tale = "dansar och viftar med svansen ";
            Scales = "och vickar med kroppen så att fjällen glimmar i solen.";
            Console.WriteLine(DName + " " + Tale + " " + Scales + " ");

        }
        public void Eat()
        {
            Eyes = "ser mat och ";
            Nose = "tuggar i sig maten.";
            Console.WriteLine(DName + " " + Eyes + " " + Nose + " ");

        }

    }
}
