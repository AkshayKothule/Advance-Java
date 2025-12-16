namespace MVCLab.Logger;

public class FileLogger
{
    private static FileLogger fileLogger = new FileLogger();
    private FileLogger()
    {
        
    }

    public static FileLogger CurrentLogger
    {
        get{return fileLogger;}
    }

    public void Log(string message)
    {
        string path = "//Users//akshaykothule//IACSD//Study Material//DotNet//Lab//MVCLab//log.txt";
        FileStream stream = null;
        if (File.Exists(path))
        {
            // append the data
            stream = new  FileStream(path, FileMode.Append  ,FileAccess.Write);
        }
        else
        {
            //no crate a file
            stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            
        }
        StreamWriter writer = new StreamWriter(stream);
        writer.WriteLine("Logged at "+DateTime.Now.ToString()+" -"+message);
        writer.Close();
        stream.Close();
        
    }
}