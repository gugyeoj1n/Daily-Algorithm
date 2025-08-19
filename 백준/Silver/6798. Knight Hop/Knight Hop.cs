public class Solution
{
    public static void Main( )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input1 = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int x1 = input1[0], y1 = input1[1];
        int[] input2 = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int x2 = input2[0], y2 = input2[1];

        int[] dx = { -2, -2, 2, 2, -1, -1, 1, 1 };
        int[] dy = { -1, 1, 1, -1, -2, 2, -2, 2 };

        Queue<( int x, int y, int d )> queue = new Queue<(int x, int y, int d)>( );
        queue.Enqueue( ( x1, y1, 0 ) );

        int result = 0;

        while( true )
        {
            var move = queue.Dequeue( );
            if( move.x == x2 && move.y == y2 )
            {
                result = move.d;
                break;
            }

            for( int i = 0; i < 8; i++ )
            {
                int nx = move.x + dx[i];
                int ny = move.y + dy[i];
                if( nx <= 0 || nx > 8 || ny <= 0 || ny > 8 ) continue;
                queue.Enqueue( ( nx, ny, move.d + 1 ) );
            }
        }

        Console.WriteLine( result );
    }
}