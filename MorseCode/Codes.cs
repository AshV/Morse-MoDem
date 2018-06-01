namespace MorseCode
{
    using System.Collections.Generic;

    public class Codes
    {
        public string this[char character]
        {
            get
            {
                string code = string.Empty;
                SymbolCodes.TryGetValue(character, out code);
                return code;
            }
        }

        public string GetSignalCode(SignalCodes code)
        {
            return "";
        }

        private static Dictionary<char, string> SymbolCodes = new Dictionary<char, string>
        {
            // Characters
            { 'A',".-" },
            { 'B',"-..." },
            { 'C',"-.-." },
            { 'D',"-.." },
            { 'E',"." },
            { 'F',"..-." },
            { 'G',"--" },
            { 'H',"...." },
            { 'I',".." },
            { 'J',".---" },
            { 'K',"-.-" },
            { 'L',".-.." },
            { 'M',"--" },
            { 'N',"-." },
            { 'O',"---" },
            { 'P',".--." },
            { 'Q',"--.-" },
            { 'R',".-." },
            { 'S',"..." },
            { 'T',"-" },
            { 'U',"..-" },
            { 'V',"...-" },
            { 'W',".--" },
            { 'X',"-..-" },
            { 'Y',"-.--" },
            { 'Z',"--.." },

            // Numbers
            { '0',".----" },
            { '1',"..---" },
            { '2',"...--" },
            { '3',"....-" },
            { '4',"....." },
            { '5',"-...." },
            { '6',"--..." },
            { '7',"---.." },
            { '8',"----." },
            { '9',"-----" },
           
            // Special Characters
            { '.',".-.-.-" }, // Fullstop
            { ',',"--..--" }, // Comma
            { ':',"---..." }, // Colon
            { '?',"..--.." }, // Question Mark
            { '\'',".----." }, // Apostrophe
            { '-',"-....-" }, // Hyphen, dash, minus
            { '/',"-..-." }, // Slash. division
            { '"',".-..-." }, // Quotaion mark
            { '=',"-...-" }, // Equal sign
            { '+',".-.-." }, // Plus
            { '*',"-..-" }, // multiplication
            { '@',".--.-." }, // At the rate of

            // Brackets
            { '(',"-.--." }, // Left bracket
            { '{',"-.--." }, // Left bracket
            { '[',"-.--." }, // Left bracket
            { ')',"-.--.-" }, // right bracket
            { '}',"-.--.-" }, // right bracket
            { ']',"-.--.-" }, // right bracket            
        };

        private static Dictionary<int, string> SignalMorseCodes = new Dictionary<int, string> {
            { 0,"-.-.-" },
            { 1,"-.-" },
            { 2,"...-." },
            { 3,"........" },
            { 4,".-..." },
            { 5,"...-.-" },
        };

    }
}