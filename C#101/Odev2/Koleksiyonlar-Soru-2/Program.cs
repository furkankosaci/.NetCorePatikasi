using System.Collections;

// // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını
// // alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)


ArrayList sayilar = new ArrayList();
ArrayList büyükler = new ArrayList();
ArrayList küçükler = new ArrayList();

while (sayilar.Count < 20)
{
    Console.Write("Bir sayı girin: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        sayilar.Add(number);
    }
    else
    {
        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
    }
}

sayilar.Sort();

küçükler.Add(sayilar[0]);
küçükler.Add(sayilar[1]);
küçükler.Add(sayilar[2]);

büyükler.Add(sayilar[19]);
büyükler.Add(sayilar[18]);
büyükler.Add(sayilar[17]);

int toplam1 = 0;
foreach (int sayi in küçükler)
{
    toplam1 += sayi;
}
double ortalama1 = (double)toplam1 / küçükler.Count;
Console.WriteLine($"En Küçük 3 Sayının Ortalaması: {ortalama1:F2}");

int toplam2 = 0;
foreach (int sayi in büyükler)
{
    toplam2 += sayi;
}
double ortalama2 = (double)toplam2 / büyükler.Count;
Console.WriteLine($"En Büyük 3 Sayının Ortalaması: {ortalama2:F2}");

Console.WriteLine($"Ortalama Toplamları: {ortalama1+ortalama2:F2}");