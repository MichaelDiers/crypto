namespace Md.Crypto
{
    using Md.Crypto.Base;
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Factory for creating an <see cref="ICryptoAlgorithmFactory" />
    ///     that is the entry point for using cryptographic algorithms
    ///     provided by the library.
    /// </summary>
    public static class CryptoFactory
    {
        /// <summary>
        ///     Creates a new factory for crypto algorithms.
        /// </summary>
        /// <returns>A <see cref="ICryptoAlgorithmFactory" /> factory.</returns>
        public static ICryptoAlgorithmFactory Create()
        {
            return new CryptoAlgorithmFactory();
        }
    }
}
