using System.Text;

public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        string input = sr.ReadLine( );
        StringBuilder sb = new StringBuilder( );
        bool isFirst = true;
        foreach ( char i in input )
        {
            int value = int.Parse( i.ToString( ) );
            if ( isFirst )
            {
                sb.Append( Convert.ToString( value, 2 ) );
                isFirst = false;
            }
            else
                sb.Append( Convert.ToString( value, 2 ).PadLeft( 3, '0' ) );
        }

        Console.WriteLine( sb.ToString( ) );
    }
}