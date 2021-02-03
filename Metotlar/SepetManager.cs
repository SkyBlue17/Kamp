using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi +" - "+ urun.Fiyati);
        }

        public void Ekle2(string urunAdi,string urunTuru,int urunFiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : "+urunAdi);
        

        }
    }
}
