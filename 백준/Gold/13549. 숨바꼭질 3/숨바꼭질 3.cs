using System.Collections.Generic;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = inputs[0], K = inputs[1];

        List<( int, int )>[] graph = new List<( int, int )>[100001];
        for ( int i = 0; i < 100001; i++ )
        {
            graph[i] = new List<( int, int )>( );
            graph[i].Add( ( i * 2, 0 ) );
            graph[i].Add( ( i - 1, 1 ) );
            graph[i].Add( ( i + 1, 1 ) );
        }
        
        bool[] visited = new bool[100001];
        int[] distance = Enumerable.Repeat( 100001, 100001 ).ToArray( );
        
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>( );
        distance[N] = 0;
        queue.Enqueue( N, 0 );

        while ( queue.Count > 0 )
        {
            int pos = queue.Dequeue( );
            if ( !visited[pos] )
            {
                visited[pos] = true;
                foreach ( var ( next, dist ) in graph[pos] )
                {
                    if ( next >= 0 && next < 100001 )
                    {
                        distance[next] = Math.Min( distance[next], distance[pos] + dist );
                        queue.Enqueue( next, distance[next] );
                    }
                }
            }
        }
        
        Console.WriteLine( distance[K] );
    }
}