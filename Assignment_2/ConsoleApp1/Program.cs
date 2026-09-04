using System;
using System.Runtime.InteropServices;

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

        #region Q5

        int num1 = 5;
        int num2 = num1;

        num1 = 20;

        Console.WriteLine(num1.GetHashCode());
        Console.WriteLine(num2.GetHashCode());


        Console.WriteLine(num1);
        Console.WriteLine(num2); // This will output 20 and 5, demonstrating that num2 is a copy of num1 and not affected by the change to num1.

        #endregion


        #region Q6

        Person person1 = new Person();
        person1.Name = "Abdallah";

        Person person2 = person1;

        person2.Name = "Mohamed";

        Console.WriteLine(person1.Name);
        Console.WriteLine(person2.Name); // This will output "Mohamed" for both person1 and person2, demonstrating that they reference the same object in memory.

        #endregion


        #region Q7

        Console.Write("Enter String 1 : ");
        string str1 = Console.ReadLine();
        Console.Write("Enter String 2 : ");
        string str2 = Console.ReadLine();

        string AllStr = str1 + " " + str2;

        Console.WriteLine(AllStr);

        #endregion

    }

    class Person
    {
        public string Name { get; set; }
    }
}