using System.Collections.Generic;

public class Solution {
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );

        int n = int.Parse( sr.ReadLine( ) );
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            string input = sr.ReadLine( );

            if (input.Length % 2 != 0)
                continue;
            
            Stack<char> stack = new Stack<char>( );
            for ( int j = 0; j < input.Length; j++ )
            {
                if( stack.Count > 0 && stack.Peek( ) == input[j] )
                    stack.Pop( );
                else
                    stack.Push( input[j] );
            }
            
            result += stack.Count == 0 ? 1 : 0;
        }
        
        Console.WriteLine( result );
    }
}