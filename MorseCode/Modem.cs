namespace MorseCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class Modem
    {
        private int TimeUnitInMilliSeconds { get; set; } = 100;

        private int Frequency { get; set; } = 650;

        public char DotUnicode { get; set; } = '●'; // U+25CF

        public char DashUnicode { get; set; } = '▬'; // U+25AC

        public char Dot { get; set; } = '.';

        public char Dash { get; set; } = '-';

        Codes codeStore;

        public Modem()
        {
            codeStore = new Codes();
        }

        public Modem(int timeUnitInMilliSeconds) : this()
        {
            TimeUnitInMilliSeconds = timeUnitInMilliSeconds;
        }

        public string ConvertToMorseCode(string sentence, bool addStartAndEndSignal = false)
        {
            var generatedCodeList = new List<string>();
            var wordsInSentence = sentence.Split(' ');

            if (addStartAndEndSignal)
            {
                generatedCodeList.Add(codeStore.GetSignalCode(SignalCodes.StartingSignal));
            }

            foreach (var word in wordsInSentence)
            {
                foreach (var letter in word.ToUpperInvariant().ToCharArray())
                {
                    generatedCodeList.Add(codeStore[letter]);
                }
                generatedCodeList.Add("_");
            }

            if (addStartAndEndSignal)
            {
                generatedCodeList.Add(codeStore.GetSignalCode(SignalCodes.EndOfWork));
            }
            else
            {
                generatedCodeList.RemoveAt(generatedCodeList.Count - 1);
            }

            return string.Join(" ", generatedCodeList).Replace(" _ ", "  ");
        }

        public void PlayMorseTone(string morseStringOrSentence)
        {
            if (IsValidMorse(morseStringOrSentence))
            {
                var pauseBetweenLetters = "_"; // One Time Unit
                var pauseBetweenWords = "_______"; // Seven Time Unit

                morseStringOrSentence = morseStringOrSentence.Replace("  ", pauseBetweenWords);
                morseStringOrSentence = morseStringOrSentence.Replace(" ", pauseBetweenLetters);

                foreach (var character in morseStringOrSentence.ToCharArray())
                {
                    switch (character)
                    {
                        case '.':
                            Console.Beep(Frequency, TimeUnitInMilliSeconds);
                            break;
                        case '-':
                            Console.Beep(Frequency, TimeUnitInMilliSeconds * 3);
                            break;
                        case '_':
                            Thread.Sleep(TimeUnitInMilliSeconds);
                            break;
                    }
                }
            }
            else
            {
                PlayMorseTone(ConvertToMorseCode(morseStringOrSentence));
            }
        }

        private bool IsValidMorse(string sentence)
        {
            var countDot = sentence.Count(x => x == '.');
            var countDash = sentence.Count(x => x == '-');
            var countSpace = sentence.Count(x => x == ' ');

            return
                sentence.Length > (countDot + countDash + countSpace)
                ? false : true;
        }
    }
}