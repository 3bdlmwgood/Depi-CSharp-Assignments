using System;

class Program
{
    static void Main(string[] args)
    {
        #region Q1

        int number;
        bool isValidInput = false;

        do
        {
            Console.Write("Enter a number: ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
        }
        while (!isValidInput);
        
        if (number % 3 == 0 && number % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

        #endregion


        #region Q2

        int num;
        bool isvalid = false;

        do
        {
            Console.Write("Enter a number: ");
            isvalid = int.TryParse(Console.ReadLine(), out num);
        }
        while (!isvalid);

        if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Positive");


        #endregion





    }
}