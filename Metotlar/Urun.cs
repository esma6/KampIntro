using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //urunu tanimlayan veri tiplerim bunların tamamina urun diyorum
        public int Id { get; set; } // PROPERTY 
        public string Adi { get; set; } // HEPSİ BİR PROPERTY
        public double Fiyati { get; set; } // PROPERTY =özellik
        public string Aciklama { get; set; }// property aciklama özelligi

        public int StokAdedi { get; set; }

    }
}
