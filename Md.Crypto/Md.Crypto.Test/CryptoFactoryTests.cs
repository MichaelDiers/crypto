namespace Md.Crypto.Test
{
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Tests for <see cref="CryptoFactory" />.
    /// </summary>
    public class CryptoFactoryTests
    {
        /// <summary>
        ///     Test for <see cref="CryptoFactory.Create" />.
        /// </summary>
        [Fact]
        public void InitializeTheFactory()
        {
            var factory = CryptoFactory.Create();

            Assert.IsAssignableFrom<ICryptoAlgorithmFactory>(factory);
        }
    }
}
