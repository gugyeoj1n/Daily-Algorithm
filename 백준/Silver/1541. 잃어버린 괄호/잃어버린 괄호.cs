public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        string[] input = sr.ReadLine( ).Split( '-' );
        
        int result = input[0].Split( '+' ).Sum( int.Parse );
        for( int i = 1; i < input.Length; i++ )
            result -= input[i].Split( '+' ).Sum( int.Parse );
        
        Console.WriteLine( result );
    }
}