using System.Linq;

public class Solution
{
    public static char[][] map;
    public static bool[,] visited;
    public static int n;

    public static int[] dx = { -1, 0, 0, 1 };
    public static int[] dy = { 0, 1, -1, 0 };

    public static bool isSame( char a, char b, bool blind )
    {
        if( blind )
            if( ( a == 'R' || a == 'G' ) && ( b == 'R' || b == 'G' ) )
                return true;
        
        return a == b;
    }

    public static void BFS( int x, int y, bool blind )
    {
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        queue.Enqueue( ( x, y ) );
        visited[x, y] = true;
        char start = map[x][y];

        while( queue.Count > 0 )
        {
            var ( curX, curY ) = queue.Dequeue( );
            for( int i = 0; i < 4; i++ )
            {
                int nextX = curX + dx[i], nextY = curY + dy[i];
                if( nextX >= 0 && nextX < n && nextY >= 0 && nextY < n )
                {
                    if( isSame(map[nextX][nextY], start, blind) && !visited[nextX, nextY] )
                    {
                        queue.Enqueue( ( nextX, nextY ) );
                        visited[nextX, nextY] = true;
                    }
                }
            }
        }
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        n = int.Parse( sr.ReadLine( ) );
        map = new char[n][];
        
        for( int i = 0; i < n; i++ )
            map[i] = sr.ReadLine( ).ToCharArray( );

        int blinded = 0, nonBlinded = 0;
        
        visited = new bool[n, n];
        for( int i = 0; i < n; i++ )
        {
            for( int j = 0; j < n; j++ )
            {
                if( !visited[i, j] )
                {
                    BFS( i, j, false );
                    nonBlinded++;
                }
            }
        }

        Array.Clear(visited, 0, visited.Length);
        for( int i = 0; i < n; i++ )
        {
            for( int j = 0; j < n; j++ )
            {
                if( !visited[i, j] )
                {
                    BFS( i, j, true );
                    blinded++;
                }
            }
        }

        Console.WriteLine( $"{nonBlinded} {blinded}" );
    }
}