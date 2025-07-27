public class Solution
{
    public static int n, m;
    public static int[,] map;
    public static bool[,] visited;
    
    public static int[] dx = { -1, 0, 0, 1 };
    public static int[] dy = { 0, -1, 1, 0 };

    public static int BFS( int x, int y )
    {
        int curArea = 1;
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        visited[x, y] = true;
        queue.Enqueue( ( x, y ) );

        while( queue.Count > 0 )
        {
            var ( curX, curY ) = queue.Dequeue( );
            for( int i = 0; i < 4; i++ )
            {
                int nextX = curX + dx[i], nextY = curY + dy[i];
                if( nextX >= 0 && nextX < n && nextY >= 0 && nextY < m )
                {
                    if( map[nextX, nextY] == 1 && !visited[nextX, nextY] )
                    {
                        visited[nextX, nextY] = true;
                        queue.Enqueue( ( nextX, nextY ) );
                        curArea++;
                    }
                }
            }
        }

        return curArea;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        n = inputs[0];
        m = inputs[1];
        
        map = new int[n, m];
        visited = new bool[n, m];
        for( int i = 0; i < n; i++ )
        {
            int[] row = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for( int j = 0; j < m; j++ )
                map[i, j] = row[j];
        }
        
        int count = 0, maxArea = 0;
        for( int i = 0; i < n; i++ )
        {
            for( int j = 0; j < m; j++ )
            {
                if( map[i, j] == 1 && !visited[i, j] )
                {
                    count++;
                    int curArea = BFS( i, j );
                    maxArea = Math.Max( curArea, maxArea );
                }
            }
        }

        Console.WriteLine( $"{count}\n{maxArea}" );
    }
}