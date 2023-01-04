/*class program
{
    static void Main()
    {
        int a = 0; int b = 1; int c;
        Console.WriteLine($"Enter a number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a}\n{b}");

        for (int i = 1; i< num; i++)
        {
            c = a + b;
            Console.WriteLine($"{c}");
            a = b;
            b = c;
        }
        Console.ReadLine();
    }
}*/

using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int rem = num % 10;
        Console.WriteLine(rem);
        int RevNum = 0;
        RevNum = RevNum * 10 + rem;
        Console.WriteLine(RevNum);
        num = num / 10;
        Console.WriteLine(num);


        Console.ReadLine();
    }
}