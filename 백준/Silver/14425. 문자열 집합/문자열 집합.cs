public class Solution {
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );

        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int n = inputs[0], m = inputs[1], result = 0;
        
        HashSet<string> hash = new HashSet<string>( );

        for( int i = 0; i < n; i++ )
            hash.Add( sr.ReadLine( ) );

        for( int i = 0; i < m; i++ )
            if( hash.Contains( sr.ReadLine( ) ) )
                result++;

        Console.WriteLine( result );
    }
}