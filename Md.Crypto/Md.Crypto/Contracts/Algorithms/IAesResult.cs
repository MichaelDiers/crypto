namespace Md.Crypto.Contracts.Algorithms
{
    /// <summary>
    ///     Describes en- and decryption result of the aes algorithm.
    /// </summary>
    public interface IAesResult
    {
        /// <summary>
        ///     Gets the initialization vector.
        /// </summary>
        byte[] Iv { get; }

        /// <summary>
        ///     Gets the secret key.
        /// </summary>
        byte[] Key { get; }

        /// <summary>
        ///     Gets the encrypted or decrypted text.
        /// </summary>
        byte[] Text { get; }
    }
}
