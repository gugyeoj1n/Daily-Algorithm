using System.Collections.Generic;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        List<( int start, int end )> scrum = new List<( int, int )>( );

        for ( int i = 0; i < N; i++ )
        {
            int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            scrum.Add( ( input[0], input[1] ) );
        }

        scrum.Sort( ( a, b ) =>
        {
            if ( a.end == b.end )
                return a.start.CompareTo( b.start );
            return a.end.CompareTo( b.end );
        } );

        int count = 0, lastEnd = 0;
        foreach ( var scr in scrum )
        {
            if ( scr.start >= lastEnd )
            {
                count++;
                lastEnd = scr.end;
            }
        }

        Console.WriteLine( count );
    }
}