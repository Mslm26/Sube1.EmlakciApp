using System;
using System.Runtime.CompilerServices;

namespace Sube1.EmlakciLib
{

    public abstract class Ev
    {

        public abstract string EvTur();



        private static int sayac1 = 0;

        public static int Sayac1 { get => sayac1; private set => sayac1 = value; }

        public Ev()
        {
            Sayac1++;
        }


        public Ev(int odasayisi, int katno, double alan, string semt)
        {

            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = semt;
            Sayac1++;
        }


        private int odasayisi; //Field
        private string semt;
        private double alan;

        public string Buyukluk { get; private set; }

        //Alan
        //50-75 : Küçük Ev
        //75-120 : Orta büyüklükte ev
        //>120 : Büyük ev


        //Auto Property: Get ve Set bloklarında işlem yapılmayacağı zaman kullanılır.
        public int Katno { get; set; }

        //Lambda ile tek satırlı property örnekleri.

        //public double Alan { get => this.alan; set => this.alan = Math.Abs(value); } //Property
        public string Semt { get => semt; set => semt = value.ToUpper(); } //Property

        //Metodlarla yapılan getter ve setter'lar.
        //public int GetOdasayisi()  => odasayisi;
        //public void SetOdasayisi(int value) => odasayisi = Math.Abs(value);

        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }


       

        public double Alan 
        {
            get
            {
                return alan;
            }
            set 
            {
                if (value < 50)
                {
                    throw new Exception("Minimum alan değeri 50 olmalıdır.");
                }
                alan = value;
                if (this.Alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "Küçük";
                }
                else if (75<this.alan && this.alan < 120)
                {
                    this.Buyukluk = "Orta";
                }
                else if(120 < this.alan)
                {
                    this.Buyukluk = "Büyük";
                }
            }
        }
              







        //Full Property: Get ve Set bloklarında çok satırlı işlemler yapmak için kullanılır.

        //private int myVar;

        //public int MyProperty2
        //{
        //    get 
        //    {
        //        //Burada başka işlemler yapılabilir.
        //        return myVar;
        //    }
        //    set 
        //    { 
        //        myVar = value;
        //        //Burada başka işlemler yapılabilir.

        //    }
        //}

        

        public virtual string ToString()
        {
            return $"Oda sayısı:{this.Odasayisi}\nKat no:{this.Katno}\nEvin Alanı:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}";

        }
    }
}

//Virtual anahtar sözcüğü override edilmesi gereken üyeler, virtual anahtar kelimesi ile tanımlanır. Metot virtual değilse override işlemi yapılamaz.
//Polymorphisim(Çok biçimlilik): Base class'da virtual olarak tanımlanan üyeler türeyen class'larda override edilerek farklı biçimlerde kullanılabilir.

// Constructor - Yapıcı Metod - Kurucu Metod

//Görevi: Bir classın nesne türetilirken çalışır ve class içindeki fieldlara varsayılan değer atamalarını yapar.
// Her classda mutlaka vardır. Varsayılan olarak parametre almazlar bu constructorlara "default constructor" da denir.
// İsimleri class adı ile aynıdır. Farklı isimle tanımlanamazlar.
//Geri dönüş tipleri yoktur.
//Classlardan nesne türetildiğinde çalışan ilk metoddur.
// "ctor" code snippeti ile default constructor oluşturulabilir.

//Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, classa ait yapılardır.

//Kapsülleme (Encapsulation): Class içerisinde yapılan işlerin, class dışından gizlenmesidir. Örn: Odasayisi fieldına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen publis SetOdaSayisi(int odasayisi) metodu yazildi. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.