
using BnEGames.Cop.Api;

namespace BnEGames.CipherCop.Processor.Cipher.Rune
{
    public class RuneWheelCipher : Operation<RuneWheelCipherInput, RuneWheelCipherOutput>
    {
        public override object? Compute()
        {
            RuneWheelCipherInput input = Payload;
            if (input == null || string.IsNullOrEmpty(input.WordToEncrypt))
                return null;

            string word = (string)input.WordToEncrypt;
            return new RuneWheelCipherOutput(word);
        }
    }
    public class RuneWheelCipherInput
    {
        public RuneWheelCipherInput()
        {
            WordToEncrypt = string.Empty;
        }
        public string WordToEncrypt { get; set; }
    }
    public class RuneWheelCipherOutput
    {
        public RuneWheelCipherOutput(string word)
        {
            RuneToAlphabetCipher runeMap = new RuneToAlphabetCipher();
            CypherKeyRune = runeMap.KeyRune.ToString();
            CypherKeyLetter = runeMap.KeyLetter.ToString();
            EncryptedWord = runeMap.EncryptWord(word);
        }
        public string CypherKeyRune { get; set; }
        public string CypherKeyLetter { get; set; }
        public char[] EncryptedWord { get; set; }
    }
}
