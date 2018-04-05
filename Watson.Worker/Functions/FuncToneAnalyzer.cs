using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using Microsoft.Extensions.Options;
using Watson.Interfaces.Functions;
using Watson.Interfaces.Services;
using Watson.Models;
using Watson.Worker.Services;

namespace Watson.Worker.Functions
{
    public class FuncToneAnalyzer : IFuncToneAnalyzer
    {
        private readonly IToneAnalyzer toneAnalyzer;
        public FuncToneAnalyzer(IOptions<ToneAnalyzerConfig> options)
        {
            this.toneAnalyzer = new ToneAnalyzer(options);
        }

        public ToneAnalysis GetToneAnalysis(string text, string language = null, bool sentences = false)
        {
            ToneInput input = new ToneInput() {
                Text = text
            };

            return this.toneAnalyzer.Tone(input, "application/json", contentLanguage: language, sentences: sentences);
        }

        public UtteranceAnalyses GetToneChatAnalysis(string text, string language = null)
        {
            ToneChatInput input = new ToneChatInput()
            {
                Utterances = new List<Utterance>() { new Utterance() { Text = text } }
            };

            return this.toneAnalyzer.ToneChat(input, contentLanguage: language);
        }
    }
}
