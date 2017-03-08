using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaRangerTaChambre
{
    class DictionaryExperiment:IExperiment
    {
        public string ContainerName
        {
            get { return "Dictionary"; }
        }

        public void Run(IList<Record> records, int peakInc)
        {
            var dico = new Dictionary<string, string>();

            foreach (var record in records)
                dico.Add(record.Key, record.Data);

            string bar;
            for (int j = 0; j < records.Count; j += peakInc)
                bar = dico[records[j].Key];

        }
    }
}
