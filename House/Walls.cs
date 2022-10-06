using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Walls : IPart
    {
        public static int CountWalls { get; set; } = 0;

        public Walls()
        {
            CountWalls++;
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Walls).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Walls_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(Walls));
        }
    }
}
