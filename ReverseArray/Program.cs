class program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13 };
        for(int i = numbers.Length -1 ; i >= 0; i--)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.ReadLine();
    }
}