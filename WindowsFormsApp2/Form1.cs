using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Toplamaİslemi : Form
    {
        public Toplamaİslemi()
        {
            InitializeComponent();
        }
        void LogYaz(string mesaj)
        {
            lvlog.Items.Add(mesaj);

        }
        int Topla(int sayi1,int sayi2)
        {
            return (sayi1 + sayi2);
        }
        void EkranıHazırla()
        {
            txtBirinciSayi.Text = "0";
            txtİkinciSayi.Text = "0";
            txtBirinciSayi.Focus();
           
        }
        Boolean Dogrula()
        {
            try
            {
                //try'da hata varsa Catche düşüyor.
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtİkinciSayi.Text);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int BirinciSayi, İkinciSayi, Toplam;
            
            if (Dogrula())
            {
                BirinciSayi = Convert.ToInt32(txtBirinciSayi.Text);
                İkinciSayi = Convert.ToInt32(txtİkinciSayi.Text);
                Toplam = Topla(BirinciSayi, İkinciSayi);
                txtSonuc.Text = Toplam.ToString();
                EkranıHazırla();
                //to do log yaz
                LogYaz("Toplama işlemi başarılı Birinci Sayı:" + BirinciSayi + ", İkinci sayı:" + İkinciSayi);
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                EkranıHazırla();
                //to do log yaz
                LogYaz("Toplama işlemi başarısız Birinci Sayı:" + txtBirinciSayi.Text + ",İkinci Sayı:" + txtİkinciSayi.Text);
            }
            
        }

        private void Toplamaİslemi_Shown(object sender, EventArgs e)
        {
            //Shown Load'dan sonra çalıştığı için focuslanırken loadda focus olmaz.
            EkranıHazırla();
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void txtİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;

        }
    }
}
