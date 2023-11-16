using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersTekrar
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;


        }
        public Personel() { }
        string ad;
        public string Ad { get => ad;set => ad=value; }

        string adres;
        public string Adres { get => adres;set => adres=value; }

        int yas;
        public int Yas { get => yas;set => yas=value; }

        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }

        int mesai;
        public int Mesai { get => mesai;set => mesai=value; }   

       

        public virtual int ucretHesapla()
        {
            return this.mesai * 100;
        }
        public void ucretHesapla(int ekUcret)
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }


    }
}
