namespace Parcial1_Base.Logic
{
    public interface IClonable<T>
    {
        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new object with the same values of this instance</returns>
        T Copy();
    }
}