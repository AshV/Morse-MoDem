namespace MorseCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Modem
    {
        public int TimeUnitInMilliSeconds { get; set; } = 100;

        public string Dot { get; set; } = "●"; // U+25CF

        public string Dash { get; set; } = "▬"; // U+25AC

        public Modem(int timeUnitInMilliSeconds)
        {
            TimeUnitInMilliSeconds = timeUnitInMilliSeconds;
        }
        
    }
}