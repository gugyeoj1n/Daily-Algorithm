using System;

public class Solution
{
    public static bool check( double a, long n, long l, long w, long h )
    {
        if ( a <= 0 ) return true;
        long newL = ( long )( l / a );
        long newW = ( long )( w / a );
        long newH = ( long )( h / a );
        if ( newL == 0 || newH == 0 || newH == 0 ) return false;
        return ( double )newL * newW * newH >= n;
    }

    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        string[ ] input = sr.ReadLine( ).Split( );
        long N = long.Parse( input[ 0 ] ),
             L = long.Parse( input[ 1 ] ),
             W = long.Parse( input[ 2 ] ),
             H = long.Parse( input[ 3 ] );

        double low = 0, high = Math.Min( L, Math.Min( W, H ) );
        for ( int i = 0; i < 100; i++ )
        {
            double mid = ( low + high ) / 2;
            if ( check( mid, N, L, W, H ) ) low = mid;
            else high = mid;
        }

        Console.WriteLine( low );
    }
}