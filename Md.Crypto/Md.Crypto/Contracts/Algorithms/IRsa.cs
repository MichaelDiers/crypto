namespace Md.Crypto.Contracts.Algorithms
{
    using Md.Crypto.Contracts.Base;

    /// <summary>
    ///     The entry point for using rsa.
    /// </summary>
    public interface IRsa : IKeySize<IBuilder<IAsymmetricBuildResult>, IAsymmetricBuildResult>
    {
    }
}
