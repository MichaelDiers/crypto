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
            var factory = CryptoFactory.Create();
            var aes = factory.UseAes();

            var buildResult = aes.Build();

            Assert.IsAssignableFrom<ISymmetricBuildResult>(aes);
        }
    }
}
