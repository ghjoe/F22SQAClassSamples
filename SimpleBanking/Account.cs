﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBanking
{
    internal class Account
    {
        private static int count = 0;
        public int Id { get; private set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public bool IsChequing { get; set; }

        public decimal Balance { get; private set; }

        public Account(string first, string last, bool chequing)
        {
            Id = ++count;
            Balance = 0;
            FName = first;
            LName = last;
            IsChequing = !chequing;
        }

        public bool Deposit (decimal amount)
        {
            Balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (!IsChequing && amount > Balance)
                return false;

            Balance += amount;
            return true;
        }

        public decimal OverdraftFee()
        {
            if (IsChequing && Balance < 0)
                return 5.00M;
            else
                return 0;
        }

        public decimal InterestEarned()
        {
            if (IsChequing)
                return 0;
            else
            {
                if (Balance > 10000)
                    return .01M * 10000 + .02M * (Balance - 1000);
                else
                    return .01M * Balance;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, {FName} {LName}, Chequing: {IsChequing}";
        }

    }
}

/// TC1: Negative savings balanced prevented and shows error
/// TC2: No interest provided for chequing accounts with positive balances 
/// TC3: Adding three deposits followed by three withdrawals of same amount leads to zero balance 
/// TC4: Negative chequing balance results in overdraft charge
/// TC5: Savings balances less than 10K get 1% interest on whole amount
/// TC6: Savings balances of more that 10K get 1% interest on first 10K and 2% on balances over $10K (use $20,000 as test balance)