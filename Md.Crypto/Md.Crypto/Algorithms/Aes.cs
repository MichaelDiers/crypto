namespace Md.Crypto.Algorithms
{
    using Md.Crypto.Contracts.Algorithms;
    using Md.Crypto.Contracts.Base;

    /// <inheritdoc cref="IAes" />
    /// <seealso cref="IAes" />
    internal class Aes : IAes, ISymmetricBuildResult
    {
        /// <summary>
        ///     The internal used instance of the aes algorithm.
        /// </summary>
        private System.Security.Cryptography.Aes? aes;

        /// <summary>
        ///     Builds an algorithm instance that support encryption and decryption..
        /// </summary>
        /// <returns>An instance of <see cref="ISymmetricBuildResult" />.</returns>
        public ISymmetricBuildResult Build()
        {
            this.aes = System.Security.Cryptography.Aes.Create();
            return this;
        }
    }
}
