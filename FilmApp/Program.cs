using FilmApp;
Film elsofilm = new Film();
elsofilm.Cim = "A Gyuruk ura";
elsofilm.HosszPercben = 178;

Film masodikfilm = new Film();
Console.Write("Adja meg a  masodik film cimet: ");
masodikfilm.Cim = Console.ReadLine();
Console.Write("Adja meg a  masodik film cimet: ");
masodikfilm.HosszPercben = int.Parse(Console.ReadLine());
Console.WriteLine($"Az elso film cime: {elsofilm.Cim}, hossza percben: {elsofilm.HosszPercben}");
Console.WriteLine($"A masodik film cime: {masodikfilm.Cim}, hossza percben: {masodikfilm.HosszPercben}");
