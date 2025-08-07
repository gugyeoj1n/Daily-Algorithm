public class Solution
{
    
    public static ( int, int ) recursion( string target, int start, int end, int count )
    {
        if( start >= end ) return ( 1, count );
        else if( target[start] != target[end] ) return ( 0, count );
        else return recursion( target, start + 1, end - 1, count + 1 );
    }

    public static ( int, int ) isPalindrome( string target )
    {
        return recursion( target, 0, target.Length - 1, 1 );
    }
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int T = int.Parse( sr.ReadLine( ) );
        for( int i = 0; i < T; i++ )
        {
            string input = sr.ReadLine( );
            var result = isPalindrome( input );
            Console.WriteLine( $"{result.Item1} {result.Item2}" );
        }
    }
}