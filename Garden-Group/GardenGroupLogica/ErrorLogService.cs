using GardenGroupDAL;
using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GardenGroupLogica
{
    public class ErrorLogService
    {
        private ErrorLogDao errorLogDao;

        public ErrorLogService()
        {
            errorLogDao = new ErrorLogDao();
        }

        public void CatchExeptionToLog(Exception exception)
        {
            ErrorLog errorLog = new ErrorLog();
            errorLog.Message = exception.Message;
            errorLog.StackTrace = exception.StackTrace;
            errorLogDao.AddErrorLog(errorLog);
        }

        public void AddErrorLog(ErrorLog errorLog)
        {
            errorLogDao.AddErrorLog(errorLog);
        }
    }
}
