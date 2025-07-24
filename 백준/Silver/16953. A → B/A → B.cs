public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int A = inputs[0], B = inputs[1];
        int count = 1;

        while ( A < B )
        {
            if ( B % 2 == 0 )
                B /= 2;
            else if( B % 10 == 1 )
                B /= 10;
            else
                break;
            count++;
        }
        
        Console.WriteLine( A == B ? count : -1 );
    }
}