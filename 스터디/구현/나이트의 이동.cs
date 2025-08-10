public class Solution
{
    public static int[] dx = { -2, -2, -1, -1, 1, 1, 2, 2 };
    public static int[] dy = { -1, 1, 2, -2, 2, -2, 1, -1 };
    
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        string input = sr.ReadLine( );
        int x = input[0] - 96, y = input[1] - '0', count = 0, nx, ny;
        
        for( int i = 0; i < 8; i++ )
        {
            nx = x + dx[i]; ny = y + dy[i];
            if(nx >= 1 && nx <= 8 && ny >= 1 && ny <= 8)
                count++;
        }
        
        Console.WriteLine( count );
    }
}
