using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRATİK01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci(13639,"Burak","TAN","Bahçelievler");
            Console.WriteLine("Uygulamamıza Hoşgeldiniz Yapmak İstediğiniz İşlemi Seçiniz...");
           

            while (true)
            {
                int secim = Convert.ToInt32(Console.ReadLine());
                İslemler();

                if (secim == 1)
                {
                    ogrenci.OgrenciBilgileriniGoster();
                    break;

                }
                else if (secim ==2)
                {
                    Console.WriteLine("Vize Notunuzu Girin");
                    ogrenci.vize1=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci Vize Notunuzu Giriniz");
                    ogrenci.vize2=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Final Notunuzu Giriniz");
                    ogrenci.final = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ortalamanız = " + ogrenci.OgrenciOrtalaması());  
                    break;

                }
                else if (secim == 3)
                {
                    ogrenci.OkulAdi();
                    break;
                }
                else if (secim==4)
                {
                    Console.WriteLine("İyi Günler Tekrar Bekleriz....");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş....");
                    break;
                }

            }
            Console.ReadLine();


        }
        static void İslemler()
        {
            Console.WriteLine("1-Öğrenci Bilgilerini Göster\n2-Öğrenci Ortalamasını Göster\n3-Öğrenci Okulunu Göster\n4-Çıkış Yap ");
        }
    }
}
