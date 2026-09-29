using System;


namespace _3._1
{
    internal class Program
    {

        enum bank_account_type
        {
            current,
            saving
        }
            
        static void Main(string[] args)
        {
            bank_account_type bank_Account_type = bank_account_type.current;
            Console.WriteLine(bank_Account_type);
        }
    }
}
