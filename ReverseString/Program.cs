class program
{
    static void Main()
    {
        string str;
        string revstr = "";
        Console.WriteLine("Enter a String type value");
        str = Console.ReadLine().ToLower();
        //str = str.ToLower();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            revstr = revstr + str[i];
        }
        Console.WriteLine(revstr);
        Console.ReadLine();
    }
}