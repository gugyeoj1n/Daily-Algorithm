public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int a = input[0], m = input[1];
        for ( int x = 1; x < m; x++ )
        {
            if ( ( a * x ) % m == 1 )
            {
                Console.WriteLine( x );
                break;
            }
        }
    }
}