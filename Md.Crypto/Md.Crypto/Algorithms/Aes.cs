namespace Md.Crypto.Algorithms
{
    using System.Security.Cryptography;
    using Md.Crypto.Contracts.Algorithms;

    /// <inheritdoc cref="IAes" />
    /// <seealso cref="IAes" />
    internal class Aes : IAes
    {
        /// <summary>
        ///     The default key size.
        /// </summary>
        private const int DefaultKeySize = 256;

        /// <summary>
        ///     Decrypts the specified text.
        /// </summary>
        /// <param name="iv">The initialization vector.</param>
        /// <param name="text">The encrypted text.</param>
        /// <param name="key">The secret key.</param>
        /// <returns>The decryption result.</returns>
        public string Decrypt(byte[] key, byte[] iv, byte[] text)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            var decryptor = aes.CreateDecryptor(
                aes.Key,
                aes.IV);

            using var memoryStream = new MemoryStream(text);
            using var cryptoStream = new CryptoStream(
                memoryStream,
                decryptor,
                CryptoStreamMode.Read);

            using var streamReader = new StreamReader(cryptoStream);

            return streamReader.ReadToEnd();
        }

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The encryption result.</returns>
        public IAesResult Encrypt(string text)
        {
            return this.Encrypt(
                Aes.DefaultKeySize,
                text);
        }

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="keySize">The size of the key in bits.</param>
        /// <param name="text">The text.</param>
        /// <returns>The encryption result.</returns>
        public IAesResult Encrypt(int keySize, string text)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.KeySize = Aes.DefaultKeySize;
            return this.Encrypt(
                aes.Key,
                aes.IV,
                text);
        }

        /// <summary>
        ///     Encrypts the specified text.
        /// </summary>
        /// <param name="iv">The initialization vector.</param>
        /// <param name="text">The text.</param>
        /// <param name="key">The secret key.</param>
        /// <returns>The encryption result.</returns>
        public IAesResult Encrypt(byte[] key, byte[] iv, string text)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using var encryptor = aes.CreateEncryptor(
                aes.Key,
                aes.IV);
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(
                memoryStream,
                encryptor,
                CryptoStreamMode.Write);

            using (var streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.Write(text);
            }

            var encrypted = memoryStream.ToArray();

            return new AesResult(
                key,
                iv,
                encrypted);
        }
    }
}
