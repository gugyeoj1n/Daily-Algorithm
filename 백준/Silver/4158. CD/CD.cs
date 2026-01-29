public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        while ( true )
        {
            int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            int N = input[ 0 ], M = input[ 1 ];
            if ( N == 0 && M == 0 )
                break;
            int[ ] first = new int[ N ], second = new int[ N ];
            for ( int i = 0; i < N; i++ )
                first[ i ] = int.Parse( sr.ReadLine( ) );
            for ( int i = 0; i < M; i++ )
                second[ i ] = int.Parse( sr.ReadLine( ) );

            int cnt = 0, p1 = 0, p2 = 0;
            while ( p1 < N && p2 < M )
            {
                if ( first[ p1 ] == second[ p2 ] )
                {
                    cnt++;
                    p1++;
                    p2++;
                } else if ( first[ p1 ] < second[ p2 ] )
                    p1++;
                else
                    p2++;
            }
            
            Console.WriteLine(cnt);
        }
    }
}