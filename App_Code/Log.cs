using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;


/// <summary>
/// Summary description for Log
/// </summary>
public class Log
{
    private StreamWriter _writer;

    public void WriteErrorMessage(String logPath,string errorMessage, string pageUrl, Exception e)
    {
        _writer = new StreamWriter(logPath, true);
        StringBuilder fullError = new StringBuilder();

        fullError.AppendLine("Error log: " + DateTime.Now);
        fullError.AppendLine(errorMessage);
        fullError.AppendLine("Error raised on: " + pageUrl);
        fullError.AppendLine("Associated exception message: " + e.Message + "\n" + e.InnerException);
        fullError.AppendLine("Exception class: " + e.GetType().ToString());
        fullError.AppendLine("Exception source: " + e.Source.ToString());
        fullError.AppendLine("Exception method: " + e.TargetSite.Name.ToString());
        fullError.AppendLine();
        _writer.WriteLine(fullError);
        _writer.Flush();
        _writer.Close();
    }
}