public class Focus : IOtomobil
{
    public Marka HangiMarkaninAraci()
    {
        return Marka.Ford;
    }

    public int kacTekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
}