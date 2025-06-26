/***************************************************************************
**                        SAKARYA ÜNİVERSİTESİ
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					      2024-2025 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Nureddin Can ERDEĞER
**				ÖĞRENCİ NUMARASI.......: B231210041
**              DERSİN ALINDIĞI GRUP...: C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1_B231210041
{
    internal class Yiyecek
    {
        public string SecilenTur;
        public string Adi;
        public string Cins;
        public double Fiyat;
        public double KdvOrani;

        public Yiyecek()
        {
            SecilenTur = string.Empty;
            Adi = string.Empty;
            Cins = string.Empty;
            Fiyat = 0;
            KdvOrani = 0;
        }
        public Yiyecek(string secilenTur, string adi, string cins, double fiyat, double kdvOrani)
        {
            SecilenTur = secilenTur;
            Adi = adi;
            Cins = cins;
            Fiyat = fiyat;
            KdvOrani = kdvOrani;
        }
        public virtual string Yazdir()
        {
            string data = string.Format("{0,-10} {1,-10} {2,10} {3,3} {4,4} {5,8}", Adi, Cins, Fiyat, KdvOrani, SecilenTur);
            return data;
        }

    }
}