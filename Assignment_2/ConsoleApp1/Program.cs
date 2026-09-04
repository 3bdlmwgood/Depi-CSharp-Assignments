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


        #region Q3

        float point = 3.14f;
        float point2 = 2.71f;

        float sum = point + point2;

        Console.WriteLine(sum); // This will output the sum of the two float numbers.

        #endregion


        #region Q4

        string Name = "Abdallah Mohamed";

        string substring = Name.Substring(0, 8);

        Console.WriteLine(substring); // This will output the first 8 characters of the string.

        #endregion
    }
}