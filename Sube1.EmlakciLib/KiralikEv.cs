using System;

namespace Sube1.EmlakciLib
{

    public class KiralikEv : Ev
    {

        public override string EvTur()
        {
            Console.WriteLine("Bu bir kiralık evdir.");
            return "Kiralık Ev";   
        }



        public KiralikEv() 
        { 
        
        }
        public KiralikEv(double kira, double depozito, int odasayisi, int katno, double alan, string semt):base(odasayisi,katno,alan,semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;
            //base.Odasayisi = odasayisi;
            //base.Katno = katno;
            //base.Semt = semt;
            //base.Alan = alan;
        }

        public double Kira { get; set; }

        public double Depozito { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira Fiyat: {this.Kira}\nDepozito: {this.Depozito}";
        //}

        public override string ToString()
        {
            return $"{base.ToString()}\nKira Fiyat: {this.Kira}\nDepozito: {this.Depozito}";
        }



    }

}


// İnternal Yalnızca aynı namespace içindeki classlar tarafından erişilebilir.

// Her class'ın sadece bir tane base class'ı olabilir. 
