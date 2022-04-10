using SoftCorp;

var pre = new Dictionary<int, int>
{
    {5 , 1}
};
var tesd = MyClass.Addends(5, pre, new Stack<int>()).Select(x => x.ToList());
var bb = tesd.Select(x => x.GroupBy(x => x)).SelectMany(x => x.ToList());

foreach (var ints in tesd)
{
    Console.WriteLine(string.Join(" + ", ints));
}

//Console.WriteLine(tesd);
//MyClass.Raz(5, new List<int>());

/*var comb = new BanknoteCombinator(new[]
{
    new[]
    {
        new Banknote(5),
        new Banknote(5),
        new Banknote(5)
    },
    new[]
    {
        new Banknote(10),
        new Banknote(10),
        new Banknote(10)
    }
});

comb.MakeCombinations();

var banknotes = new ATM();

try
{
    var maxCashSum = banknotes.GetMaxPossibleSum();
    Console.WriteLine($"Максимальная допустимая сумма: {maxCashSum}");

    Console.Write("Введите сумму: ");
    var sum = uint.Parse(Console.ReadLine());

    if (sum <= maxCashSum)
    {
        banknotes.CalculateCash(sum);
        banknotes.Print();
    }
    else
    {
        Console.WriteLine("Недостаточно банкнот в банкомате");
    }
}
catch (OverflowException _)
{
    Console.WriteLine("Введена недопустимая сумма");
}
catch (BanknoteException e)
{
    Console.WriteLine(e.Message);
}

public class ATM
{
    private IDictionary<uint, uint> ExistBanknotes { get; set; }
    public IDictionary<uint, uint> Cash { get; set; } = new Dictionary<uint, uint>();
    private readonly Random _random = new();

    public ATM()
    {
        ExistBanknotes = new Dictionary<uint, uint>
        {
            {5000, 50},
            {500, 5},
            {200, 30}
        };
    }

    public void InitBanknotes(IDictionary<uint, uint> dictionary)
    {
        ExistBanknotes = dictionary;
    }
    
    public uint GetBanknote(uint sum)
    {
        var result = ExistBanknotes.Where(x => x.Value > 0 && x.Key <= sum).ToList();

        if (!result.Any())
        {
            throw new BanknoteException();
        }

        var maxBanknote = result.Min(x => x.Key);


        ExistBanknotes[maxBanknote] -= 1;

        return maxBanknote;
    }

    public void CalculateCash(uint sum)
    {
        while (sum != 0)
        {
            var nominal = GetBanknote(sum);
            if (Cash.ContainsKey(nominal))
            {
                Cash[nominal] += 1;
            }
            else
            {
                Cash.Add(nominal, 1);
            }

            sum -= nominal;
        }
    }

    public void Print()
    {
        Console.WriteLine("Ваши деньги: ");
        foreach (var (key, value) in Cash)
        {
            Console.WriteLine($"{key} - {value}");
        }
    }

    public uint GetMaxPossibleSum()
    {
        return ExistBanknotes.Aggregate<KeyValuePair<uint, uint>, uint>(0,
            (current, existBanknote) => current + existBanknote.Key * existBanknote.Value);
    }
}

class BanknoteException : Exception
{
    public BanknoteException() : base("Недостаточно банкнот в банкомате")
    {
    }
}*/


 
    


static class  MyClass
{
    public static IEnumerable<IEnumerable<int>> Addends(int n, IDictionary<int, int> pre, Stack<int> addends)
    {
        if (n == 0) yield return addends;
        for (var i = !addends.Any() ? 1 : addends.Peek(); i <= n; ++i)
        {
            addends.Push(i);
            foreach (var j in Addends(n - i, pre, addends)) yield return j;
            addends.Pop();
        }
    }
}