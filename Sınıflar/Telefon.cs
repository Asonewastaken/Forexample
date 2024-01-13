using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Telefon
    {
        //Parametrelerim
        public string isim;
        public string soyisim;
        public string telefon_markası;
        public string isletim_sistemi;
        public int ram_boyutu;
        public int telefon_fiyatı;
        public int bakiye;

        //Metotlarım
        public Telefon(string _isim, string _soyisim, string _telefon_markaası, string _isletim_sistemi, int _ram_boyutu, int _telefon_fiyatı)
        {
            isim = _isim;
            soyisim = _soyisim;
            telefon_markası = _telefon_markaası;
            isletim_sistemi = _isletim_sistemi;
            ram_boyutu = _ram_boyutu;
            telefon_fiyatı = _telefon_fiyatı;
        }
        public void KisiselBilgiler()
        {
            Console.WriteLine("İsminiz: " + isim);
            Console.WriteLine("Soyisminiz: " + soyisim);
        }

        public void TelefonBilgiler()
        {
            Console.WriteLine("Telefonun Markası: " + telefon_markası);
            Console.WriteLine("Telefonun İşletim Sistemi: " + isletim_sistemi);
            Console.WriteLine("Telefonun Ram Kapasitesi: " + ram_boyutu);
            Console.WriteLine("Telefonun Fiyatı: " + telefon_fiyatı);
        }

        public void Alınabilirlik()
        {
            if (bakiye >= telefon_fiyatı)
            {
                Console.WriteLine("Bütçeniz bu telefon için uygun. Bu telefonu satın alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Bütçeniz bu telefon için uygun değil. Bu telefonu satın alamazsınız.");
            }
        }
    }
}
