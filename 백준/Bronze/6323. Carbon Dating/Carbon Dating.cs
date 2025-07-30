using System;
using System.IO;

public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );

        int sampleCount = 1;

        while ( true )
        {
            string[] input = sr.ReadLine( ).Split( );
            double w = double.Parse( input[0] );
            double d = double.Parse( input[1] );

            if ( w == 0 && d == 0 )
                break;

            double age;
            double decaysPerGram = d / w;

            if ( decaysPerGram >= 810.0 )
                age = 0;
            else
            {
                double ratio = decaysPerGram / 810.0;
                age = 5730 * Math.Log( ratio ) / Math.Log( 0.5 );
            }

            long roundedAge;

            if ( age < 10000 )
                roundedAge = ( long )( Math.Floor( age / 100 + 0.5 ) * 100 );
            else
                roundedAge = ( long )( Math.Floor( age / 1000 + 0.5 ) * 1000 );

            Console.WriteLine( $"Sample #{sampleCount}" );
            Console.WriteLine( $"The approximate age is {roundedAge} years." );
            Console.WriteLine( );

            sampleCount++;
        }
    }
}