using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Changing the output encoding of the console to support '€' in output
            Console.OutputEncoding = Encoding.UTF8;

            // List of rotors to map characters. Spaces and full stops are ignored.
            List<string> rotors = new List<string>
            {
                "BDFHJLCPRTXVZNYEIWGAKMUSQO",
                "AJDKSIRUXBLHWTMCQGZNPYFVOE",
                "EKMFLGDQVZNTOWYHXUSPAIBRCJ"
            };

            string startMessage = "Error messages are difficult to read.";

            Console.WriteLine("The starting message is: " + startMessage);

            // Encoding the message
            string encodedMessage = EnigmaMachine.Encode(startMessage, 3, rotors);
            Console.WriteLine("\nThe encoded message is: {0}", encodedMessage);

            // Decoding the message
            Console.WriteLine("\n\nDecoding the message: {0}", encodedMessage);

            string decodedMessage = EnigmaMachine.Decode(encodedMessage, 3, rotors);

            Console.WriteLine("\n\nThe decoded message is: {0}\n", decodedMessage);
        }
    }
}
 
