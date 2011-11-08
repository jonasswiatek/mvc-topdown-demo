using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DR.TopdownDemo.IHeartQuotesData.Model
{
    public class IHeartQuotesQuote
    {
        public string json_class { get; set; }
        public string[] tags { get; set; }
        public string quote { get; set; }
        public string link { get; set; }
        public string source { get; set; }
    }
}
