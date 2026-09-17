using DiakApp;

Diak parameternelkul = new Diak();
Diak egyparameteres = new Diak("Nagy Jonas");
Diak ketparameteres = new Diak("Kovacs Anna", 3.8);

Console.WriteLine($"Parameternelkul: {egyparameteres.Nev} {egyparameteres.Atlag}");
Console.WriteLine($"EGYparameter: {egyparameteres.Nev} {egyparameteres.Atlag}");
Console.WriteLine($"KETTOarameter: {egyparameteres.Nev} {egyparameteres.Atlag}");
