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
            var factory = CryptoFactory.Create();
            var rsa = factory.UseRsa();

            var buildResult = rsa.Build();

            Assert.IsAssignableFrom<IAsymmetricBuildResult>(buildResult);
        }
    }
}
