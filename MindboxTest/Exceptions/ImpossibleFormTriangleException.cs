namespace MindboxTest.Exceptions
{
    /// <summary>
    /// An exception throws when triangle with given parameters can't exists.
    /// Inherits from ArgumentException. 
    /// </summary>
    public class ImpossibleFormTriangleException: ArgumentException
    {
        public ImpossibleFormTriangleException(string message)
        : base(message)
        {

        }
    }
}
