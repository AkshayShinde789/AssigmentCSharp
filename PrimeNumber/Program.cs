/*class program
{
    static void Main()
    {
        bool Prime = true;
        Console.WriteLine("enter a number");
        int res = int.Parse(Console.ReadLine());
        for (int i = 2; i < res; i++)
        {
            if (res % i  == 0)
            {
                Prime= false;
                break;
            }

        }
        if (Prime)
        {
            Console.WriteLine($"{res} is prime");
        }
        else
        {
            Console.WriteLine($"{res} is not prime");
        }
        Console.ReadLine();
    }
}
*/


/*
class program
{
    static void Main()
    {
        //bool Prime = true;
        Console.WriteLine("Enter a Number");
        int res = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime Number IS :- ");
        for (int i = 2; i < res; i++)
        {
           
                if (res % i != 0)
                {
                    //Prime = false;
                    if (i % 3 != 0)
                    {
                        Console.WriteLine(i);
                    }
      
                }

        }
        *//*if (Prime)
        {
            Console.WriteLine($"{res} is prime");
        }
        else
        {
            Console.WriteLine($"{res} is not prime");
        }*//*
        Console.ReadLine();
    }
}*/


class Program 
{ 
    static void Main(string[] args) 
    {
        int n;//, i, a; 
        Console.Write("Enter any number: "); 
        n = Convert.ToInt32(Console.ReadLine());
        string primeNumbers = "Prime Numbers : ";
        string notPrimeNumbers = "Non Prime Numbers : ";

        bool isNotPrime = false;
        for (int i = 2; i <= n; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if(i % j == 0)
                {
                    // Console.WriteLine($"{i} is not prime");
                    notPrimeNumbers += i.ToString() + " ";
                    isNotPrime = true;
                    break;
                }
            }
            if(!isNotPrime)
            {
                primeNumbers += i.ToString() + " ";
            }
            isNotPrime = false;
        }

        Console.WriteLine(primeNumbers);
        Console.WriteLine(notPrimeNumbers);

        Console.ReadLine();

    }
       
}