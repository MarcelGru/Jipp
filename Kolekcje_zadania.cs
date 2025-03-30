// Zadanie 1
string[] colors = {"niebieski", "czerwony", "fioletowy", "zielony"};
Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
Console.WriteLine($"Mój ostatni kolor to: {colors[3]}");
Console.WriteLine();
//Zadanie 2
int[] liczby = {0, 4, 8, 12, 16, 28, 44, 72, 116, 188};
for (int i = 0; i < liczby.Length; i++)
    Console.WriteLine($"Liczba: {liczby[i]}");
foreach (var numerek in liczby)
    Console.WriteLine($"Liczba: {numerek}");
int j = 0;
while (j++ < liczby.Length - 1)
    Console.WriteLine($"Liczba: {liczby[j]}");

Console.WriteLine();
//Zadanie 3
List<string> fruits = new List<string>();
fruits.Add("Ananas");
fruits.Add("Pomidor");
fruits.Add("Greipfrut");
fruits.Add("Awokado");
Console.WriteLine(string.Join(", ", fruits));
fruits.Remove("Awokado");
fruits.RemoveAt(0);
Console.WriteLine(string.Join(", ", fruits));

