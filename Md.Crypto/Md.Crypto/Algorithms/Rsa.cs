namespace Md.Crypto.Algorithms
{
    using System.Security.Cryptography;
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <inheritdoc cref="IRsa" />
    /// <seealso cref="IRsa" />
    internal class Rsa : IRsa, IAsymmetricBuildResult
    {
        /// <summary>
        ///     The internal used instance of the rsa algorithm.
        /// </summary>
        private RSA? rsa;

        /// <summary>
        ///     Builds an algorithm instance that support encryption and decryption..
        /// </summary>
        /// <returns>An instance of <see cref="IAsymmetricBuildResult" />.</returns>
        public IAsymmetricBuildResult Build()
        {
            this.rsa = RSA.Create();
            return this;
        }
    }
}
