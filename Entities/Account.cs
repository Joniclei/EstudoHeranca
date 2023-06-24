using System;

namespace Estudoheranca.Entities
{
  class Account
  {
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

    public Account()
    {

    }

    public Account(int number, string holder, double balance)
    {
      this.Number = number;
      this.Holder = holder;
      this.Balance = balance;
    }

    public void WhithDraw(double amount)
    {
      this.Balance -= amount;
    }

    public void Deposit (double amount)
    {
      this.Balance += amount;
    }
  }
}
