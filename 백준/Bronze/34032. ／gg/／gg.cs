using System.Linq;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        string S = sr.ReadLine( );
        Console.WriteLine( S.Count( c => c == 'O' ) * 2 >= S.Length ? "Yes" : "No" );
    }
}