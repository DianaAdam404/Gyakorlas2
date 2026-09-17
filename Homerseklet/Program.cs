using Homerseklet;

HomersekletAtvalto peldany = new HomersekletAtvalto();
peldany.Celsius = double.Parse(Console.ReadLine());
Console.WriteLine($"{ peldany.ToFahrenheit()}F");

//static
double atadott = double.Parse(Console.ReadLine());
Console.WriteLine($"{ HomersekletAtvalto.CelsiusToFahrenheit(atadott)}C");
