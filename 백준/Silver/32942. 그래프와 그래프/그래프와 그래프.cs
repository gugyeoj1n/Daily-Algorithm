using System.Collections.Generic;

public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int A = input[ 0 ], B = input[ 1 ], C = input[ 2 ];
        for ( int i = 1; i <= 10; i++ )
        {
            List<int> graph = new List<int>( );
            for ( int j = 1; j <= 10; j++ )
                if(A * i + B * j == C) graph.Add( j );
            if ( graph.Count == 0 )
            {
                Console.WriteLine(0);
            }
            else
            {
                string output = "";
                foreach ( int v in graph )
                    output += v + " ";
                Console.WriteLine(output);
            }
        }
    }
}