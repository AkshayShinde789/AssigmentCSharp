class program
{
    static void Main()
    {
       int Heighest = 0; int SecondHeighest = 0;
        int[] num = { 11, 12, 32, 424, 435, 5435 };
        for(int i = 0; i < num.Length; i++)
        {
            int NumberOFItem = num[i];
            if(NumberOFItem > Heighest)
            {
                SecondHeighest = Heighest;
                Heighest = NumberOFItem;
            }
            else if(NumberOFItem > SecondHeighest && NumberOFItem < Heighest)
            {
                SecondHeighest = NumberOFItem;
            }
        }
        Console.WriteLine($"H")
        Console.ReadLine();
    }
}