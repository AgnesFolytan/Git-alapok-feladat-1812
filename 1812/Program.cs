Console.WriteLine("Adjon meg egy számot: ");
int szam = 1;
List<int> lista = new List<int>();
while (szam != 0)
{
    foreach (var item in lista)
    {
        Console.Write(item + ", ");
    }
    szam = int.Parse(Console.ReadLine());
	lista.Add(szam);

}
Console.WriteLine(lista.Min());