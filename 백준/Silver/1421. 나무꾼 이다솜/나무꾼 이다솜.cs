public class Solution
{
    public static void Main( string[ ] args )
    {
        using var sr = new StreamReader( Console.OpenStandardInput( ) );
        int[ ] input = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int N = input[ 0 ], C = input[ 1 ], W = input[ 2 ];
        int[ ] tree = new int[ N ];
        int maxTree = 0;
        for ( int i = 0; i < N; i++ )
        {
            tree[ i ] = int.Parse( sr.ReadLine( ) );
            if(tree[i] > maxTree) maxTree = tree[ i ];
        }

        long maxMoney = 0;
        for ( int i = 1; i <= maxTree; i++ )
        {
            long money = 0;
            for ( int j = 0; j < N; j++ )
            {
                if ( tree[ j ] < i ) continue;
                int piece = tree[ j ] / i, cut = 0;
                cut = ( tree[ j ] % i == 0 ) ? piece - 1 : piece;
                long earn = ( long )piece * i * W - ( long )cut * C;
                if ( earn > 0 ) money += earn;
            }
            if(money > maxMoney) maxMoney = money;
        }

        Console.WriteLine( maxMoney );
    }
}