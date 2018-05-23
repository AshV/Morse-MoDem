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

        public Modem(int timeUnitInMilliSeconds)
        {
            TimeUnitInMilliSeconds = timeUnitInMilliSeconds;
        }

        public Dictionary<char, string> SymbolCodes = new Dictionary<char, string>()
        {
            // Characters
            { 'A',"s" },
            { 'B',"s" },
            { 'C',"s" },
            { 'D',"s" },
            { 'E',"s" },
            { 'F',"s" },
            { 'G',"s" },
            { 'H',"s" },
            { 'I',"s" },
            { 'J',"s" },
            { 'K',"s" },
            { 'L',"s" },
            { 'M',"s" },
            { 'N',"s" },
            { 'O',"s" },
            { 'P',"s" },
            { 'Q',"s" },
            { 'R',"s" },
            { 'S',"s" },
            { 'T',"s" },
            { 'U',"s" },
            { 'V',"s" },
            { 'W',"s" },
            { 'X',"s" },
            { 'Y',"s" },
            { 'Z',"s" },

            // Numbers
            { '0',"s" },
            { '1',"s" },
            { '2',"s" },
            { '3',"s" },
            { '4',"s" },
            { '5',"s" },
            { '6',"s" },
            { '7',"s" },
            { '8',"s" },
            { '9',"s" },

            // Special Characters
            { '.',"s" }, // Fullstop
            { ',',"s" }, // Comma
            { ':',"s" }, // Colon
            { '?',"s" }, // Question Mark
        // need to escape    { 'a',"s" }, // Apostrophe
            { '-',"s" }, // Hyphen, dash, minus
            { '/',"s" }, // Slash. division
            { '"',"s" }, // Quotaion mark
            { '=',"s" }, // Equal sign
            { '+',"s" }, // Plus
            { '*',"s" }, // multiplication
            { '@',"s" }, // At the rate of

            // Brackets
            { '(',"s" }, // Left bracket
            { ')',"s" }, // right bracket
            { '{',"s" }, // Left bracket
            { '}',"s" }, // right bracket
            { '[',"s" }, // Left bracket
            { ']',"s" }, // right bracket
            
        };
    }
}