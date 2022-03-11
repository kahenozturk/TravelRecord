using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSection2.Classes
{
    public class BankAccount
    {

        private float balance;
        public float Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        private string owner;



        public BankAccount(float Balance, string Owner)
        {
            Balance = balance;
            this.owner = Owner;
        }


        public float AddBalance(float balanceToBeAdded)
        {
            balance = balance + balanceToBeAdded; 
            return balance +balanceToBeAdded;
        }

    }
}
