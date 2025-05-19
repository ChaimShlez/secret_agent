using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    internal class Agent
    {
        private string CodeName;
        private int Clearancelevel;

        public Agent(string codeName, int clearancelevel)
        {
            CodeName = codeName;
            Clearancelevel = clearancelevel;
        }
        public string GetCodeName()
        {
            return CodeName;
        }
        public void SetCodeName(string codeName)
        {
            CodeName = codeName;
        }
        public int GetClearanceLevel()
        {
            return Clearancelevel;
        }
        public void SetClearanceLevel(int clearancelevel)
        {
            if (clearancelevel  > 5 || clearancelevel < 1)
            {
                throw new ArgumentException("invalid clearancelevel");
            }
            else {
                Clearancelevel = clearancelevel;
            }
               
        }
        public void Report() {
            Console.WriteLine($"Agent {CodeName} reporting. Clearance Level:{Clearancelevel}");
        }
        
    }
}
