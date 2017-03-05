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
            var guids = new List<string>();

            for (int i = 0; i < 32; i++)
                guids.Add(Guid.NewGuid().ToString());

            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                var dico = new Dictionary<string, string>();

                foreach (var guid in guids)
                    dico.Add(guid, "FOO");

                string bar;
                for (int j = 0; j < guids.Count; j += 4)
                    bar = dico[guids[j]];
            }
            sw.Stop();
            Console.WriteLine("Dico: {0}ms", sw.ElapsedMilliseconds/1000000.0);
            sw.Start();

            sw.Reset();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                var list = new List<Tuple<string,string>>();

                foreach (var guid in guids)
                    list.Add(new Tuple<string,string>(guid, "FOO"));

                string bar;
                for (int j = 0; j < guids.Count; j += 1)
                {
                    bar = list.Find(t => t.Item1 == guids[j]).Item2;
                }
                    
            }
            sw.Stop();
            Console.WriteLine("List: {0}ms", sw.ElapsedMilliseconds / 1000000.0);
            Console.ReadLine();



        }
    }
}
