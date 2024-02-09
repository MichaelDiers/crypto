namespace Md.Crypto.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;

    /// <inheritdoc cref="IAesResult" />
    internal class AesResult : IAesResult
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AesResult" /> class.
        /// </summary>
        /// <param name="key">The secret key.</param>
        /// <param name="iv">The initialization vector.</param>
        /// <param name="text">The en- or decrypted text.</param>
        public AesResult(byte[] key, byte[] iv, byte[] text)
        {
            this.Key = key;
            this.Iv = iv;
            this.Text = text;
        }

        /// <summary>
        ///     Gets the initialization vector.
        /// </summary>
        public byte[] Iv { get; }

        /// <summary>
        ///     Gets the secret key.
        /// </summary>
        public byte[] Key { get; }

        /// <summary>
        ///     Gets the encrypted or decrypted text.
        /// </summary>
        public byte[] Text { get; }
    }
}
