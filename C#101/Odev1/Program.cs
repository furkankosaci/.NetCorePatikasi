// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif
// sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


Console.Write("Lütfen pozitif bir sayı giriniz: ");
int n = int.Parse(Console.ReadLine());
List<int> ciftsayilar = new List<int>();
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write("Lütfen {0}. pozitif sayıyı giriniz: ", i);
        int sayi = int.Parse(Console.ReadLine());
        if (sayi % 2 == 0)
        {
            ciftsayilar.Add(sayi);
        }
    }

    Console.Write("Girilen çift sayılar: ");
}
else
{
    Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
}

foreach (var sayi in ciftsayilar)
{
    Console.Write(sayi + " ");
}


// ****************************************************************************************************************
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif
// sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


Console.Write("Lütfen 1. pozitif sayıyı giriniz: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Lütfen 2. pozitif sayıyı giriniz: ");
int m = int.Parse(Console.ReadLine());

List<int> sayilar = new List<int>();

if (n > 0 && m > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write("Lütfen {0}. pozitif sayıyı giriniz: ", i);
        int sayi = int.Parse(Console.ReadLine());
        if (sayi % m == 0)
        {
            sayilar.Add(sayi);
        }
    }

    Console.Write(m + " sayısına eşit olan veya tam bölünen sayılar: ");
}
else
{
    Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
}

foreach (var item in sayilar)
{
    Console.Write(item + " ");
}


// ****************************************************************************************************************
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi
// isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


Console.Write("Lütfen pozitif bir sayı giriniz: ");
int n = int.Parse(Console.ReadLine());

List<string> kelimeler = new List<string>();

if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write("Lütfen {0}. kelimeyi giriniz: ", i);
        string kelime = Console.ReadLine();
        kelimeler.Add(kelime);

    }

    Console.Write("Kelimeler: ");
}
else
{
    Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
}

kelimeler.Reverse();

foreach (var item in kelimeler)
{
    Console.Write(item + ", ");
}


// ****************************************************************************************************************
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


Console.WriteLine("Lütfen bir cümle yazınız: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');
int kelimesayisi = kelimeler.Length;

int harfsayisi = 0;

foreach (char item in cumle)
{
    if (char.IsLetter(item))
    {
        harfsayisi++;
    }
}

Console.WriteLine("Cümlede ki kelime sayısı: " + kelimesayisi);
Console.WriteLine("Cümlede ki harf sayısı: " + harfsayisi);


// ****************************************************************************************************************