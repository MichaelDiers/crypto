namespace Md.Crypto.Test.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="IRsa" />
    /// </summary>
    public class RsaTests
    {
        [Fact]
        public void Build()
        {
            var rsa = CryptoFactory.Create().UseRsa().Build();

            Assert.IsAssignableFrom<IAsymmetricBuildResult>(rsa);
        }

        [Fact]
        public void SetKeySize()
        {
            var rsa = CryptoFactory.Create().UseRsa().SetKeySize(1024);

            Assert.IsAssignableFrom<IBuilder<IAsymmetricBuildResult>>(rsa);
        }
    }
}
