public class Program
{
    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int[] inputs = Array.ConvertAll( sr.ReadLine( ).Split( ), int.Parse );
        int n = inputs[0], m = inputs[1];
        
        List<string[]> students = new List<string[]>( );
        for ( int i = 0; i < n; i++ )
            students.Add( sr.ReadLine( ).Split( ) );

        for ( int i = 0; i < m; i++ )
        {
            string[] query = sr.ReadLine( ).Split( );
            int matchCount = 0;

            foreach ( var student in students )
            {
                bool subjectMatch = ( query[0] == "-" || query[0] == student[0] );
                bool fruitMatch = ( query[1] == "-" || query[1] == student[1] );
                bool colorMatch = ( query[2] == "-" || query[2] == student[2] );
                if ( subjectMatch && fruitMatch && colorMatch )
                    matchCount++;
            }
            Console.WriteLine( matchCount );
        }
    }
}