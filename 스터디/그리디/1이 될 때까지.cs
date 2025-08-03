public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[0], K = input[1], cnt = 0;

        while( true )
        {
            int newN = ( N / K ) * K;
            cnt += N - newN;
            N = newN;

            if( N < K )
                break;

            N /= K;
            cnt++;
        }
        
        Console.WriteLine( cnt + ( N - 1 ) );
    }
}
