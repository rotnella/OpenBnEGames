// Suppress CS8600: Converting null literal or possible null value to non-nullable type
#pragma warning disable CS8600
// Suppress CS8602: Dereference of a possibly null reference
#pragma warning disable CS8602
// Suppress CS8604: Possible null reference argument
#pragma warning disable CS8604
using BnEGames.CipherCop.Processor;
using BnEGames.Cop.Processor;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Xunit;

namespace BnEGames.CipherCop.Tests
{
    public class CipherCopProcessorTest
    {
        private readonly CipherCopProcessor copProcessor;  
        public CipherCopProcessorTest()
        {
            copProcessor = new CipherCopProcessor();
        }

        [Fact]
        public void TestConditionRunner()
        {
            string json = ReadFile("CipherCopPlan.json");
            JContainer container = JObject.Parse(json);
            copProcessor.Process(container);
            string result = container.ToString();
            Assert.NotNull(result);
        }

        private string RemoveWhitespace(string text)
        {
            return text.Replace("\n", "").Replace("\r", "").Replace(" ", "");
        }
        private string ReadFile(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(str => str.EndsWith(filename));
            if (resourceName == null)
            {
                Assert.True(false, $"Unable to read file {filename}");
            }
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                if(result == null)
                {
                    Assert.True(false, $"Unable to read file {filename}");
                }
                return result ?? "";
            }
        }
    }
}