using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.GenericsMethods
{
    public class Account1 : IAccount
    {
        public string Name { get; }

        public decimal Balance { get; private set; }

        public Account1(string name, Decimal balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
