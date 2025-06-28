using System.Collections;

// Soru - 3: Klavyeden girilen cumle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin
// elemanlarını sıralayan programı yazınız.

string cumle;
char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
List<char> bulunanSesliler = new List<char>();

while (true)
{
    Console.Write("Bir cumle girin: ");
    cumle = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(cumle))
    {
        Console.WriteLine("Geçersiz giriş. Lütfen bir cumle girin.");
        continue;
    }

    string temizcumle = cumle.Replace(" ", "");
    if (!temizcumle.All(char.IsLetter))
    {
        Console.WriteLine("Lütfen sadece harf ve boşluk kullanın.");
        continue;
    }

    break;
}

string kucukcumle = cumle.ToLower();

foreach (char harf in kucukcumle)
{
    if (sesliHarfler.Contains(harf))
    {
        bulunanSesliler.Add(harf);
    }
}

bulunanSesliler.Sort();

Console.WriteLine("Bulunan sesli harfler:");
foreach (char sesli in bulunanSesliler)
{
    Console.WriteLine(sesli);
}