using System;
using Xunit;
using BnEGames.CipherCop.Processor.Cipher.Rune;
using System.Linq;

namespace BnEGames.CipherCop.Tests
{
    public class RuneWheelCipherTest
    {
        [Fact]
        public void AlphabetToRune_Map()
        {
            RuneToAlphabetCipher runeMap = new RuneToAlphabetCipher('D', 'ᛓ');
            Assert.Equal('ᛓ', runeMap.Encrypt('D'));
            Assert.Equal('d', runeMap.Decrypt('ᛓ'));
            Assert.Equal('ᛒ', runeMap.Encrypt('E'));
        
            runeMap = new RuneToAlphabetCipher('a', 'ᛉ');
            Assert.Equal('ᛉ', runeMap.Encrypt('a'));
            Assert.Equal('a', runeMap.Decrypt('ᛉ'));
            Assert.Equal('ᛈ', runeMap.Encrypt('B'));
            Assert.Equal('ᛎ', runeMap.Encrypt('n'));
        }

        // Add more tests for RuneWheelCipher APIs as needed
    }
}
