using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        string input = sr.ReadLine( );
        int n = input.Length;
        
        HashSet<string> set = new HashSet<string>( );
        for ( int i = 0; i < n; i++ )
        {
            StringBuilder sb = new StringBuilder( );
            for ( int j = i; j < n; j++ )
            {
                sb.Append( input[j] );
                set.Add( sb.ToString( ) );
            }
        }
        
        Console.WriteLine( set.Count );
    }
}