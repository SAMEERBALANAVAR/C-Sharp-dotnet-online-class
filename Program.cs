using System;

namespace BankCustomer
{
  public  class Bank
    {

        // 1.BankCustomer - Sameer
        //Name
        //Branch
        //A / c No
        //Balance - private
        //public  string BankCustomer;
        public string Name;
        public string Branch;
        public int AccountNumber;
        private int Balance;
        public void InputDisplay()
        {
            Console.WriteLine("***Hello there welcome to our bank***");
            Console.WriteLine("Please Enter Your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Branch Name");
            Branch = Console.ReadLine();
            Console.WriteLine("Please Enter Your Account Number");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Bank Balance");
            Balance = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayResult()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Branch);
            Console.WriteLine(AccountNumber);
            Console.WriteLine(Balance);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bank display = new Bank();
            //display.InputDisplay();
            //display.DisplayResult();

            Bank details1 = new Bank();
            Bank details2 = new Bank();
            Bank details3 = new Bank();
            Bank[] details = new Bank[3];
            details[0] = details1;
            details[1] = details2;
            details[2] = details3;


            Console.WriteLine("Enter Your Bank Account Details Here");
            for(int i = 0; i < details.Length; i++)
            {
                details[i].InputDisplay();
            }

            Console.WriteLine("Hello There! Your Bank Account Details Here \n\n");
            for (int i = 0; i < details.Length; i++)
            {
                details[i].DisplayResult();
            }

        }

    }

  
}
 
