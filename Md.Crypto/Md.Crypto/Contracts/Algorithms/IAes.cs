namespace Md.Crypto.Contracts.Algorithms
{
    /// <summary>
    ///     The entry point for using aes.
    /// </summary>
    public interface IAes
    {
        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The encryption result.</returns>
        IAesResult Encrypt(string text);

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="keySize">The size of the key in bits.</param>
        /// <param name="text">The text.</param>
        /// <returns>The encryption result.</returns>
        IAesResult Encrypt(int keySize, string text);

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="iv">The initialization vector.</param>
        /// <param name="text">The text.</param>
        /// <param name="key">The secret key.</param>
        /// <returns>The encryption result.</returns>
        IAesResult Encrypt(byte[] key, byte[] iv, string text);
    }
}
