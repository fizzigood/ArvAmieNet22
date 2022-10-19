using System;

namespace ArvAmieNet22
{
    public class DjurBase
    {
        //Nedan följer fem egenskaper(properties) som alla Djur delar med varandra;
        public string DType { get; set; } //DType = Vilket typ av Djur
        public string DName { get; set; } //Vad den har för tilltalsnamn
        public int Legs { get; set; } //Hur många ben
        public string Eyes { get; set; } //Information om djurets synegenskaper
        public string Nose { get; set; } //Information om djurets nos - utseende, egenskaper osv
        public string Feet { get; set; } //Hur djurets fötter ser ut (om simhud, klor osv)
        public string Sound { get; set; } //Djurets läte

        public DjurBase(string DType, 
                        string DName, 
                        int Legs, 
                        string Eyes, 
                        string Nose, 
                        string Feet, 
                        string Sound) //Constructor av Djurbase med krav på in-paramentrar i () som måste skickas med
        {
            this.DType = DType; //"this" specifierar/pekar på variabeln som är inuti klassen
            this.DName = DName; //den utan "this" är variabeln inuti constructorn
            this.Legs = Legs;
            this.Eyes = Eyes;
            this.Nose = Nose;
            this.Feet = Feet;
            this.Sound = Sound;

        }

        //Basklassens metoder:
        public void Introduction()
        {
            Console.WriteLine("Hej! Jag är en " + DType + " och jag heter "+ DName+".");
        }
        public void WalkAround()
        {
            Console.WriteLine(DName + " går just nu runt och kikar. ");
        }
        public void MakeSound() 
        {
            Console.WriteLine(DName + " säger: " + Sound);
        }
        public void Sleep()
        {
            Console.WriteLine(DName + " sover nu sött. ");
        }
        

    }
}