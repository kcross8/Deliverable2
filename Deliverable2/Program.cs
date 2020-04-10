using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your message? ");
            string input = Console.ReadLine();

            string message = "";
            int checksum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                checksum += char.ToUpper(c);
                message += char.ToUpper(c) - 64 + "-";
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
