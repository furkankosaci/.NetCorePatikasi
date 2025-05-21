// Dizi Tanımlama
string[] renkler = new string[5];

string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi;
dizi = new int[5];

// Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle Dizi Kullanma
// Soru: Klavyeden girilen n tane sayının ortalamasını alan program.

Console.Write("Lütfen dizinin elaman sayısını giriniz: ");
int length = int.Parse(Console.ReadLine());
int[] sayilar = new int[length];
for (int i = 0; i < length; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayilar[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayilar)
{
    toplam += sayi;
}
Console.WriteLine("Ortalama: "+toplam / length);
