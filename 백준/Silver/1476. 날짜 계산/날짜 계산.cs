using System;
using System.IO;

public class Program
{
    public static void Main( string[] args )
    {
        string[] input = Console.ReadLine( ).Split( );

        int E = int.Parse( input[0] );
        int S = int.Parse( input[1] );
        int M = int.Parse( input[2] );

        int year = 1;

        while ( true )
        {
            if ( ( year - 1 ) % 15 + 1 == E &&
                 ( year - 1 ) % 28 + 1 == S &&
                 ( year - 1 ) % 19 + 1 == M )
            {
                Console.WriteLine( year );
                break;
            }

            year++;
        }
    }
}