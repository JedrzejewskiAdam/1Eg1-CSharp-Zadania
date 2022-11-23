//Zad1
int a = int.Parse(Console.ReadLine("Podaj pierwszą liczbę : "));
int b = int.Parse(Console.ReadLine("Podaj drugą liczbę : "));
if ((a+b)%2==0)
{
    Console.WriteLine("parzysta");
}
else
{
    Console.WriteLine("nieparzysta");
}
//Zad2
int a = int.Parse(Console.ReadLine("Podaj a : "));
int g = int.Parse(Console.ReadLine("Podaj g : "));
if((a+g)/2 > Math.Sqrt(a*g))
{
    Console.WriteLine("Śr.arytemtyczna jest większa");
}
else
{
    Console.WriteLine("Śr.geometryczna jest większa");
}
//Zad.3
int k = int.Parse(Console.ReadLine("Podaj k : "));
int l = int.Parse(Console.ReadLine("Podaj l : "));
int m = int.Parse(Console.ReadLine("Podaj m : "));
if (k == l || l == m || m == k)
{
    Console.WriteLine("tak");
}
else
{
    Console.WriteLine("nie");
}
if (k ==l)
    Console.WriteLine("Te liczby to k = l ");
if (l == m)
    Console.WriteLine("Te liczby to l = m");
if (m == k)
    Console.WriteLine("Te liczby to m = k");
//Zad.4
int a = int.Parse(Console.ReadLine("Podaj liczbę a : "));
int b = int.Parse(Console.ReadLine("Podaj liczbę b : "));
int c = int.Parse(Console.ReadLine("Podaj liczbę c : "));
int d = int.Parse(Console.ReadLine("Podaj liczbę d : "));
if (a < b && a < c && a < d) 
{
    Console.WriteLine("Najmniejsza " + a);
}
else if (b < a && b < c && b < d) 
{
    Console.WriteLine("Najmniejsza " + b);
}
else if (c < b && c < a && c < d) 
{
    Console.WriteLine("Najmniejsza " + c);
}
else if (d < b && d < c && d < a) 
{
    Console.WriteLine("Najmniejsza " + d);
}
else 
{
    Console.WriteLine("przynajmniej dwie");
}
//Zad.5
int abc = int.Parse(Console.ReadLine("Podaj bok"));
int abcd = int.Parse(Console.ReadLine("Podaj bok"));
int abcde = int.Parse(Console.ReadLine("Podaj bok"));
if ((abc + abcd)>abcde)
{
    Console.WriteLine("jest szansa");
}
if((abc + abcd)<abcde)
{
    Console.WriteLine("nie ma szans");
}
