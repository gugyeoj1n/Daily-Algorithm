using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static List<int>[] graph;
    public static int[] result;
    public static int N;

    public static void BFS( int start )
    {
        var queue = new Queue<int>( );
        var visited = new bool[N + 1];
        
        queue.Enqueue( start );
        visited[start] = true;
        
        while ( queue.Count > 0 )
        {
            int target = queue.Dequeue( );
            foreach ( var child in graph[target] )
            {
                if ( !visited[child] )
                {
                    visited[child] = true;
                    result[child]++;
                    queue.Enqueue( child );
                }
            }
        }
    }
    
    public static void Main( string[] args )
    {
        var sr = new StreamReader( new BufferedStream( Console.OpenStandardInput( ) ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        N = inputs[0];
        int M =  inputs[1];
        
        graph = new List<int>[N + 1];
        for( int i = 1; i <= N; i++ )
            graph[i] = new List<int>( );
        
        for ( int i = 0; i < M; i++ )
        {
            int[] datas = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            graph[datas[0]].Add( datas[1] );
        }
        
        result = new int[N + 1];
        for ( int i = 1; i <= N; i++ )
            BFS( i );
        
        int maxValue = 0;
        for ( int i = 1; i <= N; i++ )
            if ( result[i] > maxValue )
                maxValue = result[i];

        var maxResult = new List<int>();
        for ( int i = 1; i <= N; i++ )
            if ( result[i] == maxValue )
                maxResult.Add( i );
        
        Console.WriteLine( $"{string.Join( " ", maxResult )}" );
    }
}