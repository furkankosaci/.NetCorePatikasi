public class Bitkiler:Canlilar
{
    protected void FotosentezYapmak()
    {
        System.Console.WriteLine("Bitkiler Fotosentez Yapar.");
    }

}

public class TohumluBitkiler:Bitkiler
{   public TohumluBitkiler()
    {
        base.FotosentezYapmak();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }

    public void TohumlaCogalma()
    {
        System.Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler:Bitkiler
{   public TohumsuzBitkiler()
    {
        base.FotosentezYapmak();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void SporlaCogalma()
    {
        System.Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}