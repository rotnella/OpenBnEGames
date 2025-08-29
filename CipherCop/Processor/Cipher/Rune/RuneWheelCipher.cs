using System;
using System.Linq;
using BnEGames.Cop.Api;

namespace BnEGames.CipherCop.Processor.Cipher.RuneWheel
{
    public class RuneWheelCipher : Operation<RuneWheelCipherInput, RuneWheelCipherOutput>
    {
        public override object? Compute()
        {
            RuneWheelCipherInput input = Payload;
            if (input == null || string.IsNullOrEmpty(input.WordToEncrypt))
                return new RuneWheelCipherOutput();

            string word = (string)input.WordToEncrypt;
            // split the word into characters
            char[] chars = word.ToCharArray();
            // for each character map to the run in the map

            return new RuneWheelCipherOutput();
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
        public string CypherKey { get; set; }
        public string CypherValue { get; set; }
        public string EncryptedWord { get; set; }
    }
}
