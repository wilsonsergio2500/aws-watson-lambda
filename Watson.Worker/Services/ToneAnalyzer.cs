using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3;
using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using Watson.Interfaces.Services;
using Watson.Models;

namespace Watson.Worker.Services
{
    public class ToneAnalyzer : IToneAnalyzer
    {
        private readonly IToneAnalyzerService analyzerService;
        public ToneAnalyzer(IOptions<ToneAnalyzerConfig> options)
        {
            ToneAnalyzerConfig config = options.Value;
            this.analyzerService = new ToneAnalyzerService(config.username, config.password, config.version);

        }

        public ToneAnalysis Tone(ToneInput toneInput, string contentType, bool? sentences = null, List<string> tones = null, string contentLanguage = null, string acceptLanguage = null)
        {
            return this.analyzerService.Tone(toneInput, contentType, sentences, tones, contentLanguage, acceptLanguage);
        }

        public UtteranceAnalyses ToneChat(ToneChatInput utterances, string contentLanguage = null, string acceptLanguage = null)
        {
            return this.analyzerService.ToneChat(utterances, contentLanguage, acceptLanguage);
        }
    }
}
