namespace Md.Crypto.Test.Base
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="ICryptoAlgorithmFactory" />
    /// </summary>
    public class CryptoAlgorithmFactoryTests
    {
        /// <summary>
        ///     Test for <see cref="ICryptoAlgorithmFactory.UseAes" />
        /// </summary>
        [Fact]
        public void UseAes()
        {
            var factory = CryptoFactory.Create();
            var aes = factory.UseAes();

            Assert.IsAssignableFrom<IAes>(aes);
            Assert.IsAssignableFrom<IBuilder<ISymmetricBuildResult>>(aes);
            Assert.IsAssignableFrom<IKeySize<IBuilder<ISymmetricBuildResult>, ISymmetricBuildResult>>(aes);
        }

        /// <summary>
        ///     Test for <see cref="ICryptoAlgorithmFactory.UseRsa" />
        /// </summary>
        [Fact]
        public void UseRsa()
        {
            var factory = CryptoFactory.Create();
            var rsa = factory.UseRsa();

            Assert.IsAssignableFrom<IRsa>(rsa);
            Assert.IsAssignableFrom<IBuilder<IAsymmetricBuildResult>>(rsa);
            Assert.IsAssignableFrom<IKeySize<IBuilder<IAsymmetricBuildResult>, IAsymmetricBuildResult>>(rsa);
        }
    }
}
