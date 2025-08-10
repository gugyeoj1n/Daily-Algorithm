public class Solution
{
    public static int[] dx = { -1, 0, 1, 0 };
    public static int[] dy = { 0, 1, 0, -1 };

    public static int GetDir( int dir )
    {
        return dir == 0 ? 3 : dir - 1;
    }

    public static void Main( string[] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );

        int[] mapData = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = mapData[0], M = mapData[1];

        int[] playerData = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int X = playerData[0], Y = playerData[1], D = playerData[2];

        int[,] map = new int[N, M];
        for( int i = 0; i < N; i++ )
        {
            int[] row = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
            for( int j = 0; j < M; j++ )
                map[i, j] = row[j];
        }

        bool[,] visited = new bool[N, M];
        visited[X, Y] = true;

        int count = 1;
        int turnCnt = 0;

        while( true )
        {
            D = GetDir( D );
            int nx = X + dx[D];
            int ny = Y + dy[D];

            if( nx >= 0 && nx < N && ny >= 0 && ny < M && map[nx, ny] == 0 && !visited[nx, ny] )
            {
                X = nx;
                Y = ny;
                visited[X, Y] = true;
                count++;
                turnCnt = 0;
                continue;
            }
            else
                turnCnt++;

            if( turnCnt == 4 )
            {
                int bx = X - dx[D];
                int by = Y - dy[D];
                if( bx >= 0 && bx < N && by >= 0 && by < M && map[bx, by] == 0 )
                {
                    X = bx;
                    Y = by;
                    turnCnt = 0;
                }
                else
                    break;
            }
        }

        Console.WriteLine( count );
    }
}
