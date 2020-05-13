using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalori_hesaplama
{
    public partial class diyet_listesi : Form
    {
        public diyet_listesi()
        {
            InitializeComponent();
        }

        private void diyet_listesi_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.Diyet
            if (adiyet.Checked == true)
            {
                List<string> diyet1 = new List<string>();
                diyet1.Add("Kilo Vermek için");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Sabah(8:00-9:00)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("2-3 Dilim tam tahıllı ekmek");
                diyet1.Add("1 Dilim peynir ya da 1 Adet haşlanmış yumurta");
                diyet1.Add("5 Adet zeytin");
                diyet1.Add("Domates ve maydanoz");
                diyet1.Add("2 Adet kuru erik veya 2 Adet kuru kayısı");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Ara Öğün(10:30-11:30)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("1 Bardak tarçınlı süt ve 10 Adet Badem");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Öğle(12:30-13:30)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("2 Dilim tam tahıllı ekmek");
                diyet1.Add("6-7 Yemek kaşığı etsiz sebze yemeği");
                diyet1.Add("Salata veya 3-4 Yemek kaşığı yoğurt");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Ara Öğün(15:00-16:00)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("1 Fincan yeşil çay");
                diyet1.Add("3 Adet keten tohumlu diyet bisküvi");
                diyet1.Add("1 Adet elma veya 2 Adet mandalina");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Akşam(18:00-19:00)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("2 Dilim tam tahıllı ekmek");
                diyet1.Add("5-6 tane köfte veya 6-7 yemek kaşığı kıymalı sebze yemeği ve salata");
                diyet1.Add("1 Bardak kadar Kefir");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("Mideyi Rahatlatma Saati(20:00-20:30)");
                diyet1.Add("---------------------------------------------------------");
                diyet1.Add("1 Fincan tarçınlı elmalı çay");
                diyet1.Add("1 Tane grissini");
                diyet1.Add("1 Yemek kaşığı kuru üzüm ya da biraz yaban mersini");
                diyet1.Add("---------------------------------------------------------");
                foreach (string diyet in diyet1)
                {
                    listBox1.Items.Add(diyet);
                }
               
                }





                //2.Diyet
                if (bdiyet.Checked == true)
                {
                    List<string> diyet2 = new List<string>();
                    diyet2.Add("Kilo Almak için");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Sabah");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("2 Adet yumurtalı bol kaşarlı ve tereyağlı omlet");
                    diyet2.Add("3 Dilim çekirdekli ekmek");
                    diyet2.Add("1 Bardak taze sıkılmış portakal suyu");
                    diyet2.Add("Maydanoz ve 3 tatlı kaşığı ev reçeli");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Ara Öğün");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("1 Bardak Süt");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Öğle");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Domatesli Tavuk");
                    diyet2.Add("1 Porsiyon tereyağlı pilav");
                    diyet2.Add("Zeytinyağlı Havuç");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Ara Öğün");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("1 Bardak ayran ile 1 Avuç tuzlu badem");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Akşam");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("1 Kase mercimek çorbası ");
                    diyet2.Add("Orta boy peynirli domatesli pizza");
                    diyet2.Add("Domates Salatası");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("Gece");
                    diyet2.Add("---------------------------------------------------------");
                    diyet2.Add("1 Avuç kabak çekirdeği");
                    diyet2.Add("Erik pestili ve 1 bardak boza");
                    diyet2.Add("---------------------------------------------------------");
                    foreach (string adiyet in diyet2)

                    {
                        listBox1.Items.Add(adiyet);
                    }




                }

            //3. Diyet
            if (cdiyet.Checked==true)
            {
                List<string> diyet3 = new List<string>();
                diyet3.Add("Ketojonik diyet");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("1.Gün(Öğle Öğünü 12:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Üç yumurta ile hazırlanmış tereyağlı omlet (bir kaşık tereyağı)");
                diyet3.Add("Bir kase buharda brokoli üzerine 2 kaşık zeytinyağı ve yarım limon");              
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Ara Öğün (15:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Bir kase tam yağlı ev yoğurdu");
                diyet3.Add("50 gram yulaf ezmesi");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Akşam Öğünü (18:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("300 gram sığır kıyması ile yapılan fırında köfte");
                diyet3.Add("Bir kase mevsim yeşilliği üzerine 2 kaşık zeytinyağı ve yarım limon");
                diyet3.Add("Bir avuç yer fıstığı");
                diyet3.Add("---------------------------------------------------------");

                diyet3.Add("2.Gün(Öğle Öğünü 12:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Üç yumurta ile hazırlanmış tereyağlı omlet (iki kaşık tereyağı)");
                diyet3.Add("Bir kase buharda karnabahar üzerine 2 kaşık zeytinyağı ve yarım limon");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Ara Öğün (15:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Bir bardak kefir");
                diyet3.Add("5 adet tüm ceviz");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("Akşam Öğünü (18:00)");
                diyet3.Add("---------------------------------------------------------");
                diyet3.Add("350 gram hindi göğüs eti ile yapılan ızgara");
                diyet3.Add("Bir kase mevsim yeşilliği üzerine 2 kaşık zeytinyağı ve yarım limon");
                diyet3.Add("Bir avuç yer fıstığı");
                diyet3.Add("---------------------------------------------------------");
                foreach (string bdiyet in diyet3)

                {
                    listBox1.Items.Add(bdiyet);
                }
            }



            if (ddiyet.Checked==true)
            {
                List<string> diyet4 = new List<string>();
                    diyet4.Add("DETOKS VE ANTİENFLAMATUAR SMOOTHIE");
                diyet4.Add("---------------------------------------------------------");
                diyet4.Add("Malzemeler");
                
                diyet4.Add("2 dilim ananas");
                diyet4.Add("3 donmuş olgun muz");
                diyet4.Add("1 pişirilmiş, soyulmuş kırmızı pancar");
                diyet4.Add("1 bardak donmuş çilek");
                diyet4.Add("Biraz süt");
                diyet4.Add("Hazırlanışı");
                diyet4.Add("Tüm malzemeleri blender’dan geçirin.");
                diyet4.Add("---------------------------------------------------------");
                diyet4.Add("TOK TUTAN SMOOTHIE");
                diyet4.Add("---------------------------------------------------------");
                diyet4.Add("Malzemeler");
                diyet4.Add("1 küçük bardak badem sütü/light süt/laktozsuz süt");
                diyet4.Add("1 muz");
                diyet4.Add("1/2 çay bardağı kaju");
                diyet4.Add("1 çay kaşığı taze zencefil");
                diyet4.Add("1 küçük havuç");
                diyet4.Add("2 - 3 su bardağı ıspanak yaprağı");
                diyet4.Add("Hazırlanışı");
                diyet4.Add("Tüm malzemeleri blender’dan geçirin.");
                diyet4.Add("---------------------------------------------------------");
                diyet4.Add("YAĞ YAKICI SMOOTHIE");
                diyet4.Add("---------------------------------------------------------");
                diyet4.Add("Malzemeler");
                diyet4.Add("2 dilim ananas");
                diyet4.Add("1/2 su bardağı yağsız yoğurt");
                diyet4.Add("1/2 su bardağı süt");
                diyet4.Add("Hazırlanışı");
                diyet4.Add("Hepsini blender’dan geçirin.");
                diyet4.Add("---------------------------------------------------------");
                foreach (string cdiyet in diyet4)

                {
                    listBox1.Items.Add(cdiyet);
                }
            }
        
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Karın hareketleri
            if (mekikradiobtn.Checked == true)
            {
                mekikpic.Visible = true;
                legpic.Visible = false;
                plankpic.Visible = false;
                
            }
            if (legradiobtn.Checked == true)
            {
                legpic.Visible = true;
                mekikpic.Visible = false;
                plankpic.Visible = false;
            }
            if (plankradiobtn.Checked == true)
            {
                plankpic.Visible = true;
                mekikpic.Visible = false;
                legpic.Visible = false;
                

            }
            //Üst vücut hareketleri
            if (sınavradiobtn.Checked == true)
            {
                sınavpic.Visible = true;
                barfikspic.Visible = false;
                dipspic.Visible = false;
            }
            if (barfiksradiobtn.Checked == true)
            {
                barfikspic.Visible = true;
                sınavpic.Visible = false;
                dipspic.Visible = false;
            }
            if (dipsradiobtn.Checked == true)
            {
                dipspic.Visible = true;
                barfikspic.Visible = false;
                sınavpic.Visible = false;
            }
            //Bacak hareketleri

            if (squatradiobtn.Checked == true)
            {
               squatpic.Visible = true;
                lungespic.Visible = false;
                stepupspic.Visible = false;
            }
            if (lungesradiobtn.Checked == true)
            {               
                lungespic.Visible = true;
                squatpic.Visible = false;
                stepupspic.Visible = false;
            }

            if (stepradiobtn.Checked == true)
            {
                stepupspic.Visible = true;
                lungespic.Visible = false;
                squatpic.Visible = false;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
