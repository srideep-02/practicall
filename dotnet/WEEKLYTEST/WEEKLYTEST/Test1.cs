    class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialbalance)
        {
            if (initialbalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            balance = initialbalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }
            balance += amount;
            Console.WriteLine($"The Deposited: {amount},New balance {balance} ");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw must be positive");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn:{amount},  New Balance{balance}");
        }
        public decimal Getbalance()
        {
            return balance;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            BankAccount account = new BankAccount(1000);
            account.Deposit(100);
            account.Withdraw(600);
            Console.WriteLine($"Final balance is :{account.Getbalance()}");

        }
    }
