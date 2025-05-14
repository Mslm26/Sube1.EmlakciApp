using System;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {

        public override string EvTur()
        {
            Console.WriteLine("Bu bir satılık evdir.");
            return "Satılık ev";
        }
        public SatilikEv()
        {
            
        }
        public SatilikEv(double satisfiyat, int odasayisi, int katno, double alan, string semt):base(odasayisi, katno, alan, semt) //Bunla
        {
            this.Satisfiyat = satisfiyat; 
        }

        public double Satisfiyat { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyat:{this.Satisfiyat}";
        }

    }
}


//Name hiding: Türeyen classlarda, base classtaki üye(ler)in ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez.