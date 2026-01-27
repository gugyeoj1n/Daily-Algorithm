public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[ ] input;

        while ( true )
        {
            input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            if ( input[ 0 ] == 0 && input[ 1 ] == 0 ) break;
            Console.WriteLine(input[0] + input[1]);
        }
    }
}