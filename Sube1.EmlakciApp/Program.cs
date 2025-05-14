using Sube1.EmlakciLib;
using System.Runtime.Intrinsics.X86;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        int sayac = 0;
        static void Main(string[] args)
        {
            //Ev evim = new Ev();
            //evim.alan = 100;
            //evim.semt = "Gazi";
            //evim.katno = 2;
            //evim.odasayisi = 3;
            //evim.EvBilgileri();

            //string bilgi = evim.EvBilgileri();
            //Console.WriteLine(bilgi);



            //Ev evim2 = new Ev();
            //evim2.odasayisi = 2;
            //evim2.katno = 5;
            //evim2.semt = "Gazi";
            //evim2.alan = 120;

            //Console.WriteLine(evim2.EvBilgileri());

            //var evim3 = new Ev(3, 2, 100, "gazi");
            //Console.WriteLine(evim3.EvBilgileri);




            //Console.WriteLine($"Bellekteki ev sayısı = {Ev.sayac}");


            //try
            //{
            //    var evim = new Ev();

            //    evim.Semt = "gazi";
            //    evim.Alan = 130;
            //    evim.Katno = 4;
            //    evim.Odasayisi = 6;


            //    Console.WriteLine(Ev.Sayac1);
            //    Console.WriteLine($"Evin: \n {evim.EvBilgileri()}");

            //    Console.WriteLine(evim.Buyukluk);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Pc bilgisayar = new Pc();
            //bilgisayar.ram = 32;
            //bilgisayar.vram = 8;
            //bilgisayar.ekrankartı = "RTX 4060";
            //bilgisayar.depolama = 1;
            //bilgisayar.islemci = "İntel Core i7 13900H";
            //bilgisayar.fiyat = 500000;


            //Kutuphane kitap1 = new Kutuphane();

            //kitap1.Kitapad = "abc";
            //kitap1.Yazar = "def";
            //kitap1.Basimtarih = new DateTime(2000, 1,1);
            //kitap1.Stokgiristarih = new DateTime(2001, 1, 1);



            SatilikEv se1 = new SatilikEv(500, 4, 3, 450, "Satılık Ev");
            SatilikEv se2 = new SatilikEv(600, 6, 8, 500, "Satılık Ev");
            SatilikEv se3 = new SatilikEv(700, 5, 7, 300, "Satılık Ev");


            KiralikEv ke1 = new KiralikEv(400, 100, 6, 8, 700, "Kiralık Ev");
            KiralikEv ke2 = new KiralikEv(800, 200, 7, 2, 800, "Kiralık Ev");
            KiralikEv ke3 = new KiralikEv(900, 400, 5, 4, 900, "Kiralık Ev");


            Ev[] evler = { ke1, ke2, ke3, se1, se2, se3 };

            foreach (Ev ev in evler)
            {
                Console.WriteLine(ev.ToString());
                Console.WriteLine("--------------------");
            }


            //Console.WriteLine(ke1.ToString());

            //Ev[] evler = {ke1, ke2, ke3, se1, se2, se3};


            //for (int i = 0; i < evler.Length; i++)
            //{
            //    //if (evler[i] is SatilikEv)
            //    //{
            //    //    SatilikEv sev = (SatilikEv)evler[i];
            //    //    Console.WriteLine(sev.EvBilgileri());
            //    //}
            //    //else
            //    //{
            //    //    KiralikEv kev = (KiralikEv)evler[i];
            //    //    Console.WriteLine(kev.EvBilgileri());
            //    //}
            //    Console.WriteLine($"{i + 1}. Ev\n{evler[0].EvBilgileri()}\n");
            //    Console.WriteLine("-----------------");
            //}







        }
    }
    //class Pc
    //{
    //    public int ram;
    //    public int depolama;
    //    public int vram;
    //    public int fiyat;
    //    public string islemci;
    //    public string ekrankartı;
    //}

}


//Ev Classından nesne türetildi.
//evim: Referans. Referanslar nesnelerin bellekteki adresini tutarlar. Belleğin STACK bölgesinde tutulurlar.
//Ev: Class. Classlar aynı zamanda bir veri tipidir.
//new: Bellekte nesne oluşturmaya yarayan anahtar sözcüktür.
//Nesne : new anahtar sözcüğü ile heap bölgesinde oluşturulurlar.

//Erişim Belirleyiciler(Access Modifiers)
//Private: Sadece class içerisinden erişilebilir üyelerdir.
//Public: Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar.


//nesne tabanlı programlamaya ilişkin abstraction ilkesi hakkında çalış, emlakçı projesine abstraction ile neler yapılabilir bunlara bak. baştan sona ne gördüysek o sorular çıkacak.