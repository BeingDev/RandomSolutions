/**
 * http://www.geeksforgeeks.org/kth-non-repeating-character/
 * Given a string and a number k, find the k’th non-repeating character in the string. 
 * Consider a large input string with lacs of characters and a small character set.
 * How to find the character by only doing only one traversal of input string?
 * Examples:
 * Input : str = geeksforgeeks, k = 3
 * Output : r
 * First non-repeating character is f,
 * second is o and third is r.
 * 
 * Input : str = geeksforgeeks, k = 2
 * Output : o
 * Input : str = geeksforgeeks, k = 4
 * Output : Less than k non-repeating characters in input.
 */

namespace RandomSolutions
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class KthNonRepeating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your input:");
            var input = Console.ReadLine();
            Console.WriteLine("Please enter k’th index");
            var k = int.Parse(Console.ReadLine());
            FindKthNonRepeating(input, k);
        }

        static void FindKthNonRepeating(string input, int k)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            List<char> indexList = new List<char>();
            foreach (char c in input)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c] = counts[c] + 1;
                    indexList.Remove(c);
                }
                else
                {
                    counts[c] = 1;
                    indexList.Add(c);
                }
            }
            var indexArr = indexList.ToArray();
            Console.WriteLine(indexArr);
            Console.WriteLine(indexArr[k - 1]);
        }
    }
}
