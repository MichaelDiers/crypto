namespace Md.Crypto.Contracts.Base
{
    using Md.Crypto.Contracts.Algorithms;

    /// <summary>
    ///     A factory that provides cryptographic algorithms.
    /// </summary>
    public interface ICryptoAlgorithmFactory
    {
        /// <summary>
        ///     Use AES.
        /// </summary>
        /// <returns>The entry point for using aes.</returns>
        IAes UseAes();

        /// <summary>
        ///     Use RSA.
        /// </summary>
        /// <returns>The entry point for using rsa.</returns>
        IRsa UseRsa();
    }
}
