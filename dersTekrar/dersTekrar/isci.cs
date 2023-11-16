using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersTekrar
{
    internal class isci : Personel
    {
        string Tur;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text6;

        public isci(string text1, string text2, string text3, string text4, string gTur, string text6)
        {
            this.Ad = text1;
            this.Adres = text2;
            this.Yas = Convert.ToInt32(text3);
            this.Unvan = text4;
            this.Tur = gTur;
            this.Mesai=Convert.ToInt32(text6);
        
        
        }
        public override int ucretHesapla()
        {
            if(this.Tur=="Gündelik")
            { return this.Mesai * 1000; }
            return this.Mesai * 100 + 5000;
        }

        public string tur { get => Tur; set => Tur = value; }
    }
}
