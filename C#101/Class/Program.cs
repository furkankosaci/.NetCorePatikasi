//Söz dizimi
// class sinifAdi
// {
//      [Erişim belirleyici] [Veri tipi] OzellikAdi;
//      [Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
//      {
//      Metot komutları
//      }
// }

//Erişim belirleyiciler
// * Public
// * Private
// * Internal
// * Protected

Console.WriteLine("*****Çalışan 1******");
Calisan calisan1 = new Calisan();
calisan1.Ad = "Furkan";
calisan1.Soyad = "Kosacı";
calisan1.No = 123456;
calisan1.Departman = "IT";
calisan1.CalisanBilgileri();

Console.WriteLine("*****Çalışan 2******");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 123456;
calisan2.Departman = "Satın Alma";
calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
}