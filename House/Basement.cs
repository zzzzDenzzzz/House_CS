using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Basement : IPart
    {
        public Basement()
        {
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Basement).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Basement_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(Basement));
        }
    }
}
