public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        int cnt = N + 1, L = 0;
        string input = sr.ReadLine( );

        foreach ( char c in input )
            if ( c == 'L' ) L++;

        if ( L == 0 ) cnt = N;
        else cnt -= ( L / 2 );
        
        Console.WriteLine( cnt );
    }
}