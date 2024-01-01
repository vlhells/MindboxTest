namespace MindboxTest.Exceptions
{
    /// <summary>
    /// An exception throws when one or more args are negative or zero.
    /// Inherits from ArgumentException. 
    /// </summary>
    public class NegativeOrZeroValueException: ArgumentException
    {
        public NegativeOrZeroValueException(string message)
        : base(message)
        {
            
        }
    }
}
