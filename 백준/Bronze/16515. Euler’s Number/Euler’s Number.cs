public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int n = int.Parse( sr.ReadLine( ) );

        double e_approximation = 1.0, term = 1.0;
        for ( int i = 1; i <= n; i++ )
        {
            term /= i;
            e_approximation += term;
        }

        Console.WriteLine( e_approximation );
    }
}