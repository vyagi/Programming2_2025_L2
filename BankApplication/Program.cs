//var bankAccount1 = new BankAccount();
//bankAccount1.Deposit(100);

//var bankAccount2 = new DebitAccount();
//bankAccount2.Deposit(100);

//List<BankAccount> myAccounts = [bankAccount1, bankAccount2];

//foreach (var account in myAccounts)
//{
//    Console.WriteLine(account.Withdraw(200));
//}
Console.WriteLine("");

public class DebitAccount : BankAccount
{
    private static readonly decimal _debitLimit = 100;

    public override decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Amount must be positive");

        if (_balance + _debitLimit >= amount)
        {
            _balance -= amount;
            return amount;
        }
        var moneyToReturn = _balance + _debitLimit;
        _balance = -_debitLimit;
        return moneyToReturn;
    }
}

public abstract class BankAccount
{
    protected decimal _balance;

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Amount must be positive");
        _balance += amount;
    }

    public virtual decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Amount must be positive");
        if (_balance >= amount)
        {
            _balance -= amount;
            return amount;
        }
        var moneyToReturn = _balance;
        _balance = 0;
        return moneyToReturn;
    }
}