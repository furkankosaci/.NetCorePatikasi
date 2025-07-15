public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        System.Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
    }

}

public class Sürüngenler:Hayvanlar{
    public Sürüngenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }

    public void SurunerekHareketEtmek()
    {
        System.Console.WriteLine("Sürüngeler sürünerek hareket ederler.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void Ucmak()
    {
        System.Console.WriteLine("Kuşlar uçar");
    }
}