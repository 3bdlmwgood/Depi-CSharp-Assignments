using System;

class Program
{
    static void Main(string[] args)
    {
        #region Q1

        int number;
        bool flag;
        do
        {
            Console.Write("Enter The Number :");
            flag = int.TryParse(Console.ReadLine(), out number);

        } while (!flag);

        Console.WriteLine($"Entered Number is [ {number} ]");

        #endregion
    }
}