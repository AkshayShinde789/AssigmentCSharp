using System;
class program
{
    static void Main()
    {

        //int sum1 = sum / 2;
        int duplicate = 0;
        int[] num = { 10, 20, 30, 10, 40 };
        for (int i = 0; i < num.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < num.Length - 1; j++)
            {
                if (num[i] == num[j + 1])
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine(num[i] + "" + sum);
        }
        Console.WriteLine($"Duplicate in Array : {duplicate}");

        Console.ReadLine();
    }
}