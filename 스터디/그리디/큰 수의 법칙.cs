public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = inputs[0], M = inputs[1], K = inputs[2];
        
        int[] data = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        Array.Sort( data );
        int maxValue = data[0], secondMaxValue = data[1];

        int cycle = M / ( K + 1 ), remainder = M % ( K + 1 );
        int result = ( maxValue * K + secondMaxValue ) * cycle + maxValue * remainder;
        
        Console.WriteLine( result );
    }
}
