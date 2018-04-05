using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Watson.Interfaces.Functions
{
    public interface IFuncToneAnalyzer
    {
        ToneAnalysis GetToneAnalysis(string text, string language = null, bool sentences = false);

        UtteranceAnalyses GetToneChatAnalysis(string text, string language = null);
    }
}
