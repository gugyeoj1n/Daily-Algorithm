public class Solution
{
    static List<int>[] graph;
    static bool[] visited;

    static int BFS( )
    {
        var q = new Queue<(int v, int d)>( );
        visited[1] = true;
        q.Enqueue( ( 1, 0 ) );

        int invited = 0;

        while( q.Count > 0 )
        {
            var (v, d) = q.Dequeue( );
            if( d == 2 ) continue;

            foreach( int nv in graph[v] )
            {
                if( visited[nv] ) continue;
                visited[nv] = true;

                int nd = d + 1;
                q.Enqueue( ( nv, nd ) );

                if( nd <= 2 ) invited++;
            }
        }

        return invited;
    }

    public static void Main( string[] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );

        int n = int.Parse( sr.ReadLine( ) );
        int m = int.Parse( sr.ReadLine( ) );

        graph = new List<int>[n + 1];
        for( int i = 1; i <= n; i++ )
            graph[i] = new List<int>( );

        for( int i = 0; i < m; i++ )
        {
            var parts = sr.ReadLine( ).Split( );
            int a = int.Parse( parts[0] );
            int b = int.Parse( parts[1] );

            graph[a].Add( b );
            graph[b].Add( a );
        }

        visited = new bool[n + 1];
        Console.WriteLine( BFS( ) );
    }
}