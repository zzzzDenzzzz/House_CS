using MyLib;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class TeamLeader : IWorker
    {
        public TeamLeader()
        {
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(TeamLeader).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"TeamLeader_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void Info()
        {
            Console.WriteLine(typeof(TeamLeader));
        }

        public void InfoHouse(House house)
        {
            house.ShowHouse();
        }
    }
}
