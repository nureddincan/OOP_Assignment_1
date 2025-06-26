/***************************************************************************
**                        SAKARYA �N�VERS�TES�
**              B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**                    B�LG�SAYAR M�HEND�SL��� B�L�M�
**                   NESNEYE DAYALI PROGRAMLAMA DERS�
**					      2024-2025 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: 1
**				��RENC� ADI............: Nureddin Can ERDE�ER
**				��RENC� NUMARASI.......: B231210041
**              DERS�N ALINDI�I GRUP...: C
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
                MessageBox.Show("L�tfen t�m alanlar� doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                case "Tatl�":
                    s = new Tatli(secilenTur, adi, cins, fiyat, kdvOrani, kalori);
                    break;
                case "��ecek":
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
                MessageBox.Show("L�tfen silmek i�in bir ��e se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("L�tfen men� olu�turmadan �nce bir yiyecek ekleyin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double fiyatSinir = 5000;
            double kaloriSinir = 2500;

            double toplamKalori = ToplamKaloriHesapla();

            if (toplamKalori > kaloriSinir)
            {
                MessageBox.Show($"Kalori limiti a��ld�! (Max: {kaloriSinir}, Siz: {toplamKalori.ToString("F2")})", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (toplamTutar > fiyatSinir)
            {
                MessageBox.Show($"Fiyat limiti a��ld�! (Max: {fiyatSinir}, Siz: {toplamTutar.ToString("F2")})", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<Yiyecek> yiyecekListesi = m.MenuYazdir();

                string menuMetni = "Men�:\n";

                foreach (var yiyecek in yiyecekListesi)
                {
                    menuMetni += yiyecek.Yazdir() + "\n";
                }

                MessageBox.Show(menuMetni, "Men� Listesi");
            }
        }
    }
}