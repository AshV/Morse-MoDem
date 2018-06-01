namespace MorseCode
{
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
var modem = new Modem();
var message = "Hello, I am AshV";

// Converting to Morse Code
var morseCode = modem.ConvertToMorseCode(message);

WriteLine($"Morse Code for Sentence : {message}");
WriteLine(morseCode);

// Morse Code can be played with generated morse code
WriteLine("Playing from Morse Code.");
modem.PlayMorseTone(morseCode);

// or Can be direactly played by passing sentence
WriteLine("Playing from Message.");
modem.PlayMorseTone(message);
        }
    }
}