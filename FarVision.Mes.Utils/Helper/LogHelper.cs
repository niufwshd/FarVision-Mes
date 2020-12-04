using log4net;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using YueMES.Base.Dal;

namespace WebMES.Utils
{
    public enum LogLevel
    {
        OFF,
        ERROR,
        INFO,
        DEBUG
    }
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogType
    {
        AppLog,
        ErrorLog,
        InfoLog,
        OtherLog
    }

    public static  class LogHelper
    {
        private static XmlElement _config = null;
        private static bool isInit = false;


        //public static void Initial(XmlElement config)
        //{
        //    _config = config;
        //    if (!isInit)
        //    {
        //        log4net.Config.XmlConfigurator.Configure(config);
        //        isInit = true;
        //    }

        //}

        public static void SetLevel(LogLevel lev)
        {

            switch (lev)
            {
                case LogLevel.OFF:
                    changeLogLevel("OFF");
                    break;
                case LogLevel.ERROR:
                    changeLogLevel("ERROR");
                    break;
                case LogLevel.INFO:
                    changeLogLevel("INFO");
                    break;
                case LogLevel.DEBUG:
                    changeLogLevel("DEBUG");
                    break;
            }

            // log4net.Config.XmlConfigurator.Configure(_config);
        }

        private static void SetSaveRootPath(string relativePath)
        {
            XmlNode thisNode = _config.SelectSingleNode("//log4net/appender/file/@value");

            if (thisNode != null)
            {
                if (!Path.IsPathRooted(thisNode.Value))
                    thisNode.Value = Path.Combine(relativePath, thisNode.Value);
                else
                    thisNode.Value = relativePath;
            }

        }

        private static void changeLogLevel(string lev)
        {

            XmlNode thisNode = _config.SelectSingleNode("/log4net/root/level/@value");

            if (thisNode != null)
            {
                thisNode.Value = lev;
            }
        }

        private static ILog GetLogger(LogType logType = LogType.InfoLog)
        {
            string s = logType.ToString();
            ILog log = LogManager.GetLogger("NETCoreRepository", s);
            return log;
            //return log4net.LogManager.GetLogger((new StackTrace()).GetFrame(2).GetMethod().ReflectedType);
        }

        public static void Info(string Message)
        {
            ILog _log = GetLogger();
        
            if (_log.IsInfoEnabled)
            {
                _log.Info($"业务库{DAO.DBNo},{Message}");
            }
        }

        public static void InfoFormat(string format, params object[] args)
        {
            ILog _log = GetLogger();
            if (_log.IsInfoEnabled)
            {
                _log.Info(string.Format(format, args));
            }
        }

        public static void Info(string Message, Exception ex)
        {
            ILog _log = GetLogger();
            if (_log.IsInfoEnabled)
            {
                _log.Info(Message, ex);
            }
        }

        public static void Warn(string Message)
        {
            ILog _log = GetLogger();
            if (_log.IsInfoEnabled)
            {
                _log.Warn(Message);
            }
        }
        public static void Warn(string Message, Exception ex)
        {
            ILog _log = GetLogger();
            if (_log.IsInfoEnabled)
            {
                _log.Warn(Message, ex);
            }
        }
        public static void WarnFormat(string format, params object[] args)
        {
            ILog _log = GetLogger();
            if (_log.IsInfoEnabled)
            {
                _log.WarnFormat(string.Format(format, args));
            }
        }

        public static void Debug(string Message)
        {
            ILog _log = GetLogger();
            if (_log.IsDebugEnabled)
            {
                _log.Debug(Message);
            }
        }

        public static void DebugFormat(string format, params object[] args)
        {
            ILog _log = GetLogger();
            if (_log.IsDebugEnabled)
            {
                _log.Debug(string.Format(format, args));
            }
        }

        public static void Debug(string Message, Exception ex)
        {
            ILog _log = GetLogger();
            if (_log.IsDebugEnabled)
            {
                _log.Debug(Message, ex);
            }
        }

        public static void Error(string Message)
        {
            ILog _log = GetLogger(LogType.ErrorLog);
            if (_log.IsErrorEnabled)
            {
                _log.Error($"业务库{DAO.DBNo},{Message}");
            }
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            ILog _log = GetLogger(LogType.ErrorLog);
            if (_log.IsErrorEnabled)
            {
                _log.Error(string.Format(format, args));
            }
        }

        public static void Error(string Message, Exception ex)
        {
            ILog _log = GetLogger(LogType.ErrorLog);
            if (_log.IsErrorEnabled)
            {
                _log.Error($"业务库{DAO.DBNo},{Message}", ex);
            }
        }

        public static void Error(Exception ex)
        {
            ILog _log = GetLogger(LogType.ErrorLog);
            if (_log.IsErrorEnabled)
            {   
                _log.Error($"业务库{DAO.DBNo}", ex);
            }
        }
    }
}
