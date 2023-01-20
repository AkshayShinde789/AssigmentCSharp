class Program
{
  static void Main()
    {
        int[] num = { 10, 20, 15, 40 };
        int sum = 30; 
        for(int i = 0; i < num.Length; i++)
        {
            for (int j =0; j < num.Length; j++)
            {
                if (num[i]+ num[j] == sum)
                {
                    Console.WriteLine($"({num[i]} ,{num[j]})");

                }
            }
        
        }

        //Console.WriteLine(sum);
        Console.ReadLine();
    }
}