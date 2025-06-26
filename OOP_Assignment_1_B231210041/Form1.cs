/***************************************************************************
**                        SAKARYA ÜNÝVERSÝTESÝ
**              BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**                    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**                   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					      2024-2025 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖÐRENCÝ ADI............: Nureddin Can ERDEÐER
**				ÖÐRENCÝ NUMARASI.......: B231210041
**              DERSÝN ALINDIÐI GRUP...: C
****************************************************************************/

using System;

namespace OOP_Assignment_1_B231210041
{
    public partial class Form1 : Form
    {

        private Yiyecek s;
        private Menu m = new Menu();
        public Form1()
        {
            InitializeComponent();

        }

        double toplamTutar = 0;
        public string ToplamTutar(double fiyat)
        {
            toplamTutar += fiyat;

            return toplamTutar.ToString("F2");
        }

        private double ToplamKaloriHesapla()
        {
            double toplamKalori = 0;
            foreach (var yiyecek in m.Liste)
            {
                if (yiyecek is Meyve meyve)
                    toplamKalori += meyve.Kalori;
                else if (yiyecek is Salata salata)
                    toplamKalori += salata.Kalori;
                else if (yiyecek is Tatli tatli)
                    toplamKalori += tatli.Kalori;
                else if (yiyecek is Icecek icecek)
                    toplamKalori += icecek.Kalori;
            }
            return toplamKalori;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string secilenTur = yiyecekComboBox.Text;
            string adi = adiTextBox.Text;
            string cins = cinsTextBox.Text;
            double fiyat = Convert.ToDouble(fiyatNumericUpDown.Value);
            double kdvOrani = Convert.ToDouble(kdvOraniNumericUpDown.Value);
            double kalori = Convert.ToDouble(kaloriNumericUpDown.Value);

            if (secilenTur == "" || adi == "" || cins == "")
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (secilenTur)
            {
                case "Meyve":
                    s = new Meyve(secilenTur, adi, cins, fiyat, kdvOrani, kalori);
                    break;
                case "Salata":
                    s = new Salata(secilenTur, adi, cins, fiyat, kdvOrani, kalori);
                    break;
                case "Tatlý":
                    s = new Tatli(secilenTur, adi, cins, fiyat, kdvOrani, kalori);
                    break;
                case "Ýçecek":
                    s = new Icecek(secilenTur, adi, cins, fiyat, kdvOrani, kalori);
                    break;
            }

            m.Ekle(s);

            tutarLabel.Text = "Tutar: " + ToplamTutar(fiyat) + " TL";

            menuListBox.Items.Add(s.Yazdir());

            MessageBox.Show("Yiyecek eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void silButton_Click(object sender, EventArgs e)
        {
            if (menuListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir öðe seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double silinenFiyat = m.Liste[menuListBox.SelectedIndex].Fiyat;

            m.Sil(menuListBox.SelectedIndex);

            menuListBox.Items.Remove(menuListBox.SelectedItem);

            toplamTutar -= silinenFiyat;
            tutarLabel.Text = "Tutar: " + toplamTutar.ToString() + " TL";

            MessageBox.Show("Yiyecek silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuOlusturButton_Click(object sender, EventArgs e)
        {

            if (m.Liste.Count == 0)
            {
                MessageBox.Show("Lütfen menü oluþturmadan önce bir yiyecek ekleyin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double fiyatSinir = 5000;
            double kaloriSinir = 2500;

            double toplamKalori = ToplamKaloriHesapla();

            if (toplamKalori > kaloriSinir)
            {
                MessageBox.Show($"Kalori limiti aþýldý! (Max: {kaloriSinir}, Siz: {toplamKalori.ToString("F2")})", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (toplamTutar > fiyatSinir)
            {
                MessageBox.Show($"Fiyat limiti aþýldý! (Max: {fiyatSinir}, Siz: {toplamTutar.ToString("F2")})", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<Yiyecek> yiyecekListesi = m.MenuYazdir();

                string menuMetni = "Menü:\n";

                foreach (var yiyecek in yiyecekListesi)
                {
                    menuMetni += yiyecek.Yazdir() + "\n";
                }

                MessageBox.Show(menuMetni, "Menü Listesi");
            }
        }
    }
}