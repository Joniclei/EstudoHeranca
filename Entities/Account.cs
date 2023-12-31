using System;

namespace Estudoheranca.Entities
{
  class Account
  {
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }

    public Account()
    {

    }

    public Account(int number, string holder, double balance)
    {
      this.Number = number;
      this.Holder = holder;
      this.Balance = balance;
    }

    public virtual void WhithDraw(double amount)
    {
      this.Balance -= amount + 5.0;
    }

    public void Deposit(double amount)
    {
      this.Balance += amount;
    }
  }
}
