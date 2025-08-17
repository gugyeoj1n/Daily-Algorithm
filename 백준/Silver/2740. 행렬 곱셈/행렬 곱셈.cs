public class Solution
{
    public static void Main( string[] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] size1 = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        
        int N = size1[0], M = size1[1];
        int[,] arr1 = new int[N, M];
        
        for(int i = 0; i < N; i++)
        {
            int[] row = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for(int j = 0; j < M; j++)
                arr1[i, j] = row[j];
        }
        
        int[] size2 = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int K = size2[1];
        int[,] arr2 = new int[M, K];
        
        for( int i = 0; i < M; i++ )
        {
            int[] row = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for(int j = 0; j < K; j++)
                arr2[i, j] = row[j];
        }
        
        int[,] result = new int[N, K];
        for( int i = 0; i < N; i++ )
        {
            for( int j = 0; j < K; j++ )
            {
                result[i, j] = 0;
                for( int k = 0; k < M; k++ )
                    result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
        
        for( int i = 0; i < N; i++ )
        {
            for( int j = 0; j < K; j++ )
                Console.Write( result[i, j] + " " );
            Console.WriteLine( );
        }
    }
}