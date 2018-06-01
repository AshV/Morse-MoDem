using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var codes = new Codes();
            Console.Write(codes['A']);
            Console.WriteLine("▬_O.0●");
            Console.WriteLine(".-...-..- .-.-...-- ---.-.-...-.----....__.");
 //           Console.WriteLine(".-...-.._ ._._...__ ___._._..._.____....__.");

            var sequence = Enumerable.Range(0, 3).ToList();
            //while (true)
            {

                sequence.ForEach(e => Console.Beep(650, 100));

                Thread.Sleep(200);

                sequence.ForEach(e => Console.Beep(650, 1));

                Thread.Sleep(200);

                sequence.ForEach(e => Console.Beep(650, 100));

                Thread.Sleep(500);
            }
        }
    }
}