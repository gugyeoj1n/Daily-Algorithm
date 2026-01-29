public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) ), result = 0;
        int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        for ( int i = 0; i < N; i++ )
            result += input[ i ] + (i < N - 1 ? 8 : 0);
        Console.WriteLine( "{0} {1}", result / 24, result % 24 );
    }
}