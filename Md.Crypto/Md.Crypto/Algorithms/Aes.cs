namespace Md.Crypto.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <inheritdoc cref="IAes" />
    /// <seealso cref="IAes" />
    internal class Aes : Algorithm, IAes, ISymmetricBuildResult
    {
        /// <summary>
        ///     The default key size.
        /// </summary>
        private const int DefaultKeySize = 256;

        /// <summary>
        ///     The internal used instance of the aes algorithm.
        /// </summary>
        private System.Security.Cryptography.Aes? aes;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Aes" /> class.
        /// </summary>
        public Aes()
            : base(Aes.DefaultKeySize)
        {
        }

        /// <summary>
        ///     Builds an algorithm instance that support encryption and decryption..
        /// </summary>
        /// <returns>An instance of <see cref="ISymmetricBuildResult" />.</returns>
        public ISymmetricBuildResult Build()
        {
            this.aes = System.Security.Cryptography.Aes.Create();
            this.aes.KeySize = this.KeySize;
            return this;
        }

        /// <summary>
        ///     Set the used key size.
        /// </summary>
        /// <param name="keySize">Size of the key.</param>
        /// <returns>An instance of IBuilder{ISymmetricBuildResult}.</returns>
        public IBuilder<ISymmetricBuildResult> SetKeySize(int keySize)
        {
            this.KeySize = keySize;
            return this;
        }
    }
}
