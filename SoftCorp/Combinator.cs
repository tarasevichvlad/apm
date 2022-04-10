namespace SoftCorp;

public class Banknote
{
    public uint Nominal { get; set; }
    //public uint Count { get; set; }
    public Banknote(uint nominal)
    {
        Nominal = nominal;
    }
}



public class BanknoteCombinator
{
    public IDictionary<int, List<Banknote>> s { get; set; } = new Dictionary<int, List<Banknote>>();
    public IEnumerable<IDictionary<int, List<Banknote>>> s1 { get; set; } = new List<IDictionary<int, List<Banknote>>>();
    private IEnumerable<IEnumerable<Banknote>> Source { get; set; }

    public BanknoteCombinator(IEnumerable<IEnumerable<Banknote>> source)
    {
        Source = source;
    }

    public void MakeCombinations()
    {
        var count = s.Keys.Count;
        foreach (var (key, value) in s)
        {
            foreach (var banknote in value.Select((x, i) => i))
            {
                //s1.Add(key, );
            }
        }

        foreach (var c1 in new List<int> {1, 2, 3})
        foreach (var c2 in new List<int> {1, 2, 3})
        foreach (var c3 in new List<int> {1, 2, 3})
            Console.WriteLine($"{c1} - {c2} - {c3}");
    }
    
    
}