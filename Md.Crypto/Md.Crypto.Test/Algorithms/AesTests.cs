namespace Md.Crypto.Test.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="IAes" />.
    /// </summary>
    public class AesTests
    {
        [Fact]
        public void Build()
        {
            var aes = CryptoFactory.Create().UseAes().Build();

            Assert.IsAssignableFrom<ISymmetricBuildResult>(aes);
        }

        [Fact]
        public void SetKeySize()
        {
            var aes = CryptoFactory.Create().UseAes().SetKeySize(1000);

            Assert.IsAssignableFrom<IBuilder<ISymmetricBuildResult>>(aes);
        }
    }
}
