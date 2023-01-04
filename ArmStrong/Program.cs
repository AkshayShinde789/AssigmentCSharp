class program
{
    static void Main()
    {
        int cube; int rem; int temp; int result = 0;
        Console.WriteLine("Enter a number");
        int Number = Convert.ToInt32(Console.ReadLine());
        temp = Number;
        while(Number != 0)
        {

        rem = Number % 10;
            //Console.WriteLine(rem);
        cube = rem * rem * rem;
            //Console.WriteLine(cube);

        result = result + cube;
           // Console.WriteLine(result);
       Number = Number / 10;
           // Console.WriteLine(Number);
        }
        Number = temp;

        if (Number == result)
        {
            Console.WriteLine("Armstrong number");
        }
        else
        {
            Console.WriteLine("Not Armstrong Number");
        }

        Console.ReadLine();
    }
}