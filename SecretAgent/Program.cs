using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Agent agent = new Agent("007", 5);
            //agent.Report();
            //Mission mission = new Mission("Rescue", "Paris", agent);
            //mission.Brief();
            //string message = "The eagle has landed";
            //IntelTools.LogTransmission(agent.GetCodeName(), message);
            //Console.WriteLine("Mission briefing complete.");
            Report report = new Report("Top Secret", 4,agent);
          
            MissionControl.AnaliyzeReport(report);
            IntelTools.LogTransmission(agent.GetCodeName(),"nuffjg");
        }
    }
}
