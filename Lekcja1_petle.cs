//Zadanie 1
int n1 = 10, n2 = 20;
if(n1 > n2)
  Console.WriteLine("n1 jest większe od n2");
else if(n1 == n2)
  Console.WriteLine("n1 jest równe n2");
else 
  Console.WriteLine("n1 jest mniejsze od n2");

//Zadanie 2
for(int i = 0; i < 10; i++)
  Console.Write("C# C# ");

Console.WriteLine();

//Zadanie 3
int n = 10;
for(int i = 0; i <= n; i++)
{
  Console.Write($"{i} - ");
  if(i % 2 == 0)
    Console.Write(" Nieparzysta");
  else
    Console.Write(" Parzysta");
  Console.WriteLine();
}

//Zadanie 4
var n0 = 5; //n jest już zajęte
for(int i = n0; i > 0; i--) {
  for(int j = n0; j >= i; j--)
    Console.Write("* ");
  Console.WriteLine();
}

//Zadanie 5
Random rand = new Random();
int exam = rand.Next(0, 101);
switch(exam) 
{
  case int n when (n < 0 || n > 100):
    Console.WriteLine("Wartość poza zakresem");
    break;

  case int n when (n >= 0 && n <= 39):
    Console.WriteLine("Ocena Niedostateczna");
    break;

  case int n when (n >= 40 && n <= 54):
    Console.WriteLine("Ocena Dopuszczająca");
    break;

  case int n when (n >= 55 && n <= 69):
    Console.WriteLine("Ocena Dostateczna");
    break;

  case int n when (n >= 70 && n <= 84):
    Console.WriteLine("Ocena Dobra");
    break;

  case int n when (n >= 85 && n <= 98):
    Console.WriteLine("Ocena Bardzo Dobra");
    break;

    case int n when (n >= 99 && n <= 100):
      Console.WriteLine("Ocena Celująca");
      break;  
}

