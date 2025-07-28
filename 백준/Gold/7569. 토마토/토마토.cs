using System.Collections.Generic;

public class Program
{
    public static int M, N, H;
    public static int[,,] map;

    public static Queue<( int, int, int )> queue;

    public static int[] dx = { 0, 0, -1, 0, 0, 1 };
    public static int[] dy = { 0, 0, 0, 1, -1, 0 };
    public static int[] dz = { -1, 1, 0, 0, 0, 0 };

    public static int BFS( )
    {
        int day = 0;
        
        while ( queue.Count > 0 )
        {
            var ( curZ, curX, curY ) = queue.Dequeue( );
            day = map[curZ, curX, curY];
            for ( int i = 0; i < 6; i++ )
            {
                int nextX = curX + dx[i];
                int nextY = curY + dy[i];
                int nextZ = curZ + dz[i];
                
                if ( nextX >= 0 && nextX < N && nextY >= 0 && nextY < M && nextZ >= 0 && nextZ < H )
                {
                    if ( map[nextZ, nextX, nextY] == 0 )
                    {
                        map[nextZ, nextX, nextY] = map[curZ, curX, curY] + 1;
                        queue.Enqueue( ( nextZ, nextX, nextY ) );
                    }
                }
            }
        }

        return day;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( Console.ReadLine( ).Split( ), int.Parse );
        M = inputs[0]; N = inputs[1]; H = inputs[2];
        map = new int[H, N, M];
        queue = new Queue<( int, int, int )>( );
        bool isDone = true;
        int result = 0;
        
        for ( int hi = 0; hi < H; hi++ )
        {
            for ( int ni = 0; ni < N; ni++ )
            {
                int[] data = Array.ConvertAll( Console.ReadLine( ).Split( ), int.Parse );
                for ( int mi = 0; mi < M; mi++ )
                {
                    map[hi, ni, mi] = data[mi];
                    if( data[mi] == 0 )
                        isDone = false;
                    else if( data[mi] == 1 )
                        queue.Enqueue( ( hi, ni, mi ) );
                }
            }
        }
        
        if( isDone )
            Console.WriteLine( "0" );
        else
        {
            result = BFS();
            for ( int hi = 0; hi < H; hi++ )
                for ( int ni = 0; ni < N; ni++ )
                    for ( int mi = 0; mi < M; mi++ )
                        if (map[hi, ni, mi] == 0)
                        {
                            Console.WriteLine( "-1" );
                            return;
                        }
            Console.WriteLine( result - 1 );
        }
    }
}