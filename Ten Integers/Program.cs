int[] tenIntegers = new int[10];

for (int i = 0; i < tenIntegers.Length; i++)
{
    Console.Write("=============\n" + (i + 1) + ".Enter number: ");
    Console.WriteLine();
    int n = int.Parse(Console.ReadLine());
    tenIntegers[i] = n;
}

Console.WriteLine("\nHighest number is: " + tenIntegers.Max());

Console.WriteLine("\nYour numbers in order: ");
foreach (int n in tenIntegers)
{
    Console.Write(n + " ");
}

Console.WriteLine("\nYour numbers in reverse order: ");
foreach (int n in tenIntegers.Reverse())
{
    Console.Write(n + " ");
}