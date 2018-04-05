using System;
using System.Collections.Generic;
using System.Text;

namespace Watson.Models.Requests
{
    public class ToneAnalyzerRequest
    {
        public string text { get; set; }
        public string language { get; set; }
    }
}
