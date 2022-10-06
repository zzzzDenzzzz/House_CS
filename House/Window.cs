using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Window : IPart
    {
        public static int CountWindow { get; set; } = 0;

        public Window()
        {
            CountWindow++;
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Window).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Window_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(Window));
        }
    }
}
