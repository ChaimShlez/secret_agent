using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
     class MissionControl
    {
        public static void AnaliyzeReport(Report r)
        {
            if (r.GetUrgencyLevel() >= 4)
            {
                Console.WriteLine("Immediate response required");
            }
            else if (r.GetUrgencyLevel() == 3)
            {
                Console.WriteLine("High priority. Monitor closely.");
            }
            else {
                Console.WriteLine("Routine analysis.");
            }
           
        }
    }
}
