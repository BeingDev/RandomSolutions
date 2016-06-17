/**
*http://www.geeksforgeeks.org/generate-all-binary-strings-from-given-pattern/
* Generate all binary strings from given pattern
* 
* Given a string containing of ‘0’, ‘1’ and ‘?’ wildcard characters, 
* generate all binary strings that can be formed by replacing each wildcard 
* character by ‘0’ or ‘1’.
* 
* Input str = "1??0?101"
Output: 
10000101
10001101
10100101
10101101
11000101
11001101
11100101
11101101
* 
*/
namespace RandomSolutions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class GenerateBinaryStringForGivenPattern
    {
        static void Main(string[] args)
        {
            var input = "1??0?101";
            //PrintPattern(input, 0);
            PrintPatternWithQueue(input);
        }
        static void PrintPattern(string input, int inx)
        {
            if (input.Length == inx)
            {
                Console.WriteLine(input);
                return;
            }

            if (input[inx].Equals('?'))
            {
                StringBuilder sb = new StringBuilder(input);

                //replacing ? with 0 at index: inx
                sb[inx] = '0';
                PrintPattern(sb.ToString(), inx + 1);


                //replacing ? with 1 at index: inx
                sb[inx] = '1';
                PrintPattern(sb.ToString(), inx + 1);
            }
            else
            {
                inx++;
                PrintPattern(input, inx);
            }
        }

        static void PrintPatternWithQueue(string input)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(input);

            while (queue.Count > 0)
            {
                var currentString = queue.Peek();
                var inx = currentString.IndexOf('?');
                if (inx > 0)
                {
                    StringBuilder sb = new StringBuilder(currentString);

                    sb[inx] = '0';
                    queue.Enqueue(sb.ToString());

                    sb[inx] = '1';
                    queue.Enqueue(sb.ToString());
                }
                else
                {
                    Console.WriteLine(currentString);
                }
                queue.Dequeue();
            }
        }

    }
}
