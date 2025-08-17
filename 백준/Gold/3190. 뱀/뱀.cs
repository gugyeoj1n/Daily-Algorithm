public class Program
{
    public static int Rotate( int d, char turn )
    {
        if ( turn == 'L' )
            return ( d + 1 ) % 4;
        return ( d == 0 ) ? 3 : d - 1;
    }

    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );

        int N = int.Parse( sr.ReadLine( ) );
        int K = int.Parse( sr.ReadLine( ) );

        int[,] map = new int[N + 1, N + 1];
        for ( int i = 0; i < K; i++ )
        {
            string[] applePos = sr.ReadLine( ).Split( );
            map[int.Parse( applePos[0] ), int.Parse( applePos[1] )] = 1;
        }

        int L = int.Parse( sr.ReadLine( ) );
        Queue<(int, char)> moves = new Queue<(int, char)>( );
        for ( int i = 0; i < L; i++ )
        {
            string[] moveInfo = sr.ReadLine( ).Split( );
            moves.Enqueue( ( int.Parse( moveInfo[0] ), moveInfo[1][0] ) );
        }

        LinkedList<(int, int)> snake = new LinkedList<(int, int)>( );
        snake.AddLast( ( 1, 1 ) );
        map[1, 1] = 2;

        int time = 0;
        int dir = 3;
        ( int y, int x ) head = ( 1, 1 );
        
        int[] dy = { -1, 0, 1, 0 };
        int[] dx = { 0, -1, 0, 1 };

        while ( true )
        {
            time++;

            int ny = head.y + dy[dir];
            int nx = head.x + dx[dir];

            if ( ny < 1 || ny > N || nx < 1 || nx > N || map[ny, nx] == 2 )
                break;

            head = ( ny, nx );
            snake.AddLast( head );
            
            if ( map[ny, nx] == 1 )
                map[ny, nx] = 2;
            else
            {
                map[ny, nx] = 2;
                var tail = snake.First.Value;
                map[tail.Item1, tail.Item2] = 0;
                snake.RemoveFirst( );
            }
            
            if ( moves.Count > 0 && moves.Peek( ).Item1 == time )
            {
                var move = moves.Dequeue( );
                dir = Rotate( dir, move.Item2 );
            }
        }

        Console.WriteLine( time );
        sr.Close( );
    }
}