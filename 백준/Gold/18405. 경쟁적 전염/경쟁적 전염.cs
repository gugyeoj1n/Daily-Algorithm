using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int n = inputs[0];
        int k = inputs[1];

        int[,] map = new int[n, n];
        var initialViruses = new List<( int num, int x, int y )>( );

        for ( int i = 0; i < n; i++ )
        {
            int[] dataInputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for ( int j = 0; j < n; j++ )
            {
                map[i, j] = dataInputs[j];
                if ( map[i, j] != 0 )
                    initialViruses.Add( ( map[i, j], i, j ) );
            }
        }

        int[] targetInputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int s = targetInputs[0], targetX = targetInputs[1], targetY = targetInputs[2];

        var queue = new Queue<( int num, int x, int y, int time )>( );
        
        initialViruses.Sort( ( a, b ) => a.num.CompareTo( b.num ) );

        foreach ( var virus in initialViruses )
            queue.Enqueue( ( virus.num, virus.x, virus.y, 0 ) );
        
        while ( queue.Count > 0 )
        {
            var ( num, x, y, time ) = queue.Dequeue( );

            if ( time == s )
                break;

            for ( int i = 0; i < 4; i++ )
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if ( nx >= 0 && nx < n && ny >= 0 && ny < n && map[nx, ny] == 0 )
                {
                    map[nx, ny] = num;
                    queue.Enqueue( ( num, nx, ny, time + 1 ) );
                }
            }
        }
        
        Console.WriteLine( map[targetX - 1, targetY - 1] );
    }
}