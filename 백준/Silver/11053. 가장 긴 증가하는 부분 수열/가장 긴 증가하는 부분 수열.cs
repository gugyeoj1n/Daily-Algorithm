using System.Collections.Generic;

public class Solution {
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int n = int.Parse( sr.ReadLine( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int[] dp = new int[n];
        for ( int i = 0; i < n; i++ )
            dp[i] = 1;

        for ( int i = 1; i < n; i++ )
            for ( int j = 0; j < i; j++ )
                if ( inputs[j] < inputs[i] )
                    dp[i] = Math.Max( dp[i], dp[j] + 1 );
        
        Console.WriteLine( dp.Max( ) );
    }
}