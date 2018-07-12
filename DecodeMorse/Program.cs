using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeMorse
{
    public class Program
    {
        static Dictionary<string, string> translator = new Dictionary<string, string>()
        {
            { ".-", "a" },
            { "-...", "b" },
            { "-.-.", "c" },
            { "-..", "d" },
            { ".", "e" },
            { "..-.", "f" },
            { "--.", "g" },
            { "....", "h" },
            { "..", "i" },
            { ".---", "j" },
            { "-.-", "k" },
            { ".-..", "l" },
            { "--", "m" },
            { "-.", "n" },
            { "---", "o" },
            { ".--.", "p" },
            { "--.-", "q" },
            { ".-.", "r" },
            { "...", "s" },
            { "-", "t" },
            { "..-", "u" },
            { "...-", "v" },
            { ".--", "x" },
            { "-.--", "y" },
            { "--..", "z" },
            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-", "4"},
            {".....", "5"},
            {"-....", "6"},
            {"--...", "7"},
            {"---..", "8"},
            {"----.", "9"}
        };
        
        static void Main(string[] args)
        {
            GetUserInput();
        }
                
        /// <summary>
        /// Richiedo il codice Morse da decodificare
        /// </summary>
        public static void GetUserInput()
        {
            string input;
            Console.WriteLine("Insert Morse code:");
            input = Console.ReadLine();
            input = input.Trim();
            Console.WriteLine("Your Morse code decode is: " + Translate(input));
            GetUserInput();            
        }

        /// <summary>
        /// Decodificare il codice Morse
        /// </summary>
        public static string Translate(string input)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //estraggo le parole dal codice Morse Inserito
            string[] arrayWordMorse = input.Split(new[] { "   " }, StringSplitOptions.None);
            foreach (string wordMorse in arrayWordMorse)
            {
                //estraggo le lettere dalle parole del codice Morse Inserito
                string[] arrayLetterMorse = wordMorse.Split(new[] { " " }, StringSplitOptions.None);
                foreach (string letterMorse in arrayLetterMorse)
                {
                    if (translator.ContainsKey(letterMorse))
                    {
                        //aggiungo la lettere decodificata all stringa di ritorno
                        sb.Append(translator[letterMorse]);
                    }
                }
                sb.Append(" ");
            }

            return sb.ToString().ToUpper().Trim();
        }
    }
}
