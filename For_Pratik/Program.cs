using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace For_Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran For döngüsü ile yapılmış Console örneği:
            //int tektoplam = 1;
            //int ciftoplam = 1;
            //for (int i= 0; i<10;i++)
            //{
            //    try
            //    {
            //        {
            //            Console.WriteLine("Sayı Giriniz");
            //            int sayi = Convert.ToInt32(Console.ReadLine());

            //            if (sayi % 2 == 0)
            //            {
            //                ciftoplam *= sayi;

            //            }
            //            else
            //            {
            //                tektoplam *= sayi;


            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("HATALI GİRİŞ !");
            //        break;
            //    }

            //}
            //Console.WriteLine("Çift Sayıların Toplamı = " + ciftoplam);
            //Console.WriteLine("Tek Sayıların Toplamı= " + tektoplam);
            //Console.ReadLine();





            //Girilen bir metnin alt alta yazdırılmasını sağlama:

            //Console.WriteLine("Cümle Yazın");
            //string cumle = Console.ReadLine();
            //for(int i=0;i<cumle.Length;i++)
            //{
            //    Console.WriteLine(cumle[i]);    
            //}

            //Console.ReadLine();






            //For Döngüsü kullanarak a’ dan z’ ye kadar olan harfleri ekranda gösteren örnek:

            //  for (char c='a';c<='z';c++)
            //{
            //    Console.Write(c + " ") ;

            //}Console.ReadLine();



            //For Döngüsü kullanarak Kullanıcıdan aldığı 10 adet sayıyı toplayarak ekranda gösteren uygulama.

            //int toplam = 0;
            //for(int i=0;i<10;i++)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı Girin");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        toplam += sayi;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Sayı RAKAMLARDAN OLUŞUR ");
            //        break;
            //    }


            //}
            //Console.WriteLine("Girdiğiniz Sayıların Toplam Değeri = " + toplam);
            //Console.ReadLine();




            //For Döngüsü kullanılarak Kullanıcıdan 3 adet isim alarak başına numaraların da ekleyerek ekranda yazdıran örnek:
            //Console.WriteLine("İsminizi Girin");
            //string isim = Console.ReadLine();
            //for (int i=0;i<=3;i++)
            //{
            //    Console.WriteLine("{0} : {0}" + i , isim);
            //} Console.ReadLine();

            // İÇ İÇE FOR DÖNGÜSÜ KULLANIMI 

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write(i+"\t");
            //    for (int j=1;j <= 5; j++)
            //    {
            //        Console.Write(i*j+"\t");
            //    }
            //    Console.Write("\n");
            //}Console.ReadLine();



            //for (int i=1;i<=5;i++)
            //{
            //    Console.Write(i + "\t");

            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i * j + "\t");
            //    }
            //    Console.WriteLine();



            //}
            //Console.ReadLine();


            //int a=1;
            //while (a<=10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //Console.ReadLine();

            //int a = 100;
            //while (0<=a)
            //{
            //    Console.WriteLine(a);
            //    a -= 2;

            //} Console.ReadLine();

            //****************************************** ÇARPIM TABLOSU 10x10 *******************************

            //for (int i=1;i<=10;i++)
            //{
            //    for(int j=1;j<=10;j++)
            //    {
            //        Console.WriteLine(i+"x"+j+"=" +(i*j));
            //    }
            //} Console.ReadLine();
            //    string username = "buraktan";
            //    string password = "burak123";
            //    int hak = 0;
            //DON1:
            //    while (hak < 3 )
            //    {

            //        try
            //        {

            //            Console.WriteLine("Kullanıcı Adını Giriniz");
            //            string name = Console.ReadLine();
            //            if (username == name)
            //            {

            //                Console.WriteLine("Şifrenizi Giriniz");
            //                string pass = Console.ReadLine();
            //                if (password == pass)
            //                {
            //                    Console.WriteLine("Başarılı Giriş");
            //                    break;


            //                }
            //                else
            //                {
            //                    Console.WriteLine("Hatalı Giriş");

            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hatalı Giriş");
            //            }
            //            hak++;
            //        }
            //        catch (Exception)
            //        {

            //            Console.WriteLine("HATALI GİRİŞ !");
            //        }
            //    }
            //    if (hak == 3)
            //    {
            //        Console.WriteLine("Hakkınız Bitti \n 5 Saniye Sonra Tekrar Deneyiniz");
            //        Thread.Sleep(5000);
            //        goto DON1;

            //    }
            //    Console.ReadLine();
            //int hak = 1;
            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı Adınızı Girin");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi Girin");
            //    string password = Console.ReadLine();

            //    if (username == "buraktan" && password == "burak123")
            //    {
            //        Console.WriteLine("Giriş Başarılı ");
            //        break;
            //    }
            //   if (hak<3)
            //    {
            //        Console.WriteLine("Hatalı Giriş");
            //        hak++;
            //    }
            //   else if (hak==3)
            //    {
            //        Console.WriteLine("Giriş Hakkınız Kalmadı !");
            //    }

            //} Console.ReadLine();
            

        }



    }
}
