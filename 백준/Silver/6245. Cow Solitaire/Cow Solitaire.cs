using System;
using System.IO;

public class Program
{
    private static int GetCardValue( string card )
    {
        char valueChar = card[0];
        switch ( valueChar )
        {
            case 'A': return 1;
            case 'T': return 10;
            case 'J': return 11;
            case 'Q': return 12;
            case 'K': return 13;
            default: return valueChar - '0';
        }
    }

    public static void Main( string[] args )
    {
        int N = int.Parse( Console.ReadLine( ) );

        int[,] grid = new int[N, N];
        int[,] dp = new int[N, N];

        for ( int i = 0; i < N; i++ )
        {
            string[] line = Console.ReadLine( ).Split( );
            for ( int j = 0; j < N; j++ )
                grid[i, j] = GetCardValue( line[j] );
        }

        for ( int i = N - 1; i >= 0; i-- )
        {
            for ( int j = 0; j < N; j++ )
            {
                if ( i == N - 1 && j == 0 )
                    dp[i, j] = grid[i, j];
                else if ( i == N - 1 )
                    dp[i, j] = grid[i, j] + dp[i, j - 1];
                else if ( j == 0 )
                    dp[i, j] = grid[i, j] + dp[i + 1, j];
                else
                    dp[i, j] = grid[i, j] + Math.Max( dp[i + 1, j], dp[i, j - 1] );
            }
        }

        Console.WriteLine( dp[0, N - 1] );
    }
}