// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");
    
List<int> listNumbers = new List<int>();

for (int i = 0; i < 100; i++)
{
    listNumbers.Add(i);
}


List<int> listMultipliesOf7 = new List<int>();

//listMultipliesOf7 = LinqQueryForma1(listNumbers);

foreach (var item in listMultipliesOf7)
{
    Console.WriteLine(item);
}


Console.WriteLine();


listMultipliesOf7 = LinqQueryForma2(listNumbers);

foreach (var item in listMultipliesOf7)
{
    Console.WriteLine(item);
}


//Methods LinQ
static List<int> LinqQueryForma1(List<int> listNumbers)
{
    var multipliesOf7 = from number in listNumbers
                        where number % 7 == 0
                        select number;
    
    return (List<int>)multipliesOf7;
}

static List<int> LinqQueryForma2(List<int> listNumbers)
{
    IEnumerable<int> multipliesOf7 = listNumbers.Cast<int>().Where(p => p % 7 == 0);

    return multipliesOf7;
}

