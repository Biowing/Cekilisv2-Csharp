﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cekilis
{
    public partial class CekilisProgramı : Form
    {
        public CekilisProgramı()
        {
            InitializeComponent();
        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            if (isimler.Text != "")//isimleri yazdığımız kısım boş değilse
            {
                kisiler.Items.Add(isimler.Text);//Verileri kisilere aktarabiliyor.
                isimler.Text = "";
            }
        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            if (kisisayisi.Text != "") //Boş değilse
            {
            int kisiadeti = Int32.Parse(kisisayisi.Text);//Yazı olarak değilde sayı olarak algılatıyoruz...
            Random cekilis = new Random();
            for (int i = 1; i <= kisiadeti; i++)//Kisi adetine göre sıralama yapacak 
            //örnek 1 secersek 1 de kalacak 2 ise 1 e 1 ekleyecek o şekilde artacak
            {

                int cek = cekilis.Next(0, kisiler.Items.Count);//Cekilise göre kisilerden veri cekiyor...
                kazananlar.Items.Add(kisiler.Items[cek]);//Kisilerden cekilen verileri kazananlar bölümüne yolluyoruz.
                sonuc.Enabled = false;//Sonuçlar butonunu kitliyoruz
                sil.Enabled = false;//Sil butonunu kilitliyoruz

            }
            
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//Sadece Sayı İçin
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            kisiler.Items.Remove(kisiler.SelectedItem);//Seçileni silmesi için kod
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
