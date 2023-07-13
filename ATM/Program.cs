namespace ATM
{
    public class Program
    {
        public static decimal balance = 0m;

        public static decimal ViewBalance()
        {
            return balance;
        }

        public static decimal Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                return balance;
            }
            else
            {
                return balance -= amount;
            }
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                return balance;
            }
            else
            {
                return balance + amount;
            }
        }
        public static void UserInterface()
        {
            Console.WriteLine(ViewBalance());
            Console.WriteLine(Deposit(20m));
            Console.WriteLine(ViewBalance());
            Console.WriteLine(Withdraw(15m));
            Console.WriteLine(ViewBalance());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Of Joe");
            UserInterface();
        }
    }
}
