using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ornek03
{
    public partial class Form1 : Form
    {
        //Global alan
        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();
        public Form1() //ctor
        {
            InitializeComponent();

            //comboBoxSinifSecimi.Items.AddRange(SiniflarListesi.ToArray());
            foreach (var item in SiniflarListesi)
            {
                comboBoxSinifSecimi.Items.Add(item);
            }
            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            dateTimePickerDTarihi.TabIndex = 2;
            comboBoxSinifSecimi.TabIndex = 3;
            btnOgrenciEkle.TabIndex = 4;

            groupBoxSecmeliDersler.Enabled = false;

            //CheckOnClick tıkladığın an listedeki checkbox tiklenicek.
            checkedListBoxSecmeli.CheckOnClick = true;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = dateTimePickerDTarihi.Value
                };
                //if (comboBoxSinifSecimi.SelectedIndex==-1)
                //{
                //    MessageBox.Show("Lütfen sınıf seçiniz");
                //}
                //else
                //{

                //}
                if (AsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci A sınıfına zaten kayıt olmuş!");
                }
                else if (BsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci B sınıfına zaten kayıt olmuş!");
                }
                else if (comboBoxSinifSecimi.SelectedIndex >= 0) //indexler sıfırdan başladığı için >=0 olmalıdır.
                {
                    //öğrencinin sınıfı comboBoxtan gelen seçili değer olacak.
                    ogr1.Sinifi = comboBoxSinifSecimi.SelectedItem.ToString();

                    //Artık öğrenciyi listeye eklemeliyiz.
                    switch (comboBoxSinifSecimi.SelectedIndex)
                    {
                        case 0: // A Sınıfıdır
                            if (AsinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {

                                ASinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sisteminde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;

                        case 1: // B Sınıfıdır
                            if (BsinifindaAyniOgrencidenVarMi(ogr1) == false )
                            {

                                BSinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sisteminde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;

                        default:
                            break;
                    }

                    //Ogrenci secmeli ders alıyorsa listesine seçmeli ders eklensin
                    ogr1.SecmeliDersAliyorMu = checkBoxSecmeliTek.Checked;

                    //alıyorsa

                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }

                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz");
                }


            }

        }

        private bool AsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        private bool BsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        private void KontrolleriTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            comboBoxSinifSecimi.SelectedIndex = -1;
            comboBoxSinifSecimi.Text = "Sınıfınızı seçiniz...";
            dateTimePickerDTarihi.Value = DateTime.Now;
            //CheckedList içinde tiklenmiş olan dersleri unchecked yapmalıyız.
            foreach (int item in checkedListBoxSecmeli.CheckedIndices)
            {
                checkedListBoxSecmeli.SetItemCheckState(item,CheckState.Unchecked);
            }

            //Checked olan dersleri tuttuğumuz listeyi temizlemeliyiz.
            SecilenSecmeliDersler.Clear();

            checkBoxSecmeliTek.Checked = false;
        }

        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.AliceBlue;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.Azure;
            listBoxBSinifi.Items.AddRange(BSinifiOgrencileri.ToArray());

        }

        private void btnHepsiniSagaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in ASinifiOgrencileri)
            {
                BSinifiOgrencileri.Add(item);
                item.Sinifi = "B Sınıfı";
            }
            ASinifiOgrencileri.Clear();
            KontrolleriTemizle();
            ListeleriDoldur();
        }

        private void btnHepsiniSolaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in BSinifiOgrencileri)
            {
                ASinifiOgrencileri.Add(item);
                item.Sinifi = "A Sınıfı";
            }
            BSinifiOgrencileri.Clear();
            KontrolleriTemizle();
            ListeleriDoldur();
        }

        private void btnSagaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgr = listBoxASinifi.SelectedItem as Ogrenci;
            //Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            if (transferEdilecekOgr!=null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "B Sınıfı";
                BSinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
            

        }

        private void btnSolaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgr = (Ogrenci)listBoxBSinifi.SelectedItem;

            if (transferEdilecekOgr != null)
            {
                BSinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "A Sınıfı";
                ASinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxSecmeliTek_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliTek.Checked)
            {
                groupBoxSecmeliDersler.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDersler.Enabled = false;


                foreach (int item in checkedListBoxSecmeli.CheckedIndices)
                {
                    checkedListBoxSecmeli.SetItemCheckState(item, CheckState.Unchecked);
                }
                SecilenSecmeliDersler.Clear();

            }
        }

        private void checkedListBoxSecmeli_SelectedIndexChanged(object sender, EventArgs e)
        {

            SecilenSecmeliDersler.Clear();

            foreach (var item in checkedListBoxSecmeli.CheckedItems)
            {
                //Eğer listesinde bu ders varsa bir daha eklememesi için koşul yazıcaz
                //Chekeditems'ın forech döngüsündeki var item ile bize sunduğu değişken object tipte geliyor.
                //SecilenSecmeliDersler listemiz string tipte bir listedir.
                //Bu nedenle item.ToString() yaptık.
                if (SecilenSecmeliDersler.Count(x=>x==item.ToString())==0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }
                
            }
        }

        private void xmlDisaAktar_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarılacaklar = new List<Ogrenci>();

            //A sınıfında öğrenci varsa
            if (ASinifiOgrencileri.Count>0)
            {
                DisariAktarılacaklar.AddRange(ASinifiOgrencileri);
            }
            //B sınıfında öğrenci varsa
            if (BSinifiOgrencileri.Count > 0)
            {
                DisariAktarılacaklar.AddRange(BSinifiOgrencileri);
            }
            //Oluşacak xml dosyasını nereye kaydedeceği ile ilgili DİYALOG nesnelere ihtiyaç var.
            //xml'i seriliaze edecek işlemler

            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "Ogrenci.xml";


            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //Açılan diyalog penceresinde tamam / ok tuşuna basarsa xml dosyasını oluşturabiliriz.

                //xml'i seriliaze edecek işlemler
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));

                //using bloğu kaynağı kullanır.
                //using (StreamWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                using (TextWriter yazar=new StreamWriter(saveFileDialog1.FileName)) // Kalıtım yaptığımıza baktık.
                {
                    myXMLSerializer.Serialize(yazar,DisariAktarılacaklar);
                }
                MessageBox.Show($"{DisariAktarılacaklar.Count} adet öğrenci xml dosyası olarak aktarıldı.");
            }

        }

        private void xmlIceriAktar_Click(object sender, EventArgs e)
        {
            //Bilgisayarda olan xml dosyasını açmamıza yardımcı olacak DİYALOG nesnesine ihtiyaç vardır.
            KontrolleriTemizle();
            openFileDialog1.Title = "XML Dosyanızı Seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                //var olan dosyayı okumak için okuyucuya ihtiyacımız olur.
                //using (TextReader okuyucu = new StreamReader(openFileDialog1.FileName))
                using (StreamReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {
                    //1.yol(kısa yol)
                    ASinifiOgrencileri=(List<Ogrenci>) myXMLSerializer.Deserialize(okuyucu);
                    //2.yol
                    //ASinifiOgrencileri= myXMLSerializer.Deserialize(okuyucu) as List<Ogrenci>;
                    MessageBox.Show($"{ASinifiOgrencileri.Count} adet kişi içeri aktarıldı");
                    ListeleriDoldur();
                }

            }



        }
    }
}
