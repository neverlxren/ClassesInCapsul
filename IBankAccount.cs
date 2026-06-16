
namespace ClassesInCapsul;

public interface IBankAccount
{
         bool InsertCard(string cardNumber);
         bool VerifyPin(string pin);
         
         bool Withdraw(decimal amount);
         bool Deposit(decimal amount);
         bool Transfer(string targetAccount, decimal amount);
         void ChangePin(string oldPin, string newPin);
        /* List<Transaction> GetMiniStatement();*/
         void PrintReceipt();
         void Logout();

}