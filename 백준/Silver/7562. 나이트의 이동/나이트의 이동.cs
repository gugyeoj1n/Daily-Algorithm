using System.Collections.Generic;

public class Solution
{
    public static int[] dx = { -2, -1, 1, 2, -2, -1, 1, 2 };
    public static int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

    public static int BFS( int len, int curX, int curY, int targetX, int targetY )
    {
        Queue<( int, int, int )> queue = new Queue<(int, int, int)>( );
        bool[,] visited = new bool[len, len];
        queue.Enqueue( ( curX, curY, 0 ) );

        while ( queue.Count > 0 )
        {
            var ( x, y, cnt ) = queue.Dequeue( );
            if( x == targetX && y == targetY )
                return cnt;

            for ( int i = 0; i < 8; i++ )
            {
                int nextX = x + dx[ i ];
                int nextY = y + dy[ i ];

                if ( nextX == targetX && nextY == targetY )
                    return cnt + 1;
                
                if (nextX < 0 || nextX >= len || nextY < 0 || nextY >= len)
                    continue;

                if ( !visited[nextX, nextY] )
                {
                    visited[nextX, nextY] = true;
                    queue.Enqueue( ( nextX, nextY, cnt + 1 ) );
                }
                
            }
        }

        return -1;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int n = int.Parse( sr.ReadLine( ) );
        for ( int i = 0; i < n; i++ )
        {
            int len = int.Parse( sr.ReadLine( ) );
            int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            int curX = inputs[0], curY = inputs[1];
            inputs =  Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            int targetX = inputs[0], targetY = inputs[1];
            
            Console.WriteLine( BFS( len, curX, curY, targetX, targetY ) );
        }
    }
}