using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] goodString = { "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]" };

            string[] badString = { "[LaunchCode", "Launch]Code[", "[", "][" };

            foreach(string items in badString)
            {
                Console.WriteLine(BalancedBrackets.HasBalancedBrackets(items));
            }
        }
    }
}
