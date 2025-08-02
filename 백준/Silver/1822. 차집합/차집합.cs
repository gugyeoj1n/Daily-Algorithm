public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int NA = input[0], NB = input[1];

        HashSet<int> setA = new HashSet<int>( );
        int[] inputA = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        for( int i = 0; i < NA; i++ )
            setA.Add( inputA[i] );
        
        int[] inputB = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        for( int i = 0; i < NB; i++ )
            if( setA.Contains( inputB[i] ) )
                setA.Remove( inputB[i] );

        Console.WriteLine( setA.Count > 0 ? $"{setA.Count}\n{string.Join( " ", setA.OrderBy( x => x ) )}" : "0" );
    }
}