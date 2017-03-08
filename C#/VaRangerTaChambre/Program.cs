using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VaRangerTaChambre
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = new List<Record>();
            const int RecordsNb = 1024;
            const int PeakNb = 16;

            // building data
            for (int i = 0; i < RecordsNb; i++)
                records.Add(new Record());

            var experiments = new List<IExperiment>() {new DictionaryExperiment(), new ListExperiment()};

            foreach (IExperiment exp in experiments)
            {
                var sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 100000; i++)
                {
                    exp.Run(records, (int)Math.Floor((double)records.Count / (double)PeakNb));
                }
                sw.Stop();
                Console.WriteLine("{0}: {1} ticks", exp.ContainerName, sw.ElapsedTicks / 100000.0);                
            }

            Console.ReadLine();
        }
    }
}
