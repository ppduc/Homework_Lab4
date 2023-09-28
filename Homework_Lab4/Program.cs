using System.Security.Principal;

namespace Homework_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banking account = new Banking(1000);

            // Step 3: Register the event and callback
            account.BalanceChanged += BalanceChangedHandler;

            // Perform transactions
            account.Deposit(500);
            account.Withdraw(0);

            Console.WriteLine("Current Balance: " + account.GetBalance());

            // Unregister the event if needed
            account.BalanceChanged -= BalanceChangedHandler;
        }

        // Callback method to handle balance change event
        static void BalanceChangedHandler(decimal newBalance)
        {
            Console.WriteLine("Balance has changed. New Balance: " + newBalance);
        }
    }
}