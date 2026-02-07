public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[ 0 ], M = input[ 1 ], minPackage = 1001, minUnit = 1001;

        for ( int i = 0; i < M; i++ )
        {
            string[ ] price = sr.ReadLine( ).Split( );
            int package = int.Parse( price[ 0 ] ), unit = int.Parse( price[ 1 ] );
            if ( package < minPackage ) minPackage = package;
            if ( unit < minUnit ) minUnit = unit;
        }

        int costAllUnits = N * minUnit;
        int packageCount = ( N / 6 );
        if ( N % 6 != 0 ) packageCount++;
        int costAllPackages = packageCount * minPackage;
        int costMix = ( N / 6 ) * minPackage + ( N % 6 ) * minUnit;
        int result = Math.Min( costAllUnits, Math.Min( costAllPackages, costMix ) );
        
        Console.WriteLine( result );
    }
}