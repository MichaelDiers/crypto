namespace Md.Crypto.Contracts.Base
{
    /// <summary>
    ///     Support for setting the used key size of an algorithm.
    /// </summary>
    /// <typeparam name="TKeySizeResult">The type of the <see cref="SetKeySize" /> result.</typeparam>
    /// <typeparam name="TBuilderResult">Specifies the type param for <see cref="IBuilder{T}" />.</typeparam>
    public interface IKeySize<out TKeySizeResult, out TBuilderResult> : IBuilder<TBuilderResult>
    {
        /// <summary>
        ///     Set the used key size.
        /// </summary>
        /// <param name="keySize">Size of the key.</param>
        /// <returns>An instance of <typeparamref name="TKeySizeResult" />.</returns>
        TKeySizeResult SetKeySize(int keySize);
    }
}
