
BankAcccount bankAccount = new BankAcccount();
Console.WriteLine("Welcome to the Bank Account Management System!");
Console.WriteLine("Enter the account number:");
bankAccount.Accountnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the account Name:");
bankAccount.AccountName = Console.ReadLine();
bankAccount.Bankname = "Bank Masr";
bankAccount.Branechname = "Bilqas branch";
bankAccount.AccountCurrencyName = "EGP";
Console.WriteLine($"your account name is {bankAccount.AccountName} and your account number is {bankAccount.Accountnumber} in {bankAccount.Bankname} at {bankAccount.Branechname} .");

Console.WriteLine("Enter amount to deposit:");
decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
bankAccount.Deposit(depositAmount);

Console.WriteLine("Enter amount to withdraw:");
decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
bankAccount.WithDrawn(withdrawAmount);
bankAccount.DisplayAccount();
internal class BankAcccount
{
    public string Bankname;
    public string Branechname;
    public string AccountName;
    public int Accountnumber;
    public decimal AccountBalance;
    public string AccountCurrencyName; 

    public void Deposit(decimal amount)
    {
        AccountBalance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {AccountBalance:0.00}");
    }
    public  void WithDrawn(decimal amount)
    {
        if (amount > AccountBalance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            AccountBalance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New Balance: {AccountBalance:0.00}");
        }
    }
  public void DisplayAccount()
    {

        Console.WriteLine($"Account Name: {AccountName}");
        Console.WriteLine($"Account Number: {Accountnumber}");
        Console.WriteLine($"Bank Name: {Bankname}");
        Console.WriteLine($"Branch Name: {Branechname}");
        Console.WriteLine($"Account Balance: {AccountBalance:0.00} {AccountCurrencyName}");

    }
}
