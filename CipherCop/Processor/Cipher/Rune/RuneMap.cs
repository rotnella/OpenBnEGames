namespace BnEGames.CipherCop.Processor.Cipher.Rune
{
    public class RuneMap
    {
        // Immutable dictionary mapping A-Z to Unicode Runic characters (U+16A0 to U+16B9)
        public static readonly System.Collections.Immutable.ImmutableDictionary<char, char> AlphabetToRune =
            System.Collections.Immutable.ImmutableDictionary.CreateRange(
                Enumerable.Range(0, 26).Select(i =>
                    new System.Collections.Generic.KeyValuePair<char, char>(
                        (char)('A' + i),
                        (char)(0x16A0 + i)
                    )
                )
            );
    }
}