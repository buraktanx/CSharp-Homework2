using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik01
{
    internal class ogrenci
    {
        public string isim;
        public string soyisim;
        private int Yazili1;
        private int Yazili2;
        private int Sozlu1;

        private double ortalama;


        public int _Yazili1
        {
            get { return Yazili1; }
            set
            {
                int not;
                if (value > -1 && 101 < value)
                {
                    Yazili1 = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Not Değeri Hatalı Girilmiştir.");
                        Console.WriteLine("Not :");
                        not = Convert.ToInt32(Console.ReadLine());
                    } while (not<0 || 100 < not);
                    Yazili1 = not;
                }
            }


        }
        public int _Yazili2
        {
            get { return Yazili2; }
            set
            {
                int not;
                if (value > -1 && 101 < value)
                {
                    Yazili2 = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Not Değeri Hatalı Girilmiştir.");
                        Console.WriteLine("Not :");
                        not = Convert.ToInt32(Console.ReadLine());
                    } while (not < 0 || 100 < not);
                    Yazili2 = not;
                }
            }


        }
        public int _Sozlu1
        {
            get { return Sozlu1; }
            set
            {
                int not;
                if (value > -1 && 101 < value)
                {
                    Sozlu1 = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Not Değeri Hatalı Girilmiştir.");
                        Console.WriteLine("Not :");
                        not = Convert.ToInt32(Console.ReadLine());
                    } while (not < 0 || 100 < not);
                    Sozlu1=not;
                }
            }


        }
        public double _Ortalama()
        {
          
           
             return (Yazili1 + Yazili2 + Sozlu1) / 3;
                
            
        }
        public void Yaz()
        {
            Console.WriteLine("Ad : " +isim);
            Console.WriteLine("Soyad :" +soyisim);
            Console.WriteLine("Birinici Yazılı Sınav :" +Yazili1);
            Console.WriteLine("İkinci Yazılı Sınav :" +Yazili2);
            Console.WriteLine("Sözlü Sınav : " +Sozlu1);
            Console.WriteLine("Ortalamanız : " +_Ortalama());
        }




    }
}
