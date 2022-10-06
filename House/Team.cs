using MyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace House
{
    internal class Team
    {
        List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
            Loger loger = new Loger(DateTime.Now, TypeMessage.InfoMessage, typeof(Team).ToString());
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = File.Create($"Team_{Loger.PATH_LOG_FILE}"))
            {
                soapFormatter.Serialize(fStream, loger);
            }
        }

        public void ShowTeam()
        {
            foreach (var worker in workers)
            {
                worker.Info();
            }
        }

        public void AddTeamLeader()
        {
            workers.Add(new TeamLeader());
        }

        public TeamLeader GetTeamLeader()
        {
            foreach (var item in workers)
            {
                if (item is TeamLeader)
                {
                    return item as TeamLeader;
                }
            }
            return null;
        }

        public Worker GetWorker()
        {
            foreach (var item in workers)
            {
                if (item is Worker)
                {
                    return item as Worker;
                }
            }
            return null;
        }

        public void AddWorker(int workers)
        {
            for (int i = 0; i < workers; i++)
            {
                this.workers.Add(new Worker());
            }
        }
    }
}
