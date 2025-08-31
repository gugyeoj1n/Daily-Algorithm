public class Solution
{
    public static int N, M;
    public static int[] arr;

    public static void Search( int cnt, int start )
    {
        if( cnt == M )
        {
            Console.WriteLine( string.Join( " ", arr ) );
            return;
        }

        for( int i = start; i <= N; i++ )
        {
            arr[cnt] = i;
            Search( cnt + 1, i );
        }
    }
    
    public static void Main( string[] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        N = input[0]; M = input[1];
        arr = new int[M];
        Search( 0, 1 );
    }
}