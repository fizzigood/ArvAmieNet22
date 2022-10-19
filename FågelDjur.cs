using System;
using System.Collections.Generic;
using System.Text;

namespace ArvAmieNet22
{
    public class FågelDjur : DjurBase //FågelDjur ärver från DjurBase.
    {
        //FågelDjur : DjurBase har utöver DjurBase-egenskaperna också egna egenskaper:
        public string Wings { get; set; }
        public string Egg { get; set; }

        public FågelDjur(
            string DType, 
            string DName,
            int Legs,
            string Eyes,
            string Nose,
            string Feet,
            string Sound) //Constructor/krav från DjurBase.
            : base(
                  DType, 
                  DName, 
                  Legs, 
                  Eyes, 
                  Nose, 
                  Feet, 
                  Sound)
        {
            this.Wings= Wings;
            this.Egg = Egg;
        }
        public void Fly()
        {
            Wings = "flaxar med vingarna och lyfter!";
            Console.WriteLine(DName + " " + Wings);

        }
        public void LayEgg()
        {
            Egg = "ruvar i boet.";
            Console.WriteLine(DName + " " + Egg + " ");
        }

    }

}
