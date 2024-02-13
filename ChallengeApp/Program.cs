using System.Diagnostics.CodeAnalysis;

Console.Write("Wpisz liczbe w której chcesz policzyć cyfry    :  ");

int number = int.Parse(Console.ReadLine());

string nuberInString = number.ToString();


char[] letters = nuberInString.ToCharArray();

int[] repeat = new int[10];

foreach (char digit in letters)
{
    int indeks = int.Parse(digit.ToString());
    repeat[indeks]++;
}
Console.WriteLine();
Console.WriteLine("Rozwiązanie  :");
Console.WriteLine();

for (int i = 0; i < repeat.Length; i++)
{
    Console.WriteLine($"Cyfra{i} występuje {repeat[i]} razy.");
}

Console.ReadKey();