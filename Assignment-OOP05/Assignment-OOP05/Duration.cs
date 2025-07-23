using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP05
{
    internal class Duration
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;    
            seconds = _seconds;
        }
        public Duration(int totalseconds)
        {
            hours = totalseconds / 3600;
            totalseconds%=3600;
            minutes = totalseconds / 60;
            seconds = totalseconds % 60;

        }
        public override string ToString()
        {
            return $"hours : {hours}, minutes : {minutes}, seconds : {seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration d)
            {
                return hours == d.hours && minutes == d.minutes && seconds == d.seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (hours, minutes, seconds).GetHashCode();
        }
        public int ToSeconds() => hours * 3600 + minutes * 60 + seconds;

        //D3=D1+D2
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() + d2.ToSeconds());
        }
        //D3 = D1 + 7800
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToSeconds() + seconds);
        }
        //D3 = 666 + D3
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.ToSeconds() + seconds);
        }
        //D3 = D1 - D2
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() - d2.ToSeconds());
        }
        //++D1 
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToSeconds() + 60);
        }
        //--D2
        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToSeconds() - 60);
        }
        //If (D1 > D2)
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }
        // If (D1 <= D2)
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() >= d2.ToSeconds();
        }
        // If (D1)
        public static bool operator true(Duration d)
        {
            return d.ToSeconds() > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.ToSeconds() <= 0;
        }
    
        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today.AddHours(d.hours).AddMinutes(d.minutes).AddSeconds(d.seconds);
        }
    }
}
