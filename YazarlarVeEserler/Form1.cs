using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazarlarVeEserler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            YazarYukle();
            EserYukle();
            AnasayfaYazarYukle();
        }
        YazarEserDBEntities db = new YazarEserDBEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
           if(  btnEkle.Text=="EKLE") 
            {
                if (!string.IsNullOrEmpty(txtTamAd.Text) && !string.IsNullOrEmpty(txtResimYolu.Text))
                {
                    db.Yazarlars.Add(new Yazarlar()
                    {
                        TamAd = txtTamAd.Text,
                        ResimYolu = txtResimYolu.Text
                    });
                    db.SaveChanges();
                    txtResimYolu.Clear();
                    txtTamAd.Clear();

                }
                
            }
           else if (btnEkle.Text == "GÜNCELLE")
            {
                Yazarlar guncellenecekYazar = (Yazarlar)lstYazarlar.SelectedItem;
                guncellenecekYazar.TamAd= txtTamAd.Text;
                guncellenecekYazar.ResimYolu= txtResimYolu.Text;
                db.SaveChanges();
                EkleCevir();
            }
            YazarYukle();
        }
        
        private void GuncelleCevir()
        {
            if (lstYazarlar.SelectedItem != null)
            {
                btnIptal.Visible = true;
                btnEkle.Text = "GÜNCELLE";
                grpYazar.Text = "Yazar Güncelle";
                Yazarlar guncellenecekYazar = (Yazarlar)lstYazarlar.SelectedItem;
                txtTamAd.Text = guncellenecekYazar.TamAd;
                txtResimYolu.Text = guncellenecekYazar.ResimYolu;
            }
        }
        private void EkleCevir()
        {
            btnIptal.Visible = false;
            btnEkle.Text = "EKLE";
            grpYazar.Text = "Yazar Ekle";
            txtResimYolu.Clear();
            txtTamAd.Clear();
        }

        private void lstYazarlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            GuncelleCevir();

        }

        private void lstYazarlar_KeyDown(object sender, KeyEventArgs e)
        {
            if(lstYazarlar.SelectedItem!=null && e.KeyCode == Keys.Delete)
            {
                Yazarlar silinecekYazar = (Yazarlar)lstYazarlar.SelectedItem;
                db.Yazarlars.Remove(silinecekYazar);
                db.SaveChanges();
                YazarYukle();
            }
        }





        private void YazarYukle()
        {
            List<Yazarlar> yazarlar = db.Yazarlars.ToList();

            lstYazarlar.DataSource = yazarlar;
            lstYazarlar.DisplayMember = "TamAd";
            lstYazarlar.ValueMember = "Id";

            cmbEserYazarlar.Items.Clear();
            cmbEserYazarlar.Items.Add("--Anonim Yazar--");
            foreach (var item in yazarlar)
            {
                cmbEserYazarlar.Items.Add(item);
            }
            cmbEserYazarlar.DisplayMember = "TamAd";
            cmbEserYazarlar.SelectedIndex = 0;
        }
        private void AnasayfaYazarYukle()
        {
            List<Yazarlar> yazarlar = db.Yazarlars.ToList();

            lstYazarlar.DataSource = yazarlar;
            lstYazarlar.DisplayMember = "TamAd";
            lstYazarlar.ValueMember = "Id";

            cmbAnasayfaYazarlar.Items.Clear();
            cmbAnasayfaYazarlar.Items.Add("--Tüm Yazarlar--");
            foreach (var item in yazarlar)
            {
                cmbAnasayfaYazarlar.Items.Add(item);
            }
            cmbAnasayfaYazarlar.DisplayMember = "TamAd";
            cmbAnasayfaYazarlar.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            EkleCevir();
        }

        private void btnEserEkle_Click(object sender, EventArgs e)
        {
            if (btnEserEkle.Text == "EKLE")
            {
                if (!string.IsNullOrEmpty(txtEserBaslik.Text) && !string.IsNullOrEmpty(txtEserIcerik.Text))
                {
                    Eserler eser = new Eserler()
                    {
                        Baslik = txtEserBaslik.Text,
                        Icerik = txtEserIcerik.Text
                    };
                    if (cmbEserYazarlar.SelectedIndex!=0)
                    {
                        eser.Yazarlar = (Yazarlar)cmbEserYazarlar.SelectedItem;
                    }
                    db.Eserlers.Add(eser);
                    db.SaveChanges();
                    txtEserIcerik.Clear();
                    txtEserBaslik.Clear();
                    cmbEserYazarlar.SelectedIndex = 0;

                }
               
            }
            else if (btnEserEkle.Text == "GÜNCELLE")
            {
                Eserler guncellenecekEser = (Eserler)lstEserler.SelectedItem;
                guncellenecekEser.Baslik = txtEserBaslik.Text;
                guncellenecekEser.Icerik = txtEserIcerik.Text;
                if (cmbEserYazarlar.SelectedIndex == 0)
                {
                    guncellenecekEser.YazarId = null;
                }
                else
                {
                    guncellenecekEser.YazarId = ((Yazarlar)cmbEserYazarlar.SelectedItem).Id;
                }
                db.SaveChanges();
                EserEkleCevir();
            }
            EserYukle();
            //else if (btnEserEkle.Text == "GÜNCELLE")
            //{
            //    Eserler guncellenecekEser = (Eserler)lstEserler.SelectedItem;
            //    guncellenecekEser.Baslik = txtEserBaslik.Text;
            //    guncellenecekEser.Icerik = txtEserIcerik.Text;
            //    db.SaveChanges();
            //    EserEkleCevir();
            //}


        }

        private void EserEkleCevir()
        {
            grpEser.Text = "Eser Ekle";
            btnEserEkle.Text = "EKLE";
            txtEserBaslik.Clear();
            txtEserIcerik.Clear();
            cmbEserYazarlar.SelectedIndex = 0;
            btnEserIptal.Visible = false;

        }


        private void EserYukle()
        {
            EserPanelYukle();
        }
        private void EserPanelYukle()
        {

            lstEserler.DataSource = db.Eserlers.ToList();
            lstEserler.DisplayMember = "Baslik";
            
        }
        private void lstEserler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EserGuncelleCevir();

        }

        private void EserGuncelleCevir()
        {
            if (lstEserler.SelectedItem != null)
            {
                grpEser.Text = "Eser Güncelle";
                btnEserEkle.Text = "GÜNCELLE";
                btnEserIptal.Visible = true;
                Eserler guncellenecekEser = (Eserler)lstEserler.SelectedItem;
                txtEserIcerik.Text = guncellenecekEser.Icerik;
                txtEserBaslik.Text = guncellenecekEser.Baslik;
                if (guncellenecekEser.Yazarlar==null)
                {
                    cmbEserYazarlar.SelectedIndex = 0;
                }
                else
                {
                    cmbEserYazarlar.SelectedItem = guncellenecekEser.Yazarlar;
                }
            }
        }

        private void lstEserler_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && lstEserler.SelectedItems.Count > 0)
            {
                Eserler silinecekEser = (Eserler)lstEserler.SelectedItem;
                db.Eserlers.Remove(silinecekEser);
                db.SaveChanges();
                EserYukle();
            } 
        }

        private void btnEserIptal_Click(object sender, EventArgs e)
        {
            EserEkleCevir();
        }

        private void EserYazarFotoYukle()
        {
            if (cmbAnasayfaYazarlar.SelectedIndex==0)
            {
                lstAnasayfaEserler.DataSource = db.Eserlers.ToList();
                lstAnasayfaEserler.DisplayMember = "Baslik";
                pbxAnasayfaResim.ImageLocation = "https://t4.ftcdn.net/jpg/02/38/86/89/360_F_238868953_D6dfKSahj9HBXzzNleaPmfQI8gtN1jq5.jpg";
            }
            else if (cmbAnasayfaYazarlar.SelectedItem != null)
            {
                Yazarlar seciliYazar = (Yazarlar)cmbAnasayfaYazarlar.SelectedItem;
                lstAnasayfaEserler.DataSource = seciliYazar.Eserlers.ToList();
                pbxAnasayfaResim.ImageLocation = seciliYazar.ResimYolu;
            }
            
            
        }

        private void cmbAnasayfaYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            EserYazarFotoYukle();
        }

        private void lstAnasayfaEserler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnasayfaEserler.SelectedItem!=null)
            {
                Eserler eser = (Eserler)lstAnasayfaEserler.SelectedItem;
                txtAnasayfaEserler.Text = eser.Icerik;
            }
        }
    }
}
