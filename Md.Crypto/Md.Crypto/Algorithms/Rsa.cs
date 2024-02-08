namespace Md.Crypto.Algorithms
{
    using System.Security.Cryptography;
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <inheritdoc cref="IRsa" />
    /// <seealso cref="IRsa" />
    internal class Rsa : Algorithm, IRsa, IAsymmetricBuildResult
    {
        /// <summary>
        ///     The default key size.
        /// </summary>
        private const int DefaultKeySize = 2048;

        /// <summary>
        ///     The internal used instance of the rsa algorithm.
        /// </summary>
        private RSA? rsa;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rsa" /> class.
        /// </summary>
        public Rsa()
            : base(Rsa.DefaultKeySize)
        {
        }

        /// <summary>
        ///     Builds an algorithm instance that support encryption and decryption..
        /// </summary>
        /// <returns>An instance of <see cref="IAsymmetricBuildResult" />.</returns>
        public IAsymmetricBuildResult Build()
        {
            this.rsa = RSA.Create(this.KeySize);
            return this;
        }

        /// <summary>
        ///     Set the used key size.
        /// </summary>
        /// <param name="keySize">Size of the key.</param>
        /// <returns>An instance of IBuilder{IAsymmetricBuildResult}.</returns>
        public IBuilder<IAsymmetricBuildResult> SetKeySize(int keySize)
        {
            this.KeySize = keySize;
            return this;
        }
    }
}
