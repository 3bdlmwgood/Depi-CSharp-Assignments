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


        #region Q2

        string str = "Abdlallah12345";

        int num = Convert.ToInt32(str);

        Console.WriteLine(num); // This will throw a FormatException because the string cannot be converted to an integer.

        #endregion
    }
}