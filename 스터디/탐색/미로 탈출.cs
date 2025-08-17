public class Solution
{
    public static int N, M;
    public static int[,] map;
    public static bool[,] visited;

    public static int[] dx = { 0, 0, -1, 1 };
    public static int[] dy = { -1, 1, 0, 0 };

    public static int BFS( )
    {
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>( );
        queue.Enqueue( ( 0, 0, 1 ) );
        visited[0, 0] = true;

        while( queue.Count > 0 )
        {
            var current = queue.Dequeue( );

            if( current.Item1 == N - 1 && current.Item2 == M - 1 )
                return current.Item3;

            for( int i = 0; i < 4; i++ )
            {
                int nx = current.Item1 + dx[i];
                int ny = current.Item2 + dy[i];

                if( nx < 0 || nx >= N || ny < 0 || ny >= M )
                    continue;

                if( map[nx, ny] == 1 && !visited[nx, ny] )
                {
                    visited[nx, ny] = true;
                    queue.Enqueue( ( nx, ny, current.Item3 + 1 ) );
                }
            }
        }

        return -1;
    }

    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        N = input[0];
        M = input[1];
        map = new int[N, M];
        visited = new bool[N, M];

        for( int i = 0; i < N; i++ )
        {
            string line = sr.ReadLine( );
            for( int j = 0; j < M; j++ )
                map[i, j] = line[j] - '0';
        }

        Console.WriteLine( BFS( ) );
    }
}
