using Microsoft.VisualStudio.TestPlatform.TestHost;
using ATM;
using Program = ATM.Program;

namespace ATM_Test1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        decimal ViewBalance()
        {
            return 10m;
        }

        [Theory]
        [InlineData(1)]
        public void TestViewBalance(decimal value) 
        {
            Program.Deposit(value);
            Assert.Equal(value, Program.ViewBalance());
        }
    }
}