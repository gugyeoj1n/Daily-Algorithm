public class Solution
{
    public static int CountBits( long n )
    {
        int count = 0;
        while( n > 0 )
        {
            count += ( int )( n & 1 );
            n >>= 1;
        }
        return count;
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[0], K = input[1];

        if( CountBits( N ) <= K )
        {
            Console.WriteLine(0);
            return;
        }

        long answer = 0, added = 0;
        while( true )
        {
            long bits = CountBits( N + added );
            if( bits <= K )
            {
                answer = added;
                break;
            }

            added += ( N + added ) & -( N + added );
        }
        
        Console.WriteLine( answer );
    }
}