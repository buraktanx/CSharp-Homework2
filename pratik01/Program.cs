using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ogrenci student = new ogrenci();
            student._Sozlu1 = 50;
            student._Yazili1 = 101;
            student._Yazili2 = 101;
            student.isim = "Burak";
            student.soyisim = "Tan";

           
            student.Yaz();
            Console.ReadLine();
        }
    }
}
