using System.Collections.Generic;

public class Program
{
    public static int[] dx = new int[] { -1, 0, 0, 1 };
    public static int[] dy = new int[] { 0, 1, -1, 0 };
    
    public static ( int, int ) pos;
    public static int N, size;
    
    public static int[,] map;
    public static bool[,] visited;
    public static Queue<( int, int, int )> queue;
    public static List<( int, int, int )> targets;

    public static ( int, int, int )? BFS( )
    {
        queue = new Queue<( int, int, int )>( );
        visited = new bool[N, N];
        targets = new List<( int, int, int )>( );
        
        queue.Enqueue( ( pos.Item1, pos.Item2, 0 ) );
        visited[pos.Item1, pos.Item2] = true;

        while ( queue.Count > 0 )
        {
            ( int, int, int ) cur = queue.Dequeue( );
            for ( int i = 0; i < 4; i++ )
            {
                int nextX = cur.Item1 + dx[i];
                int nextY = cur.Item2 + dy[i];
                int nextDist = cur.Item3 + 1;

                if ( nextX < 0 || nextX >= N || nextY < 0 || nextY >= N || visited[nextX, nextY] ||
                    map[nextX, nextY] > size )
                    continue;
                
                visited[nextX, nextY] = true;
                if ( map[nextX, nextY] > 0 && map[nextX, nextY] < size )
                    targets.Add( ( nextX, nextY, nextDist ) );
                queue.Enqueue( ( nextX, nextY, nextDist ) );
            }
        }

        if ( targets.Count == 0 )
            return null;

        return targets.OrderBy( t => t.Item3 )
            .ThenBy( t => t.Item1 )
            .ThenBy( t => t.Item2 )
            .First( );
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        N = int.Parse(sr.ReadLine());
        size = 2;
        map = new int[N, N];
        
        for ( int i = 0; i < N; i++ )
        {
            int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for ( int j = 0; j < N; j++ )
            {
                map[i, j] = input[j];
                if (map[i, j] == 9)
                {
                    pos = ( i, j );
                    map[i, j] = 0;
                }
            }
        }

        int resultTime = 0, eatCount = 0;
        
        while ( true )
        {
            var target = BFS( );
            if ( target == null )
                break;

            resultTime += target.Value.Item3;
            pos = ( target.Value.Item1, target.Value.Item2 );
            eatCount++;
            map[pos.Item1, pos.Item2] = 0;

            if ( eatCount == size )
            {
                eatCount = 0;
                size++;
            }
        }
        
        Console.WriteLine( resultTime );
    }
}