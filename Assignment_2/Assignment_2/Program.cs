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



    }
}