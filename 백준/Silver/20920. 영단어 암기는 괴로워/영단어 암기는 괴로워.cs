using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[0], M = input[1];
        
        Dictionary<string, int> dict = new Dictionary<string, int>( );
        for ( int i = 0; i < N; i++ )
        {
            string word = sr.ReadLine( );
            if ( word.Length < M )
                continue;
            dict.TryGetValue( word, out int cnt );
            dict[word] = cnt + 1;
        }
        
        var sorted = dict
            .OrderByDescending( pair => pair.Value )
            .ThenByDescending( pair => pair.Key.Length )
            .ThenBy( pair => pair.Key )
            .Select( pair => pair.Key );
        
        StringBuilder sb = new StringBuilder( );
        foreach( string word in sorted )
            sb.AppendLine( word );
        
        Console.Write( sb.ToString( ) );
    }
}