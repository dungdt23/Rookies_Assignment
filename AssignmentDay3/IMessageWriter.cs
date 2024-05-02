namespace AssignmentDay3
{
    public interface IMessageWriter
    {
        void WriteLog(string message,string filePath);
        void Log(string message);
    }
}
