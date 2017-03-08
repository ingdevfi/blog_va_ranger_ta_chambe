using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaRangerTaChambre
{
    interface IExperiment
    {
        string ContainerName { get; }
        void Run(IList<Record> records, int peakInc);
    }
}
