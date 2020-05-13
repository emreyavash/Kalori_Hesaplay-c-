using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace kalori_hesaplama
{
    /****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............:Emre Yavaş       
** ÖĞRENCİ NUMARASI.......:B181200035
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            kişisel_bilgi kb = new kişisel_bilgi();
            
            kb.Adı = adtxtbox.Text;
            kb.Soyadı = soyadtxtbox.Text;
            kb.Yası = Convert.ToInt32(yastxtbox.Text);
            kb.Boyu = Convert.ToDouble(boytxtbox.Text);
            kb.Kilosu = Convert.ToDouble(kilotxtbox.Text);
            kb.Gunlukadım = Convert.ToDouble(adımtxtbox.Text);
            kb.Ogunsayisi = Convert.ToInt32(oguntxtbox.Text);
            kb.Sutuketimi = Convert.ToDouble(sutxtbox.Text);
            kb.Proteintuketimi = Convert.ToDouble(proteintxtbox.Text);

            //protein mikratı hesaplama formülü
            double proteintuketim;

            proteintuketim = Convert.ToDouble(kilotxtbox.Text)*0.8;
           
           
            
            
            
            // kadın ve erkek kalori hesaplama formülü
            double erkek;
            erkek = 66 + 13.7 * (Convert.ToDouble(kilotxtbox.Text)) + 5 * (Convert.ToDouble(boytxtbox.Text)) - 6.8 * (Convert.ToInt32(yastxtbox.Text));

            double kadın;
              kadın=655+9.6* (Convert.ToDouble(kilotxtbox.Text))+1.8 * (Convert.ToDouble(boytxtbox.Text))-4.7* (Convert.ToInt32(yastxtbox.Text));


            

            
           






            listbilgiler.Items.Add("Ad Soyad: "+kb.Adı+" "+kb.Soyadı);
           
            // erkeklerin butonu
            if (radioButton1.Checked == true)
            {
                vucutbilgi.Items.Add("Ad Soyad: " + kb.Adı + " " + kb.Soyadı);
                vucutbilgi.Items.Add("Günlük kilonuzu korumak için kaloriniz: " + erkek);
                vucutbilgi.Items.Add("Günlük kilo vermek için ortalama kaloriniz: " + (erkek - 500));
                vucutbilgi.Items.Add("Günlük kilo almak için ortalama kaloriniz: " + (erkek + 450));
                
                
                //Su tüketimi için switch
                switch (kb.Sutuketimi)
                {
                    case 0:
                        vucutbilgi.Items.Add("Hiç su içmiyorsunuz.Su içmelisiniz.");
                        break;
                    case 1:
                        vucutbilgi.Items.Add("1 Litre su vücudunuz için yeterli değildir.Su içmelisiniz.");
                        break;
                    case 2:
                        vucutbilgi.Items.Add("2 Litre su vücudunuz için yeterli sayılır.Su içmelisiniz.");

                        break;
                    case 3:
                        vucutbilgi.Items.Add("3 Litre su vücudunuz için en iyidir.Su içmelisiniz.");
                        break;
                    case 4:
                        vucutbilgi.Items.Add("4 Litre su vücudunuz için gerekli değildir.Daha az su içiniz.");
                        break;
                    case 5:
                        vucutbilgi.Items.Add("5 Litre su vücudunuz için çok fazladır.Lütfen daha az su içiniz");
                        break;
                  
                    default:
                        vucutbilgi.Items.Add("Lütfen su içmeyi durdunuz.");
                        break;
                }


                //Öğün sayısı için switch
                switch (kb.Ogunsayisi)
                {
                    case 1: vucutbilgi.Items.Add("1 öğün vücudunuz için yeterli değildir.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    case 2:
                        vucutbilgi.Items.Add("2 öğün vücudunuz için idare eder.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    case 3:
                        vucutbilgi.Items.Add("3 öğün vücudunuz için idealdir.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");

                        break;
                    case 4:
                        vucutbilgi.Items.Add("4 öğün vücudunuz için biraz fazladır.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    case 5:
                        vucutbilgi.Items.Add("5 öğün vücudunuz için biraz fazladır.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    case 6:
                        vucutbilgi.Items.Add("6 öğün vücudunuz için fazladır.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    case 7:
                        vucutbilgi.Items.Add("7 öğün vücudunuz için çok fazladır.Diyette iseniz günlük ihtiyaçlarınızı karşılıcak kadar yemek yemelisiniz.");
                        break;
                    default: vucutbilgi.Items.Add("Öğün sayınızı azaltmanız gerekmektedir.Lütfen dikkat ediniz.");
                        break;
                }
                if(5000<= Convert.ToDouble(adımtxtbox.Text) && 8000>= Convert.ToDouble(adımtxtbox.Text))
                {
                     vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Sağlıklı yaşam için ideal adımdır.");

                }
               else if(8000< Convert.ToDouble(adımtxtbox.Text))
                {
                    vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Tebrikler.Sağlıklı bir yaşamınız var.");
                }
               else if(5000>Convert.ToDouble(adımtxtbox.Text))
                {
                    vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Yürüyüş sürelerinizin uzunluğunu ve sıklığını arttırmanız gerekiyor.");
                }

                if (56 <= Convert.ToDouble(proteintxtbox.Text) && 91 >= Convert.ToDouble(proteintxtbox.Text))
                {

                    vucutbilgi.Items.Add("Günlük aldığınız protein miktarı idealdir");
                    vucutbilgi.Items.Add("Günlük almanız gereken ortalama protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }
                else if (56 > Convert.ToDouble(proteintxtbox.Text))
                {

                    vucutbilgi.Items.Add("Günlük aldığınız protein 56 gramdan azdır..! Biraz daha fazla protein tüketiniz.");
                    vucutbilgi.Items.Add("Günlük almanız gereken ortalama protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }
                else if(91 < Convert.ToDouble(proteintxtbox.Text)) 
                {
                  
                    vucutbilgi.Items.Add("Günlük aldığınız protein 91 gramdan fazladır..! Biraz daha az protein tüketiniz.");
                    vucutbilgi.Items.Add("Günlük almanız gereken ortalama protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }

               

                listbilgiler.Items.Add("Yaşı: " + kb.Yası + " Cinsiyeti: " + radioButton1.Text + " Boyu: " + kb.Boyu+" cm"+" Kilosu: " + kb.Kilosu + " Kg");
                listbilgiler.Items.Add("Su Tüketimi: " + kb.Sutuketimi + " Litre " + " Günlük Adım Sayısı: " + kb.Gunlukadım + " Adım"
                    +" Öğün Sayısı: "+kb.Ogunsayisi+" Öğün"+" Günlük Protein Tüketimi: "+kb.Proteintuketimi+" Gram");
                listbilgiler.Items.Add("*************************************************************************************************************************************");
            }
            // kadınların butonu
            else
            {
                vucutbilgi.Items.Add("Ad Soyad: " + kb.Adı + " " + kb.Soyadı);
                vucutbilgi.Items.Add("Günlük kilonuzu korumak için kaloriniz: " + kadın);
                vucutbilgi.Items.Add("Günlük kilo vermek için ortalama kaloriniz: " + (kadın - 450));
                vucutbilgi.Items.Add("Günlük kilo almak için ortalama kaloriniz: " + (kadın + 350));


                //Su tüketimi için switch
                switch (kb.Sutuketimi)
                {
                    case 0:
                        vucutbilgi.Items.Add("Vücudunuz için su tüketiminiz yetersiz, arttırmalısınız.");
                        break;
                    case 1:
                        vucutbilgi.Items.Add("1 Litre su vücudunuzun su ihtiyacını karşılamıyor,daha fazla su tüketmelisiniz.");
                        break;
                    case 2:
                        vucutbilgi.Items.Add("2 litre su vücudunuz için normal düzeydedir fakat biraz daha arttırmak sağlığınız için daha iyi olacaktır.");

                        break;
                    case 3:
                        vucutbilgi.Items.Add("Günlük 3 litre su vücut tipiniz için idealdir.");
                        break;
                    case 4:
                        vucutbilgi.Items.Add("4 litre su vücudunuz için fazladır su tüketiminizi kararında bırakıp azaltmalısınız.");
                        break;
                    case 5:
                        vucutbilgi.Items.Add("5 litre su vücudunuz için tehlikelidir, yaklaşık 2 litre kadar azaltmanız gerekmekte.");
                        break;

                    default:
                        vucutbilgi.Items.Add("Lütfen su içmeyi durdunuz.");
                        break;
                }


                // Öğün Sayısı için switch

                switch (kb.Ogunsayisi)
                {
                    case 1:
                        vucutbilgi.Items.Add("1 öğün vücudunuz için yeterli değildir günde 3 ana öğün yemek yemeniz gerekiyor. Her yemediğiniz öğün vücudunuza yağ olarak dönecektir.");
                        break;
                    case 2:
                        vucutbilgi.Items.Add("2 öğün vücudunuz için yetersizdir sık öğünler yapıp az miktar da yemenizi öneririm.");
                        break;
                    case 3:
                        vucutbilgi.Items.Add("3 öğün vücudunuz için idealdir, aşırı doygunluk hissi olmayacak şekilde yendiğiniz sürece kilo vermenize yardımcı olacaktır.");

                        break;
                    case 4:
                        vucutbilgi.Items.Add("4 ana öğün vücudunuz için fazladır 3 ana öğün bir ara öğün yapmanızı ve ara öğün de meyve tüketmenizi öneririm.");
                        break;
                    case 5:
                        vucutbilgi.Items.Add("5 ana öğün vücudunuz için vücudunuz için fazladır 3 ana öğün 2 ara öğün yapabilirsiniz ara öğünler de hafif şeyler tüketmenizi öneririm.");
                        break;
                    case 6:
                        vucutbilgi.Items.Add("6 ana öğün vücudunuz için çok fazladır ve sizi obezliğe yaklaştırır. 3 ana 2 ara öğün yapmanızı tavsiye ederim");
                        break;
                    case 7:
                        vucutbilgi.Items.Add("7 öğün vücudunuzun ihtiyacı olandan çok fazladır. 3 ana 2 ara öğün yapmanızı öneririm. Bunun dışında yediğiniz her öğün fazla kalori olacaktır.");
                        break;
                    default:
                        vucutbilgi.Items.Add("Öğün sayınızı azaltmanız gerekmektedir.Lütfen dikkat ediniz.");
                        break;
                }

                
                if (5000 <= Convert.ToDouble(adımtxtbox.Text) && 8000 >= Convert.ToDouble(adımtxtbox.Text))
                {
                    vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Sağlıklı yaşam için ideal adımdır.");

                }
                else if (8000 < Convert.ToDouble(adımtxtbox.Text))
                {
                    vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Tebrikler.Sağlıklı bir yaşamınız var.");
                }
                else if (5000 > Convert.ToDouble(adımtxtbox.Text))
                {
                    vucutbilgi.Items.Add("Günlük ortalama adım sayınız: " + Convert.ToDouble(adımtxtbox.Text) + " Adım. " + " Yürüyüş sürelerinizin uzunluğunu ve sıklığını arttırmanız gerekiyor.");
                }

                if (46 <= Convert.ToDouble(proteintxtbox.Text) && 75 >= Convert.ToDouble(proteintxtbox.Text))
                {
                    
                    vucutbilgi.Items.Add("Günlük aldığınız protein miktarı idealdir");
                    vucutbilgi.Items.Add("Günlük almanız protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }
              else  if(46> Convert.ToDouble(proteintxtbox.Text))
                {
                   
                    vucutbilgi.Items.Add("Günlük aldığınız protein 46 gramdan azdır..! Biraz daha fazla protein tüketiniz.");
                    vucutbilgi.Items.Add("Günlük almanız gereken ortalama protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }
             else  if (75 < Convert.ToDouble(proteintxtbox.Text))
                {
                    
                    vucutbilgi.Items.Add("Günlük aldığınız protein 75 gramdan fazladır..! Biraz daha az protein tüketiniz.");
                    vucutbilgi.Items.Add("Günlük almanız gereken ortalama protein miktarı: " + proteintuketim + " || " + " Günlük aldığınız protein miktarı: " + Convert.ToDouble(proteintxtbox.Text));
                    vucutbilgi.Items.Add("*************************************************************************************************************************************");
                }
                listbilgiler.Items.Add("Yaşı: " + kb.Yası + " Cinsiyeti: " + radioButton2.Text+" Boyu: "+kb.Boyu+" cm"+" Kilosu: "+kb.Kilosu+" Kg");
                listbilgiler.Items.Add("Su Tüketimi: " + kb.Sutuketimi + " Litre " + " Günlük Adım Sayısı: " + kb.Gunlukadım + " Adım"
                     + " Öğün Sayısı: " + kb.Ogunsayisi + " Öğün" + " Günlük Protein Tüketimi: " + kb.Proteintuketimi + " Gram");
                listbilgiler.Items.Add("**********************************************************************************************************************************************");
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            adtxtbox.Clear();
            soyadtxtbox.Clear();
            yastxtbox.Clear();
            boytxtbox.Clear();
            kilotxtbox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            adımtxtbox.Clear();
            sutxtbox.Clear();
            proteintxtbox.Clear();
            oguntxtbox.Clear();
            adtxtbox.Focus(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diyet_listesi diyet = new diyet_listesi();

            diyet.Show();
        }
    }
}
