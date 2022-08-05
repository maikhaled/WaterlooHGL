using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_MaiAhmed
{
    internal class CSVStringValue :  IStringValue
    {
        public string Value { get; set; } = "";
        public CSVStringValue() { }
        public CSVStringValue(string value)
        {
            Value = value;
        }
       
       
        public override string ToString()
        {
            return Value;
        }
    }
}
