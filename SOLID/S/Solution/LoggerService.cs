namespace SOLID.S.Solution; 
interface ILoggerService
{
    void Info(string Info); 
    void Debug(string Info);
    void Error(string Error, Exception ex);  

}

class LoggerService : ILoggerService
{
    public void Info(string Info){

    }

    public void Debug(string Info){

    }

    public void Error(string Error, Exception ex){

    }
}