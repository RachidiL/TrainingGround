using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Account
    {
        // Make sure to remove events if you are no longer listenig to it,
        // bevore you close the application -
        // otherwise you could create an memory overflow. 
        // Use class as argumets. 
        // You don't have to inherit from EventsArgs anymore (but you should - if you don't have an 
        // trivial reason not to do that)
        public event EventHandler<string> TransactionApprovedEvent;
        public event EventHandler<decimal> OverdraftEvent;

        public string AccountName { get; set; }
        public decimal Balance { get; private set; }
        private List<string> _transaction = new List<string>();

        public IReadOnlyList<string> Transactions
        {
            get { return _transaction.AsReadOnly(); }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transaction.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }

        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            // Ensure we have enough money
            if(Balance >= amount)
            {
                _transaction.Add($"Withdrow {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                // we don't have enough money so we check to see if we have a backup account
                if(backupAccount != null)
                {
                    // Checks to see if we have enough money in the backup account
                    if((backupAccount.Balance + Balance) > amount)
                    {
                        // We have enough backup funds so transfar the amount to this account
                        // and then complete the transaction
                        decimal amountNeeded = amount - Balance;
                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                        // This should always be tru but we will check anyway
                        if(!overdraftSucceeded)
                        {
                            // the overdraft failed so this transaction failde.
                            return false;
                        }

                        AddDeposit("Overdraft Protection Deposit", amountNeeded);
                        _transaction.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionApprovedEvent?.Invoke(this, paymentName);
                        OverdraftEvent?.Invoke(this, amountNeeded);
                        return true;

                    }
                    else
                    {
                        // Not enough backup funds to do anything
                        return false;
                    }
                }
                else
                {
                    // No backup so we fail and do nothing
                    return false;
                }
            }
        }
    }
}
