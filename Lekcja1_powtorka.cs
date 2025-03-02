using System;

namespace Jipp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);           
            int result = 5 + 9;*/

            //zadanie 1
            int number = 5;
            float money = 5.14F;
            string text = "text";
            bool isLogged = false;
            char myChar = 'a';
            decimal price = 1566.15M;
            Console.WriteLine($"\n{number}, {money}, {text}, {isLogged}, {myChar}, {price}");

            //zadanie 2
            string myAge = "Age: ";
            int wifeAge = 18;
            var result = myAge + wifeAge;
            Console.WriteLine(Environment.NewLine + result);
            //Wnioski: compilator automatycznie rzutuje zmienna typu int, na string

            //zadanie 3
            bool isTrue = true, isFalse = false, isReallyTrue = true;
            bool and = isTrue && isFalse, or = isTrue || isReallyTrue, negative = !isFalse;
            Console.WriteLine($"\n{and}, {or}, {negative}");
            
            //Zadanie 4
            int a = 5, b = 12;
            int add = a + b;
            int sub = a - b;
            float div = a / b;
            int mul = a * b;
            int mod = a % b;
            Console.WriteLine($"\n{add}, {sub}, {div}, {mul}, {mod}");

            //Zadanie 5

        }
    }
}
