using System;

namespace ClassDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Ayakkabı";
            urun1.UrunMadde = "Deri";
            urun1.StokDurumu = 100;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Ceket";
            urun2.UrunMadde = "Yün";
            urun2.StokDurumu = 35;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "T-Shirt";
            urun3.UrunMadde = "Polyester";
            urun3.StokDurumu = 55;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (var urunD in urunler)
            {
                Console.WriteLine(urunD.UrunAdi + " - " + urunD.UrunMadde + " - " + urunD.StokDurumu);
            }
        }
        class Urun
        {
            public string UrunAdi { get; set; }
            public string UrunMadde { get; set; }
            public int StokDurumu {get; set; }
        }
    }

}
