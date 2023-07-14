using System;
using ATM;
using Program = ATM.Program;

namespace ATM
{
    public class Program
    {
        public static decimal balance = 0m;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Of Joe");
            UserInterface();
        }

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
                balance -= amount;
                return balance;
            }
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return balance;
            }
            else
            {
                return balance += amount;
            }
        }
        public static void UserInterface()
        {
            Console.WriteLine("Welcome to Joe's Bank");
            string choice = " "; //= Console.ReadLine();

            while (choice != "exit")
            {
                //Console.WriteLine("This is your balance {0}", ViewBalance());
                //Console.WriteLine("This is your new balance", Deposit(20m));
                //Console.WriteLine("View your balance here", ViewBalance());
                //Console.WriteLine("How much would you like?", Withdraw(15));
                //Console.WriteLine("Your have left", ViewBalance());

                Console.WriteLine("How may we help you today?");
                Console.WriteLine("1. View Balance, 2. Withdraw, 3. Deposit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        decimal balance = ViewBalance();
                        Console.WriteLine("Current Balance: $" + balance);
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount to withdraw:");
                        string withdrawAmountInput = Console.ReadLine();
                        decimal withdrawAmount;
                        if (decimal.TryParse(withdrawAmountInput, out withdrawAmount))
                        {
                            if(withdrawAmount > ViewBalance())
                            {
                                Console.WriteLine("Insufficient funds");
                                break;
                            }
                            decimal newBalance = Withdraw(withdrawAmount);
                            if (newBalance != -1)
                                Console.WriteLine("Withdrawn: $" + withdrawAmount + ", New Balance: $" + newBalance);
                            else
                                Console.WriteLine("Insufficient funds");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter the amount to deposit:");
                        string depositAmountInput = Console.ReadLine();
                        decimal depositAmount;
                        if (decimal.TryParse(depositAmountInput, out depositAmount))
                        {
                            decimal newBalance = Deposit(depositAmount);
                            if (newBalance != -1)
                                Console.WriteLine("Deposited: $" + depositAmount + ", New Balance: $" + newBalance);
                            else
                                Console.WriteLine("Invalid amount");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Exiting the application.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
