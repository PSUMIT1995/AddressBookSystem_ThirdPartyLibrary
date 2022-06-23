using System;
namespace AddressBookThirdPartyLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book");
            //calling operation management class that contains operation
            OperationManagement operationManagement = new OperationManagement();

            //non-static method 
            operationManagement.ReadInput();
            Console.Read();

        }
    }
}