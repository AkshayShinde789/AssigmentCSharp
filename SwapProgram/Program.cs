class program
{
    static void Main()
    {
        int a ; int b ; int c;
        Console.WriteLine("enter a number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a number");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        Console.WriteLine(b);
        c = b;
        b = a;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadLine();
    }

}