using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaRangerTaChambre
{
    class Record
    {
        public readonly string Key;
        public readonly string Data;

        public Record()
        {
            Key = Guid.NewGuid().ToString();
            Data = "Foo";
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var other = obj as Record;

            if (other == null) return false;

            return Key == other.Key;

        }
    }
}
