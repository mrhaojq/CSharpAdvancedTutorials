using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.GenericsMethods
{
  public  class Account
    { 
        public string Name { get; }
        public Decimal Balance { get; private set; }

        public Account(string name, Decimal balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
