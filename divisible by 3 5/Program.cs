class program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num % 3 == 0 || num % 5 == 0)
        {
            Console.WriteLine($"{num} is divisible by 3 and 5");
        }
        else if(num % 3 == 0)
        {
            Console.WriteLine($"{num} is divisible by 3");
        }
        else if(num % 5 == 0)
        {
            Console.WriteLine($"{num} is divisible by 5");
        }
        else
        {
            Console.WriteLine($"{num} is not divisible by 3 & 5");
        }
        Console.ReadLine();
    }
}