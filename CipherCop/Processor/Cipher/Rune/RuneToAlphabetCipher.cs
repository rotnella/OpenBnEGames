using System;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata;
namespace BnEGames.CipherCop.Processor.Cipher.Rune
{
    public class RuneToAlphabetCipher : AlphabetCipher
    {
        private static List<char> _runes = new List<char>() { 'ᛣ', 'ᛚ', 'ᛜ', 'ᛉ', 'ᛈ', 'ᚱ', 'ᚲ', 'ᛟ', 'ᚺ', 'ᛓ', 'ᛒ', 'ᚹ', 'ᛋ', 'ᛁ', 'ᚾ', 'ᛃ', 'ᛎ', 'ᚦ', 'ᛖ', 'ᚷ', 'ᚨ', 'ᚢ', 'ᛗ', 'ᛞ', 'ᛖ', 'ᛇ' };

        public char KeyRune { get; set; }

        public RuneToAlphabetCipher() : base(_runes)
        {
            Random random = new Random();
            KeyRune = _runes[random.Next(0, _runes.Count)];
        }

        public RuneToAlphabetCipher(char letter, char rune) : base(letter, rune, _runes)
        {
            KeyRune = KeyCodeChar;
        }
    }
}
