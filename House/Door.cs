using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Door : IPart
    {
        public Door()
        {
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Door).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Door_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(Door));
        }
    }
}
