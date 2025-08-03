public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[0], M = input[1], result = 0;

        for( int i = 0; i < N; i++ )
        {
            int minValue = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse ).Min( );
            result = minValue > result ? minValue : result;
        }
        
        Console.WriteLine( result );
    }
}
