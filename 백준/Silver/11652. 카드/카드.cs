using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        Dictionary<long, int> cards = new Dictionary<long, int>( );

        for ( int i = 0; i < N; i++ )
        {
            long card =  long.Parse( sr.ReadLine( ) );
            cards.TryGetValue( card, out int count );
            cards[card] = count + 1;
        }

        long resultCard = 0;
        int resultCount = 0;

        foreach ( var pair in cards )
        {
            if ( pair.Value > resultCount || ( pair.Value == resultCount && pair.Key < resultCard ) )
            {
                resultCount = pair.Value;
                resultCard = pair.Key;
            }
        }
        
        Console.WriteLine( resultCard );
    }
}