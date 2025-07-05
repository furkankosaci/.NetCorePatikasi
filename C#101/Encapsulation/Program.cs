Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Ayşe";
ogrenci1.Soyisim = "Yılmaz";
ogrenci1.OgrenciNo = 293;
ogrenci1.Sinif = 3;
ogrenci1.OgrenciBilgileriniGetir();

ogrenci1.SinifAtlat();
ogrenci1.OgrenciBilgileriniGetir();

Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriniGetir();


class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;

        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en düşük 1 olabilir!");
                sinif = 1;
            }
            else
                sinif = value;
            
        }
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("******** Öğrenci Bilgileri ********");
        Console.WriteLine("Öğrencinin Adı       :{0}", this.Isim);
        Console.WriteLine("Öğrencinin Soyadı    :{0}", this.Soyisim);
        Console.WriteLine("Öğrencinin Numarası  :{0}", this.OgrenciNo);
        Console.WriteLine("Öğrencinin Sınıfı    :{0}", this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif += 1;
    }

    public void SinifDusur()
    {
        this.Sinif -= 1;
    }
}