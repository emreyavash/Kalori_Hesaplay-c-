using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalori_hesaplama
{
    
    class kişisel_bilgi:gunluk_faaliyet
    {
        string ad;
        string soyad;
        int yas;
        double boy;
        double kilo;

        public string Adı
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
            
        }
        public string Soyadı
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public int Yası
        {
            get { return yas; }
            set { yas = Math.Abs(value); }

        }
       public double Boyu
        {
            get { return boy; }
            set { boy = Math.Abs(value); }
        }
        public double Kilosu
        {
            get { return kilo; }
            set { kilo = Math.Abs(value); }
        }
        

    }
}
