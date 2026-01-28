using Xunit;
using RovarApi;

namespace RovarApi.Tests
{
    public class RovarTranslatorTests
    {
        [Fact]
        public void ToRovarsprak_ShouldEncryptCorrectly()
        {
            var translator = new RovarTranslator();
            // Rättat: "Totesostot" (inget 'o' efter 'e')
            string expected = "Totesostot";
            string actual = translator.ToRovarsprak("Test");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FromRovarsprak_ShouldDecryptCorrectly()
        {
            var translator = new RovarTranslator();
            string expected = "Test";
            // Rättat: Använd den korrekta rövarsträngen här också
            string actual = translator.FromRovarsprak("Totesostot");

            Assert.Equal(expected, actual);
        }
    }
}