using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace time_test
{
    class Program
    {
        #region
        static void Main( string[ ] args )
        {
            Stopwatch watch = new Stopwatch( );
            //注释语句
            int[ ] numbers = new int[1000000];
            watch.Start( );
         for (int i = 0; i < 25; i++) 
         {
             if ( numbers[i] > 0 )
             numbers[i] = 0;
         }
         watch.Stop( );
  
        Console.WriteLine("Elapsed: {0}",watch.Elapsed);
        Console.WriteLine("In milliseconds: {0}",watch.ElapsedMilliseconds);
        Console.WriteLine( "In timer ticks: {0}", watch.ElapsedTicks );
        Console.ReadLine( );
        }
       #endregion
    }
}
