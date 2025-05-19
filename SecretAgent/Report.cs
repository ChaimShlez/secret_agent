using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    internal class Report
    {
        private string Summery;
        private int UrgencyLevel;

        private Agent SubmittedBy;


        public Report(string summery, int urgencyLevel, Agent submittedBy)
        {
            Summery = summery;
            UrgencyLevel = urgencyLevel;
            SubmittedBy = submittedBy;
        }

        public int GetUrgencyLevel()
        {
            return UrgencyLevel;
        }
    }
}
