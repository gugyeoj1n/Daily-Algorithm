public class Solution
{
    public static int BFS( int F, int S, int G, int U, int D )
    {
        int count = 0, current = S;

        bool[] visited = new bool[F + 1];
        visited[S] = true;
        
        Queue<( int, int )> queue = new Queue<( int, int )>( );
        queue.Enqueue( ( current, count ) );
        while( queue.Count > 0 )
        {
            var (cur, cnt) = queue.Dequeue( );
            if( cur == G )
                return cnt;

            int up = cur + U;
            if( up <= F && !visited[up] )
            {
                visited[up] = true;
                queue.Enqueue( ( up, cnt + 1 ) );
            }

            int down = cur - D;
            if( down > 0 && !visited[down] )
            {
                visited[down] = true;
                queue.Enqueue( ( down, cnt + 1) );
            }
        }
        
        return -1;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int F = inputs[0], S = inputs[1], G = inputs[2], U = inputs[3], D = inputs[4];

        int result = BFS( F, S, G, U, D );
        Console.WriteLine( result != -1 ? result : "use the stairs" );
    }
}