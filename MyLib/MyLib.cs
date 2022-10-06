using System;

namespace MyLib
{
    public enum TypeMessage
    {
        Error,
        Exception,
        TextMessage,
        InfoMessage,
        Warning
    }

    [Serializable]
    public class Loger
    {
        public const string PATH_LOG_FILE = "log.soap";
        DateTime dateTime;
        TypeMessage type;
        string message;

        public Loger(DateTime dateTime, TypeMessage type, string message)
        {
            this.dateTime = dateTime;
            this.type = type;
            this.message = message;
        }
    }
}
