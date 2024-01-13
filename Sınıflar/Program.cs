using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Telefon alici = new Telefon("Ashaf", "Şencan", "Iphone", "IOS", 4, 2500);
            Console.WriteLine("Uygulamama hoşgeldiniz. Lütfen yapmak istediğiniz işlemi seçiniz:");
            islemleriGoster();

            while (kontrol)
            {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        alici.KisiselBilgiler();
                        break;

                    case "2":
                        alici.TelefonBilgiler();
                        break;

                    case "3":
                        Console.Write("Bakiyenizi Giriniz: " );
                        alici.bakiye = Convert.ToInt32(Console.ReadLine());
                        alici.Alınabilirlik();
                        break;
                        
                    case "4":
                        kontrol = false;
                        break;
                       

                }
            }
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1- Kişisel Bilgileri Göster");
            Console.WriteLine("2- Telefon Bilgilerini Göster");
            Console.WriteLine("3- Bütçenizi girin");
            Console.WriteLine("4- Çıkış yap");

        }
    }
}
