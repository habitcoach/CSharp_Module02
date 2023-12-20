using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windoesEventLog
{
    public class Logger
    {
        
        public static void Log(Exception exception) {

            StringBuilder sbExceptionMessage = new StringBuilder();

            sbExceptionMessage.Append("Execption Type" + Environment.NewLine);

            sbExceptionMessage.Append(exception.GetType().Name);

            sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);

            sbExceptionMessage.Append("Message" + Environment.NewLine);

            sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);

            sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);
        
            Exception innerException = exception.InnerException;

            while (innerException != null)
            {
                
                sbExceptionMessage.Append("Execption Type" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.StackTrace + Environment.NewLine + Environment.NewLine);
               

            }
            if (EventLog.SourceExists("TestSource345")) { 
            
                EventLog log = new EventLog("TestLog");

                log.Source = "TestSource345";

                log.WriteEntry(sbExceptionMessage.ToString(), EventLogEntryType.Error);

            }


        }
    }
}
