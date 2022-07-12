long n=9;
List<long> listOfInts = new List<long>();
List<long> listOfReverseInts = new List<long>();

while (n>0)
{
    listOfInts.Add(n % 2);
    n /= 2;
}
listOfInts.Reverse();
List<long> predigits = new List<long>();
if (listOfInts.Count < 32)
{
    for (int i = 0; i < 32- listOfInts.Count; i++)
    {
        predigits.Add(0);
    }
    predigits.AddRange(listOfInts);

}
Console.WriteLine($"predigits.Count:{predigits.Count}");
predigits.ForEach(i =>
{
    Console.Write($"{i}");
    
}
);
Console.WriteLine("");
Console.WriteLine($"1***********************************");
for (int i = 0; i < predigits.Count; i++)
{
    if (predigits[i] == 1)
    {
        predigits[i]=0;
    }
    else if (predigits[i] == 0)
    {
        predigits[i]=1;
    }

}
Console.WriteLine("");
Console.WriteLine($"2***********************************");
predigits.ForEach(i =>
{
    Console.Write($"{i}");

}
);
Console.WriteLine("");
Console.WriteLine($"***********************************");
long deci = 0;
predigits.Reverse();
for (int i = 0; i < predigits.Count; i++)
{
    Console.WriteLine($"#{predigits[i]}#");

    if (predigits[i] == 1)
    {
        Console.Write($"{(long)(Math.Pow(2, i))}*");
        deci = deci + (long)(Math.Pow(2, i));
    }

}
Console.WriteLine("");
Console.WriteLine($"**deci:{deci}*********************************");



