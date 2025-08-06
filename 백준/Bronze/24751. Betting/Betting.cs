public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int a = int.Parse( sr.ReadLine( ) );
        double option1Ratio = 100.0 / a;
        double option2Ratio = 100.0 / ( 100 - a );

        Console.WriteLine( $"{option1Ratio:F10}" );
        Console.WriteLine( $"{option2Ratio:F10}" );
    }
}