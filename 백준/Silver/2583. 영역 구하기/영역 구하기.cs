using System.Collections.Generic;

public class Program
{
    public static int[,] map;
    public static bool[,] visited;
    public static int M, N;

    public static int[] dx = { -1, 0, 0, 1 };
    public static int[] dy = { 0, 1, -1, 0 };

    public static int BFS(int x, int y)
    {
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        queue.Enqueue( ( x, y ) );
        visited[x, y] = true;
        int area = 1;

        while ( queue.Count > 0 )
        {
            ( int curX, int curY ) = queue.Dequeue( );

            for ( int i = 0; i < 4; i++ )
            {
                int nextX = curX + dx[ i ];
                int nextY = curY + dy[ i ];
                if ( nextX >= 0 && nextX < M && nextY >= 0 && nextY < N )
                {
                    if ( !visited[nextX, nextY] && map[nextX, nextY] == 0 )
                    {
                        area++;
                        visited[nextX, nextY] = true;
                        queue.Enqueue( ( nextX, nextY ) );
                    }
                }
            }
        }

        return area;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        M = inputs[0];
        N = inputs[1];
        int K = inputs[2], result = 0;
        map = new int[M, N];
        visited =  new bool[M, N];
        
        for ( int i = 0; i < K; i++ )
        {
            int[] data = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for ( int x = data[1]; x < data[3]; x++ )
                for ( int y = data[0]; y < data[2]; y++ )
                    map[x, y] = 1;
        }

        List<int> areas = new List<int>( );
        for ( int i = 0; i < M; i++ )
            for ( int j = 0; j < N; j++ )
                if ( !visited[i, j] && map[i, j] == 0 )
                {
                    areas.Add( BFS( i, j ) );
                    result++;
                }
        
        areas.Sort( );
        Console.WriteLine( $"{result}\n{string.Join( " ", areas )}" );
    }
}