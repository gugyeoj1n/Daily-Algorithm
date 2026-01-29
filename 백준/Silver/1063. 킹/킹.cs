public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        string[ ] input = sr.ReadLine( ).Split( );
        int x1 = input[ 0 ][ 0 ] - 'A', y1 = input[ 0 ][ 1 ] - '1';
        int x2 = input[ 1 ][ 0 ] - 'A', y2 = input[ 1 ][ 1 ] - '1';
        int N = int.Parse( input[ 2 ] );
        
        for ( int i = 0; i < N; i++ )
        {
            string move = sr.ReadLine( );
            int dx = 0, dy = 0;
            switch ( move )
            {
                case "R":  dx = 1;  dy = 0;  break;
                case "L":  dx = -1; dy = 0;  break;
                case "B":  dx = 0;  dy = -1; break;
                case "T":  dx = 0;  dy = 1;  break;
                case "RT": dx = 1;  dy = 1;  break;
                case "LT": dx = -1; dy = 1;  break;
                case "RB": dx = 1;  dy = -1; break;
                case "LB": dx = -1; dy = -1; break;
            }
            
            int nextX1 = x1 + dx, nextY1 = y1 + dy;
            if ( nextX1 < 0 || nextX1 > 7 || nextY1 < 0 || nextY1 > 7 ) continue;
            if ( nextX1 == x2 && nextY1 == y2 )
            {
                int nextX2 = x2 + dx, nextY2 = y2 + dy;
                if ( nextX2 < 0 || nextX2 > 7 || nextY2 < 0 || nextY2 > 7 ) continue;
                x2 = nextX2;
                y2 = nextY2;
            }
            x1 = nextX1;
            y1 = nextY1;
        }

        Console.WriteLine( $"{( char )( x1 + 'A' )}{( char )( y1 + '1' )}" );
        Console.WriteLine( $"{( char )( x2 + 'A' )}{( char )( y2 + '1' )}" );
    }
}