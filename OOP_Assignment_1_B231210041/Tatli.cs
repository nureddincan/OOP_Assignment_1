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
    internal class Tatli : Yiyecek
    {
        public double Kalori;
        public Tatli()
        {
            SecilenTur = string.Empty;
            Adi = string.Empty;
            Cins = string.Empty;
            Fiyat = 0;
            KdvOrani = 0;
            Kalori = 0;
        }
        public Tatli(string secilenTur, string adi, string cins, double fiyat, double kdvOrani, double kalori)
        {
            SecilenTur = secilenTur;
            Adi = adi;
            Cins = cins;
            Fiyat = fiyat;
            KdvOrani = kdvOrani;
            Kalori = kalori;
        }
        public override string Yazdir()
        {
            string data = string.Format("{0,-10} {1,-10} {2,10} {3,3} {4,4} {5,8}", Adi, Cins, Fiyat, KdvOrani, Kalori, SecilenTur);
            return data;
        }
    }
}