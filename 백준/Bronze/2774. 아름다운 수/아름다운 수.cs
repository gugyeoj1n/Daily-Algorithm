using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        for(int i = 0; i < T; i++)
        {
            string input = Console.ReadLine();
            List<char> arr = new List<char>();
            for(int j = 0; j < input.Length; j++)
            {
                if(!arr.Contains(input[j]))
                    arr.Add(input[j]);
            }
            Console.WriteLine(arr.Count);
        }
    }
}