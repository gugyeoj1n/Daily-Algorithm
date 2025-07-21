public class Solution {
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        StreamWriter sw = new StreamWriter( Console.OpenStandardOutput( ) );

        int n = int.Parse( sr.ReadLine( ) );

        HashSet<string> entered = new HashSet<string>( );

        for ( int i = 0; i < n; i++ )
        {
            string[] input = sr.ReadLine( ).Split( );
            string name = input[0];
            string action = input[1];

            if ( action == "enter" )
                entered.Add( name );
            else
                entered.Remove( name );
        }

        List<string> result = new List<string>( entered );
        result.Sort( );
        result.Reverse( );

        foreach ( string name in result )
            sw.WriteLine( name );

        sw.Flush( );
    }
}