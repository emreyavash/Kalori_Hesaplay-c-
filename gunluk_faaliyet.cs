using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalori_hesaplama
{
    class gunluk_faaliyet
    {
        private double g_sutuketimi;
        private double g_gunlukadim;
        private int g_ogunsayisi;
        private double g_proteintuketimi;
        public double Sutuketimi
        {
            get { return g_sutuketimi; }
            set { g_sutuketimi = Math.Abs(value); }

        }
        public double Gunlukadım
        {
            get { return g_gunlukadim; }
            set { g_gunlukadim = Math.Abs(value); }

        }
        public int Ogunsayisi
        {
            get { return g_ogunsayisi; }
            set { g_ogunsayisi = Math.Abs(value); }
        }
        public double Proteintuketimi
        {
            get { return g_proteintuketimi; }
            set { g_proteintuketimi = Math.Abs(value); }
        }
            
    }
}
