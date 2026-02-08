public class Solution
{
    public static bool BFS( int N, int M, int[ , ] map )
    {
        bool[ , ] visited = new bool[ M, N ];
        Queue<(int, int)> queue = new Queue<(int, int)>( );
        queue.Enqueue( ( 0, 0 ) );
        visited[ 0, 0 ] = true;
        int[ ] row = { 0, 1 }, col = { 1, 0 };

        while ( queue.Count > 0 )
        {
            var (curRow, curCol) = queue.Dequeue( );
            if ( curRow == M - 1 && curCol == N - 1 )
                return true;

            for ( int i = 0; i < 2; i++ )
            {
                int nextRow = curRow + row[ i ], nextCol = curCol + col[ i ];
                if ( nextRow >= 0 && nextRow < M && nextCol >= 0 && nextCol < N )
                {
                    if ( map[ nextRow, nextCol ] == 1 && !visited[ nextRow, nextCol ] )
                    {
                        visited[ nextRow, nextCol ] = true;
                        queue.Enqueue( ( nextRow, nextCol ) );
                    }
                }
            }
        }

        return false;
    }

    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[ 0 ], M = input[ 1 ];
        int[ , ] map = new int[ M, N ];
        for ( int i = 0; i < M; i++ )
        {
            string[ ] line = sr.ReadLine( ).Split( );
            for ( int j = 0; j < N; j++ )
                map[ i, j ] = int.Parse( line[ j ] );
        }

        Console.WriteLine( BFS( N, M, map ) ? "Yes" : "No" );
    }
}