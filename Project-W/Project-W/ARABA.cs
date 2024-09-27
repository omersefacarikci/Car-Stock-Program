using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_W
{
    public class ARABA
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yıl { get; set; }
        public int Km { get; set; }
        public string Motor { get; set; }
        public string Beygir { get; set; }
        public string Yakıt { get; set; }
        public string Vites { get; set; }
        public string Renk { get; set; }
        public string AracResim1 { get; set; }
        public string AracResim2 { get; set; }
        public string AracResim3 { get; set; }
        public string AracResim4 { get; set; }
        public string AracResim5 { get; set; }
        public string AracResim6 { get; set; }
        public string AracResim7 { get; set; }
        public string AracResim8 { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
