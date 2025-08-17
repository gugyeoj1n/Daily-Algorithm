public class Solution
{
    public static int[,] map;
    public static bool[,] visited;
    public static int N, M;

    public static void DFS( int x, int y )
    {
        if( x < 0 || x >= N || y < 0 || y >= M || visited[x, y] || map[x, y] == 1 )
            return;

        visited[x, y] = true;

        DFS( x - 1, y );
        DFS( x + 1, y );
        DFS( x, y - 1 );
        DFS( x, y + 1 );
    }

    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        N = input[0];
        M = input[1];
        int count = 0;

        map = new int[N, M];
        visited = new bool[N, M];
        for( int i = 0; i < N; i++ )
        {
            string row = sr.ReadLine( );
            for( int j = 0; j < M; j++ )
                map[i, j] = row[j] - '0';
        }

        for( int i = 0; i < N; i++ )
        {
            for( int j = 0; j < M; j++ )
            {
                if( map[i, j] == 0 && !visited[i, j] )
                {
                    DFS( i, j );
                    count++;
                }
            }
        }

        Console.WriteLine( count );
    }
}
