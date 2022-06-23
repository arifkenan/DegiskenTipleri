using System;

namespace FirstConsole
{

    public class Program
    {

        public static void Main()
        {
            #region Degisken Tanimlama
            //Sayisal Veri Tipleri :  int,long,short,float,decimal,double
            int yas = 25;
            bool cinsiyet = true;
            int kilo = 80;
            string ad = "Arif";
            DateTime dogumtarihi = new DateTime(1997,2,7);
            string takim = "Galatasaray";
            string favfood = "Makarna";
            string dreams = "Yat sahibi olmak";
            string tc = "16298317850";
            string gsm = "5324164841";

            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Yaşınız: " + yas);
            if (cinsiyet == true)
                Console.WriteLine("Cinsiyetiniz: Erkek");
            else { Console.WriteLine("Cinsiyetiniz: Kadın"); };
            
            Console.WriteLine("Kilonuz: " + kilo);
            
            Console.WriteLine("Doğum tarihiniz: " + dogumtarihi);
            Console.WriteLine("Tuttuğunuz takım: " + takim);
            Console.WriteLine("En sevdiğiniz yiyecek: " + favfood);
            Console.WriteLine("Hayaliniz: " + dreams);
            Console.WriteLine("Kimlik numaranız: " + tc);
            Console.WriteLine("Telefon numaranız: " + gsm);

            #endregion


        }
    }
}