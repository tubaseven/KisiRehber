using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitDefteri
{
    public partial class FrmKayit : Form
    {
        private List<Kisi> kisiler;

        public FrmKayit()
        {
            InitializeComponent();
            kisiler = new List<Kisi>();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Kisi YeniKisi = new Kisi(txt_yeniAd.Text, txt_yeniSoyad.Text, txt_yeniTel.Text, rch_yeniAdres.Text);
            kisiler.Add(YeniKisi);
            ListViewItem kisiItem= new ListViewItem();
            kisiItem.SubItems[0].Text = YeniKisi.Ad + " " +YeniKisi.Soyad;//ilk sutuna bir değer ataması yaptık.
            //subitem itemin propertsi 
            //ListViewItemsin Itemları satırları, subitemları sutunları ifade eder.
            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem();//ikinci bir sutun yarattık.
            sub.Text = YeniKisi.Telefon;
            kisiItem.SubItems.Add(sub); //kisiItem.SubItems[0].Text = YeniKisi.Telefon;
            lst_Liste.Items.Add(kisiItem);
            //subitems sıfırıncısı otomatik geliyor o yuzden biriniciyi eklememiz gerekli
            
             
        }

        private void btn_yeniIptal_Click(object sender, EventArgs e)
        {
            TextTemizle();
            txt_gncAd.Focus();

        }

        private void btn_gncIptal_Click(object sender, EventArgs e)
        {
            txt_gncAd.Clear();
            txt_gncSoyad.Clear();
            txt_gncTel.Clear();
            rch_gncAdres.Clear();
        }
        void TextTemizle()
        {
            txt_yeniAd.Clear();
            txt_yeniSoyad.Clear();
            txt_yeniTel.Clear();
            rch_yeniAdres.Clear();
        }

        private void lst_Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            grp_Guncelle.Enabled = true;

            if (lst_Liste.SelectedItems.Count<=0)
            {
                return; //eğer hiç seçili item yok ise metodu bitir.Aşagıya hic ugramaz.
            }
            var seciliTelefon = lst_Liste.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    txt_gncAd.Text = kisiler[i].Ad;
                    txt_gncSoyad.Text = kisiler[i].Soyad;
                    txt_gncTel.Text = kisiler[i].Telefon;
                    rch_gncAdres.Text = kisiler[i].Adres;
                }

            }
            txt_gncAd.Text = lst_Liste.SelectedItems[0].Text.Split(' ')[0];


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            
            var seciliTelefon = lst_Liste.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    kisiler[i].Ad = txt_gncAd.Text;
                    kisiler[i].Soyad = txt_gncSoyad.Text;
                    kisiler[i].Telefon = txt_gncTel.Text;
                    kisiler[i].Adres = rch_gncAdres.Text;

                    var secili = lst_Liste.SelectedItems[0];
                    secili.SubItems[0].Text = kisiler[i].Ad +" "+ kisiler[i].Soyad;
                    secili.SubItems[1].Text = kisiler[i].Telefon;

                    break;
                    
                    
                }
               
            }
            grp_yeniKisi.Enabled = true;

            GuncelleTemizle();


        }
        void GuncelleTemizle()
        {
            txt_gncAd.Clear();
            txt_gncSoyad.Clear();
            txt_gncTel.Clear();
            rch_gncAdres.Clear();
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
