Console.WriteLine("**********************INTERFACE**********************");

Focus focus = new Focus();
Console.WriteLine(focus.HangiMarkaninAraci().ToString());
Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
Console.WriteLine(focus.StandartRengiNe().ToString());

Corolla corolla = new Corolla();
Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
Console.WriteLine(corolla.kacTekerlektenOlusur().ToString());
Console.WriteLine(corolla.StandartRengiNe().ToString());

Civic civic = new Civic();
Console.WriteLine(civic.HangiMarkaninAraci().ToString());
Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
Console.WriteLine(civic.StandartRengiNe().ToString());

Console.WriteLine("**********************ABSTRACT**********************");

NewFocus newfocus = new NewFocus();
Console.WriteLine(newfocus.HangiMarkaninAraci().ToString());
Console.WriteLine(newfocus.kacTekerlektenOlusur().ToString());
Console.WriteLine(newfocus.StandartRengiNe().ToString());

NewCorolla newcorolla = new NewCorolla();
Console.WriteLine(newcorolla.HangiMarkaninAraci().ToString());
Console.WriteLine(newcorolla.kacTekerlektenOlusur().ToString());
Console.WriteLine(newcorolla.StandartRengiNe().ToString());

NewCivic newcivic = new NewCivic();
Console.WriteLine(newcivic.HangiMarkaninAraci().ToString());
Console.WriteLine(newcivic.kacTekerlektenOlusur().ToString());
Console.WriteLine(newcivic.StandartRengiNe().ToString());