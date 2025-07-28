using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int n = int.Parse( sr.ReadLine( ) );

        const int INF = 99999;
        int[,] dist = new int[n + 1, n + 1];

        for ( int i = 1; i <= n; i++ )
            for ( int j = 1; j <= n; j++ )
                if ( i == j )
                    dist[i, j] = 0;
                else
                    dist[i, j] = INF;

        while ( true )
        {
            int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            int num1 = input[0], num2 = input[1];
            if ( num1 == -1 && num2 == -1 )
                break;
            dist[num1, num2] = 1;
            dist[num2, num1] = 1;
        }

        for ( int k = 1; k <= n; k++ )
            for ( int i = 1; i <= n; i++ )
                for ( int j = 1; j <= n; j++ )
                    if ( dist[i, j] > dist[i, k] + dist[k, j] )
                        dist[i, j] = dist[i, k] + dist[k, j];
        
        int[] score = new int[n + 1];
        int minScore = INF;

        for ( int i = 1; i <= n; i++ )
        {
            int maxDist = 0;
            for ( int j = 1; j <= n; j++ )
                if ( dist[i, j] > maxDist )
                    maxDist = dist[i, j];
            score[i] = maxDist;
            if ( score[i] < minScore )
                minScore = score[i];
        }

        List<int> result = new List<int>( );
        for ( int i = 1; i <= n; i++ )
            if ( score[i] == minScore )
                result.Add( i );
        
        Console.WriteLine( $"{minScore} {result.Count}" );
        Console.WriteLine( string.Join( " ", result ) );
    }
}