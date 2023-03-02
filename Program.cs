// See https://aka.ms/new-console-template for more information

// Inital vars
string[] arrayA = new string[4];
string[] arrayB = new string[4];
int j = 0;

for (int i = 0; i < arrayA.Length; i++)
    {
        System.Console.WriteLine("Введите данные: ");
        arrayA[i] = Convert.ToString(Console.ReadLine());
    }

for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
            {arrayB[j] = arrayA[i];
             j += 1;
            }
    }

System.Console.WriteLine($"Массив А: ");
foreach (string line in arrayA)
    Console.Write($"{line} ");

System.Console.WriteLine($"Массив B: ");
foreach (string line in arrayB)
    Console.Write($"{line} ");