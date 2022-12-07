using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregledovalnikOglasov1
{
    internal class CarItem
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Distance { get; set; }
        public string Fuel { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }
        public string ImageSrc { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return "Znamka: " + Brand + "\nLetnik: " + Year + "\nKilometri: " + Distance + "\nGorivo: " + Fuel + "\nCena: " + Price + "\nOpis: " + Details;
        }
    }
}
