using System;
using Xunit;
using BnEGames.CipherCop.Processor.Cipher.Rune;
using System.Linq;

namespace BnEGames.CipherCop.Tests
{
    public class RuneWheelCipherTest
    {
        [Fact]
        public void AlphabetToRune_MapsAllLetters()
        {
            foreach (char c in Enumerable.Range('A', 26).Select(i => (char)i))
            {
                char rune = RuneMap.AlphabetToRune[c];
                Console.WriteLine($"{c} -> U+{((int)rune):X4} ({rune})");
            }
        }

        // Add more tests for RuneWheelCipher APIs as needed
    }
}
