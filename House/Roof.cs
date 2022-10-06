using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Roof : IPart
    {
        public Roof()
        {
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Roof).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Roof_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(Roof));
        }
    }
}
