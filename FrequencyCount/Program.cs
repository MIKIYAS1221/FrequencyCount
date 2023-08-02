// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace FrequencyCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You must enter a string.");
            }
            
            Dictionary<string, int> result = FrequencyCount(input);

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static Dictionary<string,int> FrequencyCount(string input)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString().ToLower();
                if (counter.ContainsKey(letter))
                {
                    counter[letter]++;
                }
                else
                {
                    counter.Add(letter, 1);
                }
            }

            return counter;
        }
    }
}