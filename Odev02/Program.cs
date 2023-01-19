using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinsiyetinizi Girin");
            Console.WriteLine("Lütfen 'Erkek' veya 'Kadın' Olarak Giriş Yapınız");
            string cinsiyet = Console.ReadLine();


            switch (cinsiyet)
            {
                case "Erkek":

                    Console.WriteLine("Yaşınızı Girin");
                    int yas = Convert.ToInt32(Console.ReadLine());

                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaş Tutarınızı Girin");
                        int maas = Convert.ToInt32(Console.ReadLine());
                        maas = maas * 10;
                        Console.WriteLine(("Alacağınız Toplam Tutar :") + maas);
                        Console.WriteLine("Emekliliğiniz Hayırlı Olsun");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Maaş Tutarınızı Girin");
                        int maas = Convert.ToInt32((Console.ReadLine()));   
                        Console.WriteLine("Çalıştığınız Gün Sayısını Giriniz");
                        int gunsayısı = Convert.ToInt32(Console.ReadLine());

                        if (gunsayısı >= 6000)
                        {
                            Console.WriteLine("Alacağınız Toplam Tutar :" + (maas * 11));
                            Console.WriteLine("Emekliliğiniz Hayırlı Olsun");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Emekli Değilsiniz");
                        }
                        Console.ReadLine();


                        
                    }
                    break;

                case "Kadın":
                    Console.WriteLine("Yaşınızı Girin");
                    int yas1 = Convert.ToInt32(Console.ReadLine());

                    if (yas1 >= 58)
                    {
                        Console.WriteLine("Maaş Tutarınızı Girin");
                        double maas1 = Convert.ToDouble(Console.ReadLine());
                        maas1 = maas1 * 10;
                        Console.WriteLine(("Alacağınız Toplam Tutar :") + maas1);
                        Console.WriteLine("Emekliliğiniz Hayırlı Olsun");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Maaş Tutarınızı Girin");
                        double maas1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Çalıştığınız Gün Sayısını Giriniz");
                        double gunsayısı1 = Convert.ToDouble(Console.ReadLine());


                        if (gunsayısı1 >= 5600)
                        {
                            Console.WriteLine("Alacağınız Toplam Tutar :" + (maas1 * 11));
                            Console.WriteLine("Emekliliğiniz Hayırlı Olsun");

                        }
                        else
                        {
                            Console.WriteLine("Emekli Değilsiniz");
                        }

                        Console.ReadLine();
                    }


                    break;
                   

            }
        }
    }
}
