using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_5
{
    internal class Duration
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
        public Duration(int H ,int M,int S) 
        { 
            Hours = H;
            Minutes = M;
            Seconds = S;
        }
        public Duration(int all)
        {
            Hours = all / 3600;
            all %= 3600;
            Minutes = all / 60;
            Seconds = all % 60;



        }
        public override bool Equals(object obj)
        {
            if (obj is Duration)
            {
                Duration other = (Duration)obj;
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode();
        }
        public override string ToString()
        {
            return $"Hours : {Hours} , Minuts : {Minutes} , Second : {Seconds}";
        }

    }
}
