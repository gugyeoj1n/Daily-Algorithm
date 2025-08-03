public class Solution
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) ), result = 0;

        Dictionary<string, int> map = new Dictionary<string, int>( );
        string[] inputs = new string[N];
        
        for( int i = 0; i < N; i++ )
            map.Add( sr.ReadLine( ), i );
        for( int i = 0; i < N; i++ )
            inputs[i] = sr.ReadLine( );

        for( int i = 0; i < N; i++ )
        {
            for( int j = i + 1; j < N; j++ )
            {
                if(map[inputs[i]] > map[inputs[j]])
                {
                    result++;
                    break;
                }
            }
        }
        
        Console.WriteLine( result );
    }
}