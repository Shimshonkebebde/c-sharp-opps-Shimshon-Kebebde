using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_opps_Shimshon_Kebebde.BankApp
{
    public class Account
    {
        Owner owner = new Owner("Shimshon", "kebede");
        double balance;
        int overdraft;
        int maxOverdraft = -90000;
       
        
        public Account(Owner owner ,double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overdraft = overdraft;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public int GetOverdraft()
        {
            return overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft <= Math.Abs(maxOverdraft))
                this.overdraft = overdraft;
        }

        public void Deposit(double p)
        {
            balance += p;
            return;
        }

        public void Withdraw(double s)
        {
            if(balance - s >= -overdraft)
            {
                this.balance -= s;
            }
           
        }
        public Owner GetOwner()
        {
            return owner;
        }
       
    }
}
