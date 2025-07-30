using System.Collections.Generic;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) ), result = 0;
        
        HashSet<string> chat = new HashSet<string>( );
        for ( int i = 0; i < N; i++ )
        {
            string input = sr.ReadLine( );
            if ( input == "ENTER" )
            {
                chat.Clear( );
                continue;
            }
            if ( chat.Contains( input ) )
                continue;

            chat.Add( input );
            result++;
        }
        
        Console.WriteLine( result );
    }
}