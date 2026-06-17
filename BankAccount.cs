using ClassesInCapsul;

namespace ExampleOOP;

public class BankAccount
{
    private string cardNumber;
    private string pin;
    
    public bool IsCardValid { get; set; }
    public bool IsPinVerified { get; set; }
    public decimal Balance { get; set; }
    public string Pin { get; set; }
    
    public void InsertCard()
    {
        Console.WriteLine("Ваше имя на языке роблокс (16 цифр карты)");
        if (cardNumber.Length < 16)
        {
            Console.WriteLine("connect is succesful");
            IsCardValid = true;
        }
        else
        {
            Console.WriteLine("connection failed");
            IsCardValid = false;
        }
    }

    public void VerifyPin(string pin)
    {
        Console.WriteLine("фамилия на языке роблокс (пин)");
        if (pin.Length <= 4)
        {
            Console.WriteLine("pin is correct");
            IsPinVerified = true; 
        }

        else
        {
            Console.WriteLine("failed");
            IsPinVerified =  false;
        }
        
    }
    
    public bool Withdraw()
    {
        Console.WriteLine("insert amount of money: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        if (Balance - amount > 0)
        {
            Balance = Balance - amount;
            Console.WriteLine("withdraw successful");
            return true;
        }
        else
        {
            Console.WriteLine("not enough money on balance");
            return false;
        }
    }

    public bool Deposit()
    {
        Console.WriteLine("insert amount of money: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        if (amount < 0)
        {
            Console.WriteLine("it cannot be less then 0");
            return false;
        }

        else
        {
            Console.WriteLine("deposit is successful");
            Balance = amount + Balance;
            return true;
        }
    }

    public bool Transfer(string targetAccount, decimal amount)
    {
        throw new NotImplementedException();
    }

    public void ChangePin()
    {
        
    }

    public void PrintReceipt()
    {
        throw new NotImplementedException();
    }
    
    public void Logout()
    {
    }


    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("-----MENU----");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw: ");
            Console.WriteLine("4. Logout");
            Console.WriteLine("5. Exit");

            Console.WriteLine("choose option: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("incorrect input. ");
                continue;
            }
            

            switch (choice)
            {
                case 1: //смотрим баланс
                    
                case 2: //функция депозита, вводим сумму
                   
                 
                    break;
                case 3:
                   
                    break;
                case 4 :
                    Logout();
                    break;
                
                case 5:
                    return;

                default: Logout(); break;
            }
        }
    }

    private bool isAuthorised()
    {
        if (!IsCardValid)
        {
            Console.WriteLine("card wasnt insert");
            return false;
        }

        if (!IsPinVerified)
        {
            Console.WriteLine("pin wasnt verified");
            return false;
        }

        return true;
    }
}

