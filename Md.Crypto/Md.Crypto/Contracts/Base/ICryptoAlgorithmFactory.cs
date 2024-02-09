namespace Md.Crypto.Contracts.Base
{
    using Md.Crypto.Contracts.Algorithms;

    /// <summary>
    ///     A factory that provides cryptographic algorithms.
    /// </summary>
    public interface ICryptoAlgorithmFactory
    {
        /// <summary>
        ///     Initialize an aes key creator.
        /// </summary>
        /// <returns>A key creator for aes secret keys.</returns>
        IAesKeyCreator UseAes();

        /// <summary>
        ///     Use RSA.
        /// </summary>
        /// <returns>The entry point for using rsa.</returns>
        IRsa UseRsa();
    }
}
