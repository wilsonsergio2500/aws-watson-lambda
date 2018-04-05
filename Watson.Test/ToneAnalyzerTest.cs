using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Watson.DI.Attributes;
using System.Linq;
using Watson.Interfaces.Functions;

namespace Watson.Test
{
    [TestClass]
    public class ToneAnalyzerTest
    {
        public ToneAnalyzerTest()
        {
            new ToneAnalyzerDI();
        }

        [TestMethod]
        public void ToneAnalyzerActionTest()
        {
            string text = "A word is dead when it is said, some say. Emily Dickinson";
            IFuncToneAnalyzer toneAnalyzerService = (IFuncToneAnalyzer)DI.ToneAnalyzer.DIServiceProvider.GetService(typeof(IFuncToneAnalyzer));

            ToneAnalysis analysis = toneAnalyzerService.GetToneAnalysis(text);
            int tones =analysis.DocumentTone.Tones.Count();
            Assert.IsTrue(tones != 0);
        }
    }
}
