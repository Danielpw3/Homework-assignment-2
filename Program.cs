using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Homework_Assignment_2
{
    internal enum TransactionType
    {
        Buy = -1,
        Sell = 1
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // User inputs
            Console.WriteLine("Enter transaction type (Buy/Sell):");
            string transactionTypeInput = Console.ReadLine();

            Console.WriteLine("Enter nominal value:");
            var nominalInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price:");
            var priceInput = double.Parse(Console.ReadLine());

            var priceOrgiginal = 100;


            // Ternary operators
            TransactionType transactionType = transactionTypeInput.Equals("Buy")
                ? TransactionType.Buy
                : TransactionType.Sell;

            var profitLoss = transactionTypeInput.Equals("Sell")
                ? (priceInput - priceOrgiginal) * nominalInput
                : 0;

            // Value
            var value = (int)transactionType * nominalInput * priceInput;
           

            // Output of the results
            Console.WriteLine($"The value is: {value} DKK");
            Console.WriteLine($"The profitLoss is: {profitLoss} DKK");

            Console.ReadKey();
        }
    }
}
