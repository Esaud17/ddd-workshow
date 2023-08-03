namespace AHT.CrossCuting.Commons.AHTLogger
{
    public interface ICustomLogger
    {
        void Debug(string method, string message);
        void Error(string method, string message);
    }
}