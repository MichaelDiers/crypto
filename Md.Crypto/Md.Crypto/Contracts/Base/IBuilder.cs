namespace Md.Crypto.Contracts.Base
{
    /// <summary>
    ///     Build support for a crypto algorithm.
    /// </summary>
    /// <typeparam name="T">The type of the build result.</typeparam>
    public interface IBuilder<out T>
    {
        /// <summary>
        ///     Builds an algorithm instance that support encryption and decryption..
        /// </summary>
        /// <returns>An instance of <typeparamref name="T" />.</returns>
        T Build();
    }
}
