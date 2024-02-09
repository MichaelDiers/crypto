namespace Md.Crypto.Test.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="IAesKeyCreator" />.
    /// </summary>
    public class AesKeyCreatorTests
    {
        [Fact]
        public void CreateDefault()
        {
            var key = CryptoFactory.Create().UseAes().Create();

            Assert.IsAssignableFrom<ISymmetricKey>(key);
        }

        [Fact(Skip = "Not Implemented")]
        public void CreateUsingKeyAndIv()
        {
        }

        [Fact]
        public void CreateUsingKeySize()
        {
            var key = CryptoFactory.Create().UseAes().Create(256);

            Assert.IsAssignableFrom<ISymmetricKey>(key);
        }
    }
}
