using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advProj_BusinessObjects.GlobalClass
{
    public static class LogsAudits
    {
        public static AdvProg_DatabaseContext LogsdbContext = new AdvProg_DatabaseContext();

        // method to add logs to the database
        public static void addLog(string logSrc, string msg, int uid)
        { 
            AdvProjLog newLog = new AdvProjLog();
            newLog.LogSource = logSrc;
            newLog.ExceptionMsg = msg;
            newLog.UserId = uid;
            newLog.Date = DateTime.Now;

            LogsdbContext.Add(newLog);
            LogsdbContext.SaveChanges();
        }

        // method to add audits to the database
        public static void addAudit(string AudSrc, string auditType, string entityName, string? oldVal, string? newVal, int rcrdID, int uid)
        {
            AdvProjAudit newAudit = new AdvProjAudit();
            newAudit.AuditSource = AudSrc;
            newAudit.ChnageType = auditType;
            newAudit.EntityName = entityName;
            newAudit.NewValue = newVal;
            newAudit.OldValue = oldVal;
            newAudit.RecordId = rcrdID;
            newAudit.UserId = uid;

            LogsdbContext.Add(newAudit);
            LogsdbContext.SaveChanges();
        }
    }
}
