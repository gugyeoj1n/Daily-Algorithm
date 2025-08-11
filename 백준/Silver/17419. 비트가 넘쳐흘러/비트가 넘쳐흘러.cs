public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        string k = sr.ReadLine( );

        int count = 0;
        foreach( char bit in k )
            if ( bit == '1' )
                count++;
        
        Console.WriteLine( count );
    }
}