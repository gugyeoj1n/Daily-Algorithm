using System.Collections.Generic;

public class Solution
{
    public static List<int>[] graph;
    public static bool[] visited;

    public static int BFS( int start, int end )
    {
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        queue.Enqueue( (start, 0) );
        visited[start] = true;

        while ( queue.Count > 0 )
        {
            var ( person, count ) = queue.Dequeue( );
            if ( person == end )
                return count;

            foreach ( int next in graph[person] )
            {
                if ( !visited[next] )
                {
                    visited[next] = true;
                    queue.Enqueue( ( next, count + 1 ) );
                }
            }
        }

        return -1;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );

        int n = int.Parse( sr.ReadLine( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int x = inputs[0], y = inputs[1];
        int m = int.Parse( sr.ReadLine( ) );

        graph = new List<int>[n + 1];
        visited = new bool[n + 1];

        for ( int i = 1; i <= n; i++ )
            graph[i] = new List<int>( );
        
        for ( int i = 0; i < m; i++ )
        {
            inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            int parent = inputs[0], child = inputs[1];
            graph[parent].Add( child );
            graph[child].Add( parent );
        }
        
        Console.WriteLine( BFS( x, y ) );
    }
}