namespace Md.Crypto.Contracts.Base
{
    /// <summary>
    ///     Describes operations on symmetric keys.
    /// </summary>
    public interface ISymmetricKey
    {
        /// <summary>
        ///     Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The decrypted text.</returns>
        string Decrypt(byte[] text);

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The encrypted text.</returns>
        byte[] Encrypt(string text);
    }
}
