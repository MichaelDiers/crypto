namespace Md.Crypto.Test.Algorithms
{
    using System.Text;
    using Md.Crypto.Contracts.Algorithms;

    /// <summary>
    ///     Tests for <see cref="IAes" />.
    /// </summary>
    public class AesTests
    {
        /// <summary>
        ///     The file that contains the plain test text.
        /// </summary>
        private const string TestFile = "lorem.txt";

        /// <summary>
        ///     The test text that will be encrypted.
        /// </summary>
        private readonly string testText = File.ReadAllText(
            AesTests.TestFile,
            Encoding.UTF8);

        [Fact]
        public void EncryptUsingText()
        {
            var result = CryptoFactory.Create().UseAes().Encrypt(this.testText);

            Assert.IsAssignableFrom<IAesResult>(result);
        }

        [Fact]
        public void EncryptUsingTextAndKeySize()
        {
            const int keySize = 128;

            var result = CryptoFactory.Create()
            .UseAes()
            .Encrypt(
                keySize,
                this.testText);

            Assert.IsAssignableFrom<IAesResult>(result);
        }

        [Fact]
        public void EncryptUsingTextKeyAndIv()
        {
            var initResult = CryptoFactory.Create().UseAes().Encrypt(this.testText);

            var result = CryptoFactory.Create()
            .UseAes()
            .Encrypt(
                initResult.Key,
                initResult.Iv,
                this.testText);

            Assert.IsAssignableFrom<IAesResult>(result);
        }
    }
}
