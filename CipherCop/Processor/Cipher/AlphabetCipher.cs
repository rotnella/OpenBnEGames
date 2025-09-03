using System;
using System.ComponentModel;
using System.Dynamic;
namespace BnEGames.CipherCop.Processor.Cipher
{
    public class AlphabetCipher
    {
        private List<char> _codeChars;
        private Dictionary<char, char> _letterToCodeCharMap = new Dictionary<char, char>();
        private Dictionary<char, char> _codeCharToLetterMap = new Dictionary<char, char>();
        public char KeyLetter { get; set; }
        public char KeyCodeChar { get; set; }

        public AlphabetCipher(List<char> codeChars)
        {
            Random random = new Random();
            KeyLetter = (char)('a' + random.Next(0, 26));
            KeyCodeChar = codeChars[random.Next(0, codeChars.Count)];
            _codeChars = codeChars;
            GenerateCipherMaps();
        }

        public AlphabetCipher(char letter, char codeChar, List<char> codeChars)
        {
            if (char.IsWhiteSpace(letter) || char.IsWhiteSpace(codeChar))
                throw new ArgumentException("Letter and codeChar must be non-empty characters.");
            if (letter < 'A' || letter > 'z')
            {
                throw new ArgumentException("Letter must be a-z and codeChar must be a printable ASCII character.");
            }
            KeyLetter =  char.ToLower(letter);
            KeyCodeChar = codeChar;
            _codeChars = codeChars;
            GenerateCipherMaps();
        }

        private void GenerateCipherMaps()
        {
            //The keyLetterIndex and keycodeCharIndex determine the starting point for the mapping.
            int keycodeCharIndex = _codeChars.IndexOf(KeyCodeChar);
            int keyLetterIndex = KeyLetter - 'a';
            char currentLetter;
            char currentCodeChar;
            int currentLetterIndex;
            int currentCodeCharIndex;
            int letterForwardIndex = 0;
            int codeCharForwardIndex = 0;
            for (int i = 0; i < _codeChars.Count; i++)
            {
                currentLetterIndex = keyLetterIndex + i > _codeChars.Count - 1 ? letterForwardIndex++ : keyLetterIndex + i;
                currentCodeCharIndex = keycodeCharIndex + i > _codeChars.Count - 1 ? codeCharForwardIndex++ : keycodeCharIndex + i;
                currentLetter = (char)('a' + currentLetterIndex);
                currentCodeChar = _codeChars[currentCodeCharIndex];
                _letterToCodeCharMap[currentLetter] = currentCodeChar;
                _codeCharToLetterMap[currentCodeChar] = currentLetter;
            }
        }


        public char Encrypt(char letter)
        {
            if (char.IsWhiteSpace(letter))
                throw new ArgumentException("Letter must be a non-empty character.");
            if (letter < 'A' || letter > 'z')
            {
                throw new ArgumentException("Letter must be a-z character.");
            }
            return _letterToCodeCharMap[char.ToLower(letter)];
        }
        public char Decrypt(char codeChar)
        {
            return _codeCharToLetterMap[codeChar];
        }

        public char[] EncryptWord(string word)
        {
            List<char> encryptedChars = new List<char>();
            foreach (char c in word.ToLower().ToCharArray())
            {
                if (c < 'a' || c > 'z')
                {
                    encryptedChars.Add(c);
                    continue;
                }
                char codeChar = Encrypt(c);
                encryptedChars.Add(codeChar);
            }
            return encryptedChars.ToArray();
        }
    }
}
