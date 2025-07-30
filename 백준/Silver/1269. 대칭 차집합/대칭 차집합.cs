using System.Collections.Generic;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        HashSet<int> map = new HashSet<int>( );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse  );
        int A = input[0], B = input[1];
        input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse  );
        for ( int i = 0; i < A; i++ )
            map.Add( input[i] );
        input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse  );
        for ( int i = 0; i < B; i++ )
            if( map.Contains( input[i] ) )
                map.Remove( input[i] );
            else
                map.Add( input[i] );
        Console.WriteLine( map.Count );
    }
}