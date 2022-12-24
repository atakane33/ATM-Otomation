using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Otomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {

            int sifreAl, sifreCikti, sayac, bakiye;

            sayac = 0;

            bakiye = 300;

            Console.Write("Lütfen Şifrenizi Kayıt Ediniz ! : ");

            sifreAl = Convert.ToInt32(Console.ReadLine());

            if (sifreAl <= 999 || sifreAl > 9999)
            {
                Console.Write("Lütfen 4 Basamaklı Bir Şifre Giriniz !!! ");

                Console.ReadKey();
            }

            do
            {

                Console.Write("\nLütfen Şifrenizi Giriniz ! : ");

                sifreCikti = Convert.ToInt32(Console.ReadLine());


                if (sifreCikti <= 999 || sifreCikti > 9999)
                {
                    Console.Write("Lütfen 4 Basamaklı Bir Şifre Giriniz !!! ");

                    Console.ReadKey();

                    break;
                }


                if (sifreAl != sifreCikti)
                {
                    Console.Write("Yanlış Şifre Girdiniz ! Lütfen Tekrar Deneyiniz ! ");

                    sayac++;
                }


                if (sayac == 3)
                {
                    Console.WriteLine("Şifre Hakkınız Kalmadı ! Kartınız Bloke Oldu ! ");

                    Console.ReadLine();

                    Console.ReadKey();

                    break;
                }



            } while (sifreAl != sifreCikti);

            
            Console.Write("Giriş Başarılı ! ");

            Console.WriteLine("Sisteme Giriş Yapılıyor ... ");

            string islem;

            Console.Write("Lütfen Alttaki İşlemlerden Birini Seçiniz : ");

            Console.Write("\n1) Para Çekme ");

            Console.Write("\n2) Para Yatırma ");

            Console.Write("\n3) Bakiye Sorgulama ");

            Console.Write("\n4) Bakiye'yi Dolara Çevirme ");

            Console.Write("\n5) Döviz Kuru ");

            Console.WriteLine("\n6) Kredi Başvuru ");

            islem = Console.ReadLine();

            switch (islem)
            {

                case "1":

                    int cekilenPara;

                    Console.Write("Lütfen Çekmek İstediğiniz Miktarı Giriniz ! : ");

                    cekilenPara = Convert.ToInt32(Console.ReadLine());

                    if (cekilenPara > bakiye)
                    {
                        Console.Write("Yetersiz Bakiye !! ");

                        Console.ReadKey();
                    }

                    bakiye = bakiye - cekilenPara;

                    Console.Write("Yeni Bakiye : " + (bakiye));

                    break;

                case "2":

                    int yatirilanPara;

                    Console.Write("Lütfen Yatırmak İstediğiniz Miktarı Yazınız ! : ");

                    yatirilanPara = Convert.ToInt32(Console.ReadLine());

                    bakiye = yatirilanPara + bakiye;

                    Console.WriteLine("Yeni Bakiyeniz : " + (bakiye));

                    break;

                case "3":

                    Console.Write("Mevcut Bakiyeniz : " + (bakiye));

                    break;


                case "4":

                    double dolar, yeniBakiye;

                    dolar = 13.72;

                    yeniBakiye = bakiye / dolar;

                    Console.Write("Bakiyeniz Dolar Cinsinden : " + (yeniBakiye));

                    break;



                case "5":

                    double altin, euro, sterlin,dolar1;

                    altin = 785.56;

                    euro = 15.51;

                    sterlin = 18.14;

                    dolar1 = 13.72;

                    Console.Write("Dolar : " + (dolar1));

                    Console.Write("\nEuro : " + (euro));

                    Console.Write("\nSterlin : " + (sterlin));

                    Console.Write("\nAltın : " + (altin));

                    break;

                case "6":

                    string kredi;

                    Console.Write("Kredi Miktarlarından Birini Seçiniz ! : ");

                    Console.Write("\n1) 5000 TL ");

                    Console.Write("\n2) 10000 TL ");

                    Console.Write("\n3) 20000 TL ");

                    Console.WriteLine("\n4) 30000 TL ");

                    kredi = Console.ReadLine();

                    switch (kredi)
                    {
                        case "1":

                            int yeniBakiye1;

                            yeniBakiye1 = bakiye + 5000;

                            Console.WriteLine("Yeni Bakiyeniz : " + (yeniBakiye1));

                            break;

                        case "2":

                            int yeniBakiye2;

                            yeniBakiye2 = bakiye + 10000;

                            Console.WriteLine("Yeni Bakiyeniz : " + (yeniBakiye2));

                            break;

                        case "3":

                            int yeniBakiye3;

                            yeniBakiye3 = bakiye + 20000;

                            Console.WriteLine("Yeni Bakiyeniz : " + (yeniBakiye3));

                            break;

                        case "4":

                            int yeniBakiye4;

                            yeniBakiye4 = bakiye + 30000;

                            Console.WriteLine("Yeni Bakiyeniz : " + (yeniBakiye4));

                            break;

                    }

                    break;

            }

        }
    }
}
