using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneAndTwo
{
    internal class BeerSong
    {
        int songLength;



        public char AddLetterS(int value)
        {
            if (value > 1)
            {
                return 's';
            }
            return ' ';
        }       
        public void singBeerSong(int songLength)
        {
           for(int start = songLength;start>=1;start--)
            {

                if (start >= 1)
                {
                    Console.WriteLine($"{start} bottle{AddLetterS(start).ToString().Trim()} of beer on the wall, {start} bottle{AddLetterS(start).ToString().Trim()} of beer.");
                    
                }

                if (start  >1)
                {
                    Console.WriteLine($"Take one down and pass it around, {start - 1} bottle{AddLetterS(start-1).ToString().Trim()} of beer on the wall.");
                }
           }
        }
    }
}
