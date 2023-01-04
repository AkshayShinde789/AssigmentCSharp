class program
{
    static void Main()
    {
        int num, temp, RevNum = 0, rem;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num; int result = 0;
        //int cube; int result = 0;
        while (num > 0)
        {
            rem = num % 10;
            Console.WriteLine(rem);
            RevNum = RevNum * 10 + rem;
            Console.WriteLine(RevNum);
            num = num / 10;
            Console.WriteLine(num);
        }
        if (RevNum == temp)
        {
            Console.WriteLine("Number is Palindrome");
        }
        else
        {
            Console.WriteLine("Number is not a Palindrome");
        }

        Console.ReadLine();
    }
}