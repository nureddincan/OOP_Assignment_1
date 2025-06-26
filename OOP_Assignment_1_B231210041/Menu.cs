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
    internal class Menu
    {

        private List<Yiyecek> liste = new List<Yiyecek>();
        public List<Yiyecek> Liste
        {
            get { return liste; }
        }
        public void Ekle(Yiyecek yiyecek)
        {
            liste.Add(yiyecek);
        }
        public void Sil(int index)
        {
            liste.RemoveAt(index);
        }
        public List<Yiyecek> MenuYazdir()
        {
            return liste;
        }

    }
}