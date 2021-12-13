using System;
namespace PersonelApp.Classes
{
    public class PersonelBase
    {
        public int Id;
        private string ad;
        private string soyad;

        protected PersonelBase(string ad, string soyad)
        {

        }
        protected PersonelBase(string ad = null)
        {
            this.ad = ad;
        }

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

        public virtual string AdSoyadGetir()
        {
            return $"Adı Soyadı: {Ad} {Soyad}";
        }

        public virtual decimal AylikHesapla()
        {
            return 0;
        }

    }
}
