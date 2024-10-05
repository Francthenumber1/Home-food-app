using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFood
{


    public class ChangeLog
    {
        public string PropertyName { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
    public class Rezepten
    {
       
        public Image Image { get; set; } // New property for storing the image
        public int Rezept_ID { get; set; }
        public string RezeptName { get; set; }
        public int Portionen { get; set; }
        public string Naehrwerte { get; set; }
        public string RezeptType { get; set; }
        public string Dietarypreferences { get; set; }
        public string Anweisungen { get; set; }
        public string Image_Description { get; set; }
        public List<Zutat> Zutaten { get; set; } = new List<Zutat>();
    }


}
