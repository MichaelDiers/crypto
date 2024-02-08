namespace Md.Crypto.Base
{
    using Md.Crypto.Algorithms;
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <inheritdoc cref="ICryptoAlgorithmFactory" />
    /// <seealso cref="Contracts.Base.ICryptoAlgorithmFactory" />
    internal class CryptoAlgorithmFactory : ICryptoAlgorithmFactory
    {
        /// <summary>
        ///     Use AES.
        /// </summary>
        /// <returns>The entry point for using aes.</returns>
        public IAes UseAes()
        {
            return new Aes();
        }

        /// <summary>
        ///     Use RSA.
        /// </summary>
        /// <returns>The entry point for using rsa.</returns>
        public IRsa UseRsa()
        {
            return new Rsa();
        }
    }
}
