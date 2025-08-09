using System;
using System.IO;
using System.Text;

public class Solution
{
    public static void Main( )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        StringBuilder sb = new StringBuilder( );

        int M = int.Parse( sr.ReadLine( ) );
        long sum = 0;
        int xorValue = 0;

        sum += 0;
        xorValue ^= 0;

        for( int i = 0; i < M; i++ )
        {
            string line = sr.ReadLine( );
            if( line[0] == '1' )
            {
                int spaceIdx = line.IndexOf( ' ' );
                int x = int.Parse( line.AsSpan( spaceIdx + 1 ) );
                sum += x;
                xorValue ^= x;
            }
            else if( line[0] == '2' )
            {
                int spaceIdx = line.IndexOf( ' ' );
                int x = int.Parse( line.AsSpan( spaceIdx + 1 ) );
                sum -= x;
                xorValue ^= x;
            }
            else if( line[0] == '3' )
                sb.AppendLine( sum.ToString( ) );
            else
                sb.AppendLine( xorValue.ToString( ) );
        }

        Console.Write( sb.ToString( ) );
    }
}