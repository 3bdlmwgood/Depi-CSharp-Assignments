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


        #region Q3

        int n1 = TakeValidInteger();
        int n2 = TakeValidInteger();
        int n3 = TakeValidInteger();

        int max = Math.Max(n1, Math.Max(n2, n3));
        int min = Math.Min(n1, Math.Min(n2, n3));

        Console.WriteLine($"Max Element = {max}");
        Console.WriteLine($"Min Element = {min}");

        #endregion



        #region Q4

        int integer = TakeValidInteger();

        if (integer % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");


        #endregion


        #region Q5

        Console.Write("Enter a character: ");
        char ch = char.Parse(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            Console.WriteLine("vowel");
        else
            Console.WriteLine("Consonant");


        #endregion


        #region Q6

        int n = TakeValidInteger();

        for (int i = 1; i <= n; i++)
                    {
            Console.Write(i + " ");
        }

        #endregion


        #region Q7

        int numb = TakeValidInteger();

        for (int i = 1;i <= 12; i++)
        {
            Console.Write(i*numb + " ");
        }

        #endregion


        #region Q8

        int numm = TakeValidInteger();

        for (int i = 1; i <= numm; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        #endregion


        #region Q9
            
        int num1 = TakeValidInteger();
        int num2 = TakeValidInteger();

        int powerResult = (int)Math.Pow(num1, num2);

        Console.WriteLine(powerResult);

        #endregion


        #region Q10

        int m1 = TakeValidInteger();
        int m2 = TakeValidInteger();
        int m3 = TakeValidInteger();
        int m4 = TakeValidInteger();
        int m5 = TakeValidInteger();

        int total = m1 + m2 + m3 + m4 + m5;

        int average = total / 5;

        int percentage = (total * 100) / 500;

        Console.WriteLine($"Total = {total}");
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"Percentage = {percentage}%");

        #endregion

    }

    static int TakeValidInteger()
    {
        int num;
        bool isvalid = false;

        do
        {
            Console.Write("Enter a number: ");
            isvalid = int.TryParse(Console.ReadLine(), out num);
        }
        while (!isvalid);

        return num;
    }

}