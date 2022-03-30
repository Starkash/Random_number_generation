using System;

class Random_Num_gen
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Any num ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int j = 1; j <= n; j++)
        {
            Console.WriteLine(rnd.Next(10, 50));
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next());


        }


    }
}
