namespace Md.Crypto.Test.Algorithms
{
    using System.Text;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="ISymmetricKey" /> using aes.
    /// </summary>
    public class AesSymmetricKeyTests
    {
        /// <summary>
        ///     The file that contains the plain test text.
        /// </summary>
        private const string TestFile = "lorem.txt";

        /// <summary>
        ///     The test text that will be encrypted.
        /// </summary>
        private readonly string testText = File.ReadAllText(
            AesSymmetricKeyTests.TestFile,
            Encoding.UTF8);

        [Fact]
        public void Decrypt()
        {
            var key = CryptoFactory.Create().UseAes().Create();

            var encrypted = key.Encrypt(this.testText);
            var decrypted = key.Decrypt(encrypted);

            Assert.Equal(
                this.testText,
                decrypted);
        }

        [Fact]
        public void Encrypt()
        {
            var encrypted = CryptoFactory.Create().UseAes().Create().Encrypt(this.testText);

            Assert.NotEmpty(encrypted);
        }
    }
}
