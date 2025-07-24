using System.Collections.Generic;

public class Solution
{
    public static int[,] map;
    public static bool[,] visited;
    public static int w, h;
    public static int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
    public static int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

    public static void BFS( int y, int x )
    {
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        queue.Enqueue( ( y, x ) );
        visited[y, x] = true;

        while ( queue.Count > 0 )
        {
            var ( curY, curX ) = queue.Dequeue( );
            for ( int i = 0; i < 8; i++ )
            {
                int nextY = curY + dy[i];
                int nextX = curX + dx[i];
                if ( nextX < 0 || nextX >= w || nextY < 0 || nextY >= h )
                    continue;
                if ( map[nextY, nextX] == 1 && !visited[nextY, nextX] )
                {
                    visited[nextY, nextX] = true;
                    queue.Enqueue( ( nextY, nextX ) );
                }
            }
        }
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs;
        while ( true )
        {
            inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            w = inputs[0];
            h = inputs[1];
            if ( w == 0 && h == 0 )
                break;
            
            map = new int[h, w];
            visited = new bool[h, w];
            for ( int i = 0; i < h; i++ )
            {
                inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
                for ( int j = 0; j < w; j++ )
                    map[i, j] = inputs[j];
            }

            int count = 0;
            for ( int i = 0; i < h; i++ )
            {
                for ( int j = 0; j < w; j++ )
                {
                    if ( map[i, j] == 1 && !visited[i, j] )
                    {
                        count++;
                        BFS( i, j );
                    }
                }
            }
            
            Console.WriteLine( count );
        }
    }
}