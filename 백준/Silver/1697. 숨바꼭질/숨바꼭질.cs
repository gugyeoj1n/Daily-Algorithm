using System.Collections.Generic;

public class Solution
{
    public static int[] graph = new int[100001];
    public static bool[] visited = new bool[100001];
    public static int[] move = new int[3];
    public static int result;

    public static void BFS( int start, int end )
    {
        Queue<int> queue = new Queue<int>( );
        queue.Enqueue( start );
        visited[start] = true;

        while ( queue.Count > 0 )
        {
            int x = queue.Dequeue( );
            move[0] = x - 1;
            move[1] = x + 1;
            move[2] = x * 2;

            for ( int i = 0; i < 3; i++ )
            {
                int t = move[i];
                if (t >= 0 && t <= 100000 && !visited[t])
                {
                    graph[t] = graph[x] + 1;
                    queue.Enqueue( t );
                    visited[t] = true;
                    if (t == end)
                    {
                        result = graph[t];
                        return;
                    }
                }
            }
        }
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int n = inputs[0], k = inputs[1];
        BFS(n, k);
        Console.WriteLine( result );
    }
}