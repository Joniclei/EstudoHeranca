using System;
using System.Runtime.CompilerServices;
using Estudoheranca.Entities;

namespace Estudoheranca
{
  class Program
  {
    public static void Main(string[] args)
    {
      Account a = new Account(100, "a",500);
      Account b = new SavingsAccount(101, "b",500,0.01);

      a.WhithDraw(10);
      b.WhithDraw(10);

      Console.WriteLine(a.Balance);
      Console.WriteLine(b.Balance);




      /*Account ac = new Account(10,"Joao",0.0);
      Account account = new SavingsAccount(10,"",0.0,20);
      BusinessAccount x = new BusinessAccount(11,"Lala ",10.5,500);

      //UpCasting


      Account a = x;
      Account b = new BusinessAccount(11,"Lala ",10.5,5000);
      Account c = new SavingsAccount(11,"Lala ",10.5,500);


      //DowCasting

      BusinessAccount ab = (BusinessAccount)ac;
      ab.Loan(100);

      BusinessAccount bb = (BusinessAccount)account;

      bb.Loan(10); // Aqui ele dara erro account e to tipo SavingAccount para testar faca

      if ( account is Account)
      {
        BusinessAccount bb = (BusinessAccount)account;
      }*/


    }
  }
}
