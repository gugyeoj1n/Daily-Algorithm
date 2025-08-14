using System;

public class Program
{
    public static void Main( string[] args )
    {
        int n = int.Parse( Console.ReadLine( ) );

        int[] t = new int[ n + 1 ];
        int[] p = new int[ n + 1 ];

        for ( int i = 1; i <= n; i++ )
        {
            var input = Console.ReadLine( ).Split( );
            t[ i ] = int.Parse( input[ 0 ] );
            p[ i ] = int.Parse( input[ 1 ] );
        }

        int[] dp = new int[ n + 2 ];

        for ( int i = n; i >= 1; i-- )
        {
            int nextDay = i + t[ i ];

            if ( nextDay > n + 1 )
                dp[ i ] = dp[ i + 1 ];
            else
                dp[ i ] = Math.Max( dp[ i + 1 ], p[ i ] + dp[ nextDay ] );
        }

        Console.WriteLine( dp[ 1 ] );
    }
}