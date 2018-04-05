using System;

namespace Watson.DI.Attributes
{
    public class ToneAnalyzerDI : Attribute
    {
        public ToneAnalyzerDI()
        {
            new ToneAnalyzer();
        }
    }
}
