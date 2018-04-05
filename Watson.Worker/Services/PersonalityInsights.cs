using IBM.WatsonDeveloperCloud.PersonalityInsights.v3;
using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;
using Microsoft.Extensions.Options;
using Watson.Interfaces.Services;
using Watson.Models;

namespace Watson.Worker.Services
{
    public class PersonalityInsights : IPersonalityInsights
    {
        private readonly IPersonalityInsightsService personalityInsightService;
        public PersonalityInsights(IOptions<PersonalityInsightsConfig> options)
        {
            PersonalityInsightsConfig config = options.Value;
            this.personalityInsightService = new PersonalityInsightsService(config.username, config.password, config.version);
        }

        public Profile Profile(Content content, string contentType, string contentLanguage = null, string acceptLanguage = null, bool? rawScores = null, bool? csvHeaders = null, bool? consumptionPreferences = null)
        {
            return this.personalityInsightService.Profile(content, contentType, contentLanguage, acceptLanguage, rawScores, csvHeaders, consumptionPreferences);
        }

        public Profile ProfileAsCsv(Content content, string contentType, string contentLanguage = null, string acceptLanguage = null, bool? rawScores = null, bool? csvHeaders = null, bool? consumptionPreferences = null)
        {
            return this.personalityInsightService.ProfileAsCsv(content, contentType, contentLanguage, acceptLanguage, rawScores, csvHeaders, consumptionPreferences);
        }

       
    }
}
