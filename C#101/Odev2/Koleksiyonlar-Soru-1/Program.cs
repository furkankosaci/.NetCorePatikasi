using System.Collections;

// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
// -Negatif ve numeric olmayan girişleri engelleyin.
// -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


ArrayList sayilar = new ArrayList();
ArrayList asal = new ArrayList();
ArrayList asalOlmayan = new ArrayList();

// Kullanıcıdan negatif ve numeric kontolü yaparak sayıları alma
while (sayilar.Count < 20)
{
    Console.Write("Pozitif bir sayı girin: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number) && number > 0)
    {
        sayilar.Add(number);
    }
    else
    {
        Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin.");
    }
}

// Alınan sayıların asal olup olmadığını kontrol etme
foreach (int sayi in sayilar)
{
    if (IsAsal(sayi))
        asal.Add(sayi);
    else
        asalOlmayan.Add(sayi);
}

// Sayıları büyükten küçüğe sıralama
asal.Sort(); 
asal.Reverse();

asalOlmayan.Sort();
asalOlmayan.Reverse();

//Yazdırma, eleman sayısı ve ortalama alma işlemleri
Console.WriteLine("Asal Sayılar: ");

foreach (var item in asal)
    Console.WriteLine(item);

Console.WriteLine($"Eleman Sayısı: {asal.Count}");

if (asal.Count > 0)
{
    int toplam = 0;
    foreach (int sayi in asal)
    {
        toplam += sayi;

    }
    double ortalama = (double)toplam / asal.Count;
    Console.WriteLine($"Ortalama: {ortalama:F2}"); 
}
else
{
    Console.WriteLine("Ortalama: Hesaplanamadı (eleman yok)");
}

Console.WriteLine("Asal Olmayan Sayılar: ");

foreach (var item in asalOlmayan)
    Console.WriteLine(item);

Console.WriteLine($"Eleman Sayısı: {asalOlmayan.Count}");

if (asalOlmayan.Count > 0)
{
    int toplam = 0;
    foreach (int sayi in asalOlmayan)
    {
        toplam += sayi;

    }
    double ortalama = (double)toplam / asalOlmayan.Count;
    Console.WriteLine($"Ortalama: {ortalama:F2}"); 
}
else
{
    Console.WriteLine("Ortalama: Hesaplanamadı (eleman yok)");
}

// Asal olup olmadığını kontrol eden fonksiyon
bool IsAsal(int sayi)
{
    if (sayi < 2) return false;

    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
        {
            return false;
        }
    }

    return true;
}