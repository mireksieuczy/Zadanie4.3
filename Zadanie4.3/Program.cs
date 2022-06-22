int[] tab1 = { 1, 2, -5, 10, 7, -2 };


int max = tab1[0];
for (int j = 0; j < tab1.Length; j++)
{
    if (tab1[j] > max)
    {
        max = tab1[j];
    }
}
Console.WriteLine("Najwieksza wartosc tablicy to: {0}", max);
Console.WriteLine("Pozycja najwiekszej wartosci to: {0}", Array.IndexOf(tab1, 10));
Console.WriteLine();

int min = tab1[0];
for (int k = 0; k < tab1.Length; k++)
{
    if (tab1[k] < min)
    {
        min = tab1[k];
    }
}
Console.WriteLine("Najmniejsza watosc tablicy to: {0}", min);
Console.WriteLine("Pozycja namniejszej wartosci to: {0}", Array.IndexOf(tab1, -5));
Console.WriteLine();

int suma = 0;
double srednia = 0;
for (int i = 0; i < tab1.Length; i++)
{
    suma = suma + tab1[i];
    srednia = (double)suma / tab1.Length;
}
Console.WriteLine("Srednia wartosc wszystkich elementow to: {0}", srednia);
Console.WriteLine();

int[] dodatnie = new int[tab1.Length];

for (int i = tab1.Length - 1; i >= 0; i--)
    if (tab1[i] > 0)
        dodatnie[tab1.Length - i - 1] = tab1[i];

int sumaW = 0;
for (int i = 0; i < dodatnie.Length; i++)
{
    int ileW = 0;
    if (dodatnie[i] > 0) ileW++;

    sumaW = sumaW + ileW;
}
Console.WriteLine("W tab1 znajduja sie {0} wartosci dodatnie.", sumaW);
Console.ReadKey();