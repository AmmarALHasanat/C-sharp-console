using C__Learning.OOP.Abstraction;

namespace C__Learning.OOP.Encapsulation
{
    class Program : ProgramBase
    {
        public override void Run()
        {
            Console.WriteLine("Encapsulation Program");
            BankAccount bankAccount = new BankAccount(50);

            Console.WriteLine(bankAccount.GetBalance());
            bankAccount.Deposit(20);
            Console.WriteLine(bankAccount.GetBalance());

            bankAccount.Withdraw(10);
            Console.WriteLine(bankAccount.GetBalance());

            Console.WriteLine();
            Console.WriteLine("#######################");
            Console.WriteLine();

        }
    }
}