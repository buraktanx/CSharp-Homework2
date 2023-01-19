using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRATİK01
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
       public int vize1;
        public int vize2;
        public int final;
        private string okulAdi;

        public Ogrenci(int _ogrencino,string _isim,string _soyisim,string _okuladi)
        {
            ogrenciNo= _ogrencino;  
            isim= _isim;    
            soyisim= _soyisim;
            okulAdi= _okuladi;

        }
            


        public void OgrenciBilgileriniGoster()
        {
            Console.WriteLine("Öğrencinin Numarası = " + ogrenciNo);
            Console.WriteLine("Öğrencinin Adı = " + isim);
            Console.WriteLine("Öğrencinin Soyadı = " + soyisim);
            Console.WriteLine("Öğrencinin İlk Vize Notu = " + vize1);
            Console.WriteLine("Öğrencinin İkinci Vize Notu = "+ vize2);
            Console.WriteLine("Öğrencinin Final Notu = " + final);
            Console.WriteLine("Öğrenci Okul İsmi = " + okulAdi);

        }

        public double OgrenciOrtalaması()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }
        public void OkulAdi()
        {
            Console.WriteLine("Öğrencinin Okul İsmi = "+okulAdi);
        }

    }

}
