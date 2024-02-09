namespace Md.Crypto.Algorithms
{
    using System.Security.Cryptography;
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    internal class Aes : IAesKeyCreator, ISymmetricKey
    {
        /// <summary>
        ///     The default key size.
        /// </summary>
        private const int DefaultKeySize = 256;

        private byte[] iv;

        private byte[] secretKey;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Aes" /> class.
        /// </summary>
        public Aes()
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            this.secretKey = aes.Key;
            this.iv = aes.IV;
        }

        /// <summary>
        ///     Creates a new default aes key.
        /// </summary>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey IAesKeyCreator.Create()
        {
            return ((IAesKeyCreator) this).Create(Aes.DefaultKeySize);
        }

        /// <summary>
        ///     Creates a new aes key.
        /// </summary>
        /// <param name="keySize">The length of the secret key in bits.</param>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey IAesKeyCreator.Create(int keySize)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.KeySize = keySize;

            this.secretKey = aes.Key;
            this.iv = aes.IV;

            return this;
        }

        /// <summary>
        ///     Initializes the aes secret key.
        /// </summary>
        /// <param name="key">The secret key.</param>
        /// ///
        /// <param name="iv">The initialization vector.</param>
        /// <returns>A symmetric key for encrypting and decrypting text using aes.</returns>
        ISymmetricKey IAesKeyCreator.Create(byte[] key, byte[] iv)
        {
            this.secretKey = key;
            this.iv = iv;

            return this;
        }

        /// <summary>
        ///     Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The decrypted text.</returns>
        string ISymmetricKey.Decrypt(byte[] text)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = this.secretKey;
            aes.IV = this.iv;

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
        /// <returns>The encrypted text.</returns>
        byte[] ISymmetricKey.Encrypt(string text)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = this.secretKey;
            aes.IV = this.iv;

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

            return memoryStream.ToArray();
        }
    }
}
