using System.Collections.Generic;

public class Program
{
    public class Turn
    {
        public string Number { get; set; }
        public int Strikes { get; set; }
        public int Balls { get; set; }
    }

    public static ( int, int ) Check( Turn turn, string target )
    {
        int strikes = 0, balls = 0;
        
        for ( int i = 0; i < 3; i++ )
            if( target[i] == turn.Number[i] )
                strikes++;
        
        for ( int i = 0; i < 3; i++ )
            for ( int j = 0; j < 3; j++ )
            {
                if ( i == j )
                    continue;
                if ( target[i] == turn.Number[j] )
                    balls++;
            }

        return ( strikes, balls );
    }

    public static void Main( string[] args )
    {
        StreamReader sr = new StreamReader( Console.OpenStandardInput( ) );
        int N = int.Parse( sr.ReadLine( ) );
        Turn[] turns = new Turn[N];

        for ( int i = 0; i < N; i++ )
        {
            string[] input = sr.ReadLine( ).Split( );
            string number = input[0]; int strikes = int.Parse( input[1] ); int balls = int.Parse( input[2] );
            turns[i] = new Turn
            {
                Number = number,
                Strikes = strikes,
                Balls = balls
            };
        }

        int result = 0;
        for ( int i = 1; i <= 9; i++ )
        {
            for ( int j = 1; j <= 9; j++ )
            {
                for ( int k = 1; k <= 9; k++ )
                {
                    if ( i == j || j == k || i == k )
                        continue;
                    
                    string target = $"{i}{j}{k}";
                    bool isOk = true;
                    
                    foreach ( Turn turn in turns )
                    {
                        var ( checkedS, checkedB ) = Check( turn, target );
                        if ( checkedS != turn.Strikes || checkedB != turn.Balls )
                        {
                            isOk = false;
                            break;
                        }
                    }

                    if ( isOk )
                        result++;
                }
            }
        }
        
        Console.WriteLine( result );
    }
}