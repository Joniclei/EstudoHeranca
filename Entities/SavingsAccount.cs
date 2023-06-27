using System;

namespace Estudoheranca.Entities
{
  class SavingsAccount : Account
  {
    public double InteresRate { get; set; }

    public SavingsAccount()
    {

    }

    public SavingsAccount(int number, string holder, double balance, double interesrate) : base(number, holder, balance)
    {
      this.InteresRate = interesrate;
    }

    public void UpdateBalance ()
    {
      this.Balance += Balance * InteresRate;
    }

   public override void WhithDraw(double amount)
   {
      base.WhithDraw(amount);
      Balance -= 2;

   }

  }
}
