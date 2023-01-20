class program
{
    static void Main()
    {
        int[] num = { 12, 23, 43, 32, 23,49, 11 };
        int heighest = 0;
        for (int i = 0; i < num.Length; i++)
        {
            heighest = num[i];
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    continue;
                }
                if (num[j] > heighest)
                {
                    heighest = num[j] ;
                }
            }
        }

        Console.WriteLine($"{heighest} is a heighest number in given array");

        Console.ReadLine();
    }
}