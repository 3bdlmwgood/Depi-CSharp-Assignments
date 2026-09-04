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

        for (int i = 1; i <= 12; i++)
        {
            Console.Write(i * numb + " ");
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


        #region Q11

        int month = TakeValidInteger();

        switch (month)
        {
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Days in Month: 30");
                break;

            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Days in Month: 31");
                break;

            case 2:
                Console.WriteLine("Days in Month: 28 / 29");
                break;

            default:
                Console.WriteLine("Invalid month");
                break;
        }


        #endregion


        #region Q12

        int FirstNum = TakeValidInteger();
        Console.Write("Enter an operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());
        int secondNum = TakeValidInteger();

        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result = {FirstNum + secondNum}");
                break;
            case '-':
                Console.WriteLine($"Result = {FirstNum - secondNum}");
                break;
            case '*':
                Console.WriteLine($"Result = {FirstNum * secondNum}");
                break;
            case '/':
                if (secondNum != 0)
                    Console.WriteLine($"Result = {FirstNum / secondNum}");
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }

        #endregion


        #region Q13

        Console.Write("Enter a string: ");
        string text = Console.ReadLine();


        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }

        #endregion


        #region Q14

        int integerToRevers = TakeValidInteger();
        int reversed = 0;

        while (integerToRevers != 0)
        {
            int digit = integerToRevers % 10;
            reversed = reversed * 10 + digit;
            integerToRevers /= 10;
        }

        Console.WriteLine($"Reversed: {reversed}");

        #endregion


        #region Q15

        int startNum = TakeValidInteger();
        int endNum = TakeValidInteger();

        for (int TheNumber = startNum; TheNumber <= endNum; TheNumber++)
        {
            if (TheNumber < 2)
                continue;

            bool isPrime = true;

            for (int i = 2; i < TheNumber; i++)
            {
                if (TheNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(TheNumber + " ");
        }

        #endregion


        #region Q16

        int numberToBinary = TakeValidInteger();

        int binary = 0;
        int multiplier = 1;

        while (numberToBinary > 0)
        {
            int remainder = numberToBinary % 2;
            binary += remainder * multiplier;
            numberToBinary /= 2;
            multiplier *= 10;
        }

        Console.WriteLine($"Binary: {binary}");

        #endregion


        #region Q17

        int x1 = TakeValidInteger("Enter x1: ");
        int y1 = TakeValidInteger("Enter y1: ");

        int x2 = TakeValidInteger("Enter x2: ");
        int y2 = TakeValidInteger("Enter y2: ");

        int x3 = TakeValidInteger("Enter x3: ");
        int y3 = TakeValidInteger("Enter y3: ");

        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            Console.WriteLine("The points lie on a single straight line.");
        else
            Console.WriteLine("The points are not lie on a single straight line.");

        #endregion


        #region Q18

        Console.Write("Enter time taken: ");
        double hours = double.Parse(Console.ReadLine());

        if (hours >= 2 && hours <= 3)
        {
            Console.WriteLine("Highly efficient");
        }
        else if (hours > 3 && hours <= 4)
        {
            Console.WriteLine("Increase your speed");
        }
        else if (hours > 4 && hours <= 5)
        {
            Console.WriteLine("Training is required");
        }
        else if (hours > 5)
        {
            Console.WriteLine("You have to leave the company");
        }
        else
        {
            Console.WriteLine("Invalid time");
        }

        #endregion


        #region Q19
        
        int N = TakeValidInteger("Enter N: ");

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == j)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }

            Console.WriteLine();
        }

        #endregion


        #region Q20

        int ArraySize = TakeValidInteger("Enter the size of the array: ");

        int[] numbers = new int[ArraySize];

        int sum = 0;

        for (int i = 0; i < ArraySize; i++)
        {
            numbers[i] = TakeValidInteger($"Enter number {i + 1}: ");
            sum += numbers[i];
        }

        Console.WriteLine($"Sum: {sum}");

        #endregion



        #region Q21

        int[] arr1 = { 5, 2, 7, 10, 9 };
        int[] arr2 = { 3, 6, 1, 8, 4 };

        Array.Sort(arr1);
        Array.Sort(arr2);

        int[] mergedArray = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            mergedArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            mergedArray[arr1.Length + i] = arr2[i];
        }

        Array.Sort(mergedArray);

        foreach (int NUM in mergedArray)
        {
            Console.Write(NUM + " ");
        }

        #endregion


        #region Q22

        int size = TakeValidInteger("Enter Array Size : ");

        int[] arr = new int[size];

        for (int i = 0; i < size   ; i++)
        {
            arr[i] = TakeValidInteger($"Enter element {i + 1}: ");
        }

        bool[] visited = new bool[size];

        for (int i = 0; i < size; i++)
        {
            if (visited[i])
                continue;

            int count = 1;

            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine($"{arr[i]} occurs {count} time(s)");
        }

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

    static int TakeValidInteger(string Message)
    {
        int num;
        bool isvalid = false;
        do
        {
            Console.Write(Message);
            isvalid = int.TryParse(Console.ReadLine(), out num);
        }
        while (!isvalid);
        return num;
    }

}