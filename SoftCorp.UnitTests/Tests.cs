using System.Collections;
using Xunit;

namespace SoftCorp.UnitTests
{
    public class Tests
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void Test(IDictionary<uint, uint> banknotes, uint sum, IDictionary<uint, uint> cash)
        {
            var atm = new ATM();
            atm.InitBanknotes(banknotes);
        
            atm.CalculateCash(sum);
        
            Assert.Equal(cash, atm.Cash);
        }
    }


    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { ATMTestDataConstants.TestBanknotes1, 800, ATMTestDataConstants.TestCash1 };
            yield return new object[] { ATMTestDataConstants.TestBanknotes2, 8000, ATMTestDataConstants.TestCash2 };
            yield return new object[] { ATMTestDataConstants.TestBanknotes3, 700, ATMTestDataConstants.TestCash3 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static class ATMTestDataConstants
    {
        public static IDictionary<uint, uint> TestBanknotes1 => new Dictionary<uint, uint>
        {
            {500, 1},
            {200, 5},
        };
    
        public static IDictionary<uint, uint> TestCash1 => new Dictionary<uint, uint>
        {
            {200, 4}
        };
    
        public static IDictionary<uint, uint> TestBanknotes2 => new Dictionary<uint, uint>
        {
            {5000, 50},
            {500, 5},
            {200, 30}
        };
    
        public static IDictionary<uint, uint> TestCash2 => new Dictionary<uint, uint>
        {
            {200, 30},
            {500, 4}
        };
    
        public static IDictionary<uint, uint> TestBanknotes3 => new Dictionary<uint, uint>
        {
            {500, 1},
            {200, 2},
        };
    
        public static IDictionary<uint, uint> TestCash3 => new Dictionary<uint, uint>
        {
            {200, 30},
            {500, 4}
        };
    }
}