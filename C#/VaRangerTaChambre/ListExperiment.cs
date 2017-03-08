using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaRangerTaChambre
{
    class ListExperiment:IExperiment
    {
        public string ContainerName { get{ return "List"; } }

        public void Run(IList<Record> records, int peakinc)
        {
            var list = new List<Record>();

            foreach (var record in records)
                list.Add(record);

            string bar;
            for (int j = 0; j < records.Count; j += peakinc)
            {
                bar = list.Find(r => r.Key == records[j].Key).Data;
            }
        } 
    }
}
