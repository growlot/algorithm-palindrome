using System;

namespace DerivePalindrome
{
    class Program
    {
        static string DerivePalindrome(string input)
        {
            var output = input;
            for (int i = 0; i < output.Length / 2; i++)
            {
                if (output[i] != output[output.Length - 1 - i])
                {
                    output = output.Insert(output.Length - i, output[i].ToString());
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: app.exe <word>");
                return;
            }
            foreach (var input in args)
            {                
                Console.WriteLine($@"{input} => {DerivePalindrome(input)}");
            }
        }
    }
}
