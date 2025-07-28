using System.Collections.Generic;

public class Program
{
    public static int[] dx = new int[] { -1, 0, 0, 1 };
    public static int[] dy = new int[] { 0, 1, -1, 0 };

    public static int ROW, COL;
    
    public static char[,] map;
    public static bool[,] visited;
    
    public static int BFS( int x, int y )
    {
        Queue<( int, int, int )> queue = new Queue<( int, int, int )>( );
        queue.Enqueue( ( x, y, 0 ) );
        visited = new bool[ROW, COL];
        visited[x, y] = true;

        int maxDist = 0;

        while ( queue.Count > 0 )
        {
            var ( curX, curY, dist ) = queue.Dequeue( );
            
            maxDist = Math.Max( maxDist, dist );
            
            for ( int i = 0; i < 4; i++ )
            {
                int nextX =  curX + dx[i];
                int nextY =  curY + dy[i];
                if ( nextX >= 0 && nextX < ROW && nextY >= 0 && nextY < COL )
                {
                    if ( !visited[nextX, nextY] && map[nextX, nextY] == 'L' )
                    {
                        visited[nextX, nextY] = true;
                        queue.Enqueue( ( nextX, nextY, dist + 1 ) );
                    }
                }
            }
        }

        return maxDist;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        ROW = input[0]; COL = input[1];
        map = new char[ROW, COL];

        for ( int i = 0; i < ROW; i++ )
        {
            char[] rowInput = sr.ReadLine( ).ToCharArray( );
            for ( int j = 0; j < COL; j++ )
                map[i, j] = rowInput[j];
        }

        int result = 0;
        
        for ( int i = 0; i < ROW; i++ )
            for ( int j = 0; j < COL; j++ )
                if ( map[i, j] == 'L' )
                    result = Math.Max( result, BFS( i, j ) );
        
        Console.WriteLine( result );
    }
}