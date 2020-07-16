using System;

namespace Number_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string number = r.Next(0, 100).ToString();
            string input = "";

            while (true)
            {
                Console.WriteLine("Type a number between 0 and 100");
                input = Console.ReadLine();
                if (int.Parse(input) > int.Parse(number))
                    Console.WriteLine("Too Hight");
                if(int.Parse(input) < int.Parse(number))
                    Console.WriteLine("Too Low");
                if(int.Parse(input) == int.Parse(number))
                    Console.WriteLine("You win");
                    break;
            }             
        }
    }
}
