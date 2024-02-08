namespace Md.Crypto.Algorithms
{
    /// <summary>
    ///     Base class for crypto algorithms.
    /// </summary>
    internal abstract class Algorithm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Algorithm" /> class.
        /// </summary>
        /// <param name="keySize">Size of the key.</param>
        protected Algorithm(int keySize)
        {
            this.KeySize = keySize;
        }

        /// <summary>
        ///     Gets or sets the size of the key.
        /// </summary>
        protected int KeySize { get; set; }
    }
}
