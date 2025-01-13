using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Enigma
{
    public static class EnigmaMachine
    {
        public static string Encode(string message, int incrementNumber, List<string> rotors)
        {
            message = FormatInputMessage(message);
            message = CaesarShift(message, incrementNumber, true);

            foreach (var rotor in rotors)
            {
                message = ApplyRotor(message, rotor);
            }

            return message;
        }

        public static string Decode(string message, int incrementNumber, List<string> rotors)
        {
            for (int i = rotors.Count - 1; i >= 0; i--)
            {
                message = ReverseRotor(message, rotors[i]);
            }

            message = CaesarShift(message, -incrementNumber, false);
            return FormatOutputMessage(message);
        }

        public static string FormatInputMessage(string message)
        {
            message = Regex.Replace(message.ToUpper(), "[^A-Z .]", "");
            message = message.Replace(" ", "?").Replace(".", "€");
            return message;
        }

        public static string FormatOutputMessage(string message)
        {
            message = message.Replace("?", " ").Replace("€", ".").ToLower();

            StringBuilder formattedMessage = new StringBuilder();
            bool capitalizeNext = true;

            foreach (char c in message)
            {
                if (capitalizeNext && char.IsLetter(c))
                {
                    formattedMessage.Append(char.ToUpper(c));
                    capitalizeNext = false;
                }
                else
                {
                    formattedMessage.Append(c);
                }

                if (c == '.')
                {
                    capitalizeNext = true;
                }
            }

            return formattedMessage.ToString();
        }

        public static string CaesarShift(string message, int shift, bool encode)
        {
            StringBuilder shiftedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int effectiveShift = encode ? shift++ : shift--;
                    int newChar = ((c - 'A' + effectiveShift) % 26 + 26) % 26 + 'A';
                    shiftedMessage.Append((char)newChar);
                }
                else
                {
                    shiftedMessage.Append(c);
                }
            }

            return shiftedMessage.ToString();
        }

        private static string ApplyRotor(string message, string rotor)
        {
            StringBuilder transformedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    transformedMessage.Append(rotor[c - 'A']);
                }
                else
                {
                    transformedMessage.Append(c);
                }
            }

            return transformedMessage.ToString();
        }

        private static string ReverseRotor(string message, string rotor)
        {
            StringBuilder transformedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    transformedMessage.Append((char)('A' + rotor.IndexOf(c)));
                }
                else
                {
                    transformedMessage.Append(c);
                }
            }

            return transformedMessage.ToString();
        }
    }
}
