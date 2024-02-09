namespace Md.Crypto.Contracts.Algorithms
{
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     Create or initialize an aes key.
    /// </summary>
    public interface IAesKeyCreator
    {
        /// <summary>
        ///     Creates a new default aes key.
        /// </summary>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey Create();

        /// <summary>
        ///     Creates a new aes key.
        /// </summary>
        /// <param name="keySize">The length of the secret key in bits.</param>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey Create(int keySize);

        /// <summary>
        ///     Initializes the aes secret key.
        /// </summary>
        /// <param name="key">The secret key.</param>
        /// ///
        /// <param name="iv">The initialization vector.</param>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey Create(byte[] key, byte[] iv);
    }
}
