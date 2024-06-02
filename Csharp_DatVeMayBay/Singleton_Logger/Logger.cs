public class Logger
{
    private static volatile Logger instance;
    private static readonly object padlock = new object();
    private StreamWriter logFile;

    private Logger()
    {
        InitializeLogFile();
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        try
        {
            EnsureLogFileIsInitialized();

            lock (padlock)
            {
                if (logFile.BaseStream.CanWrite)
                {
                    logFile.WriteLine(DateTime.Now.ToString() + " : " + message);
                    logFile.Flush();
                }
                else
                {
                    ReopenLog();

                    logFile.WriteLine(DateTime.Now.ToString() + " : " + message);
                    logFile.Flush();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to log file: " + ex.Message);
        }
    }


    private void EnsureLogFileIsInitialized()
    {
        lock (padlock)
        {
            if (logFile == null)
            {
                ReopenLog();
            }
        }
    }

    private void InitializeLogFile()
    {
        try
        {
            if (logFile == null)
            {
                logFile = File.AppendText("log.txt");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error initializing log file: " + ex.Message);
        }
    }

    public void CloseLog()
    {
        lock (padlock)
        {
            if (logFile != null)
            {
                logFile.Close();
                logFile.Dispose();
            }
        }
    }

    private void ReopenLog()
    {
        if (logFile != null)
        {
            logFile.Dispose();
        }
        logFile = File.AppendText("log.txt");
    }
}
