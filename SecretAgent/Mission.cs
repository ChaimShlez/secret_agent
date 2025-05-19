using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    internal class Mission
    {
        private string MissionName;
        private string TaergetLocation;
        private Agent Agent;

        public Mission(string missionName, string taergetLocation, Agent agent)
        {
            MissionName = missionName;
            TaergetLocation = taergetLocation;
            Agent = agent;
        }

        public void Brief() {
            Console.WriteLine($"Mission:{MissionName} , target: {TaergetLocation} , agent :{Agent.GetCodeName()}");
        }
    }
}
