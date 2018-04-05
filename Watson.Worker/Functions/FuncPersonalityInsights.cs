using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;
using Microsoft.Extensions.Options;
using Watson.Interfaces.Functions;
using Watson.Interfaces.Services;
using Watson.Models;
using Watson.Worker.Services;

namespace Watson.Worker.Functions
{

    public class FuncPersonalityInsights : IFuncPersonalityInsights
    {
        private readonly IPersonalityInsights personalityInsigth;

        public FuncPersonalityInsights(IOptions<PersonalityInsightsConfig> options)
        {
            this.personalityInsigth = new PersonalityInsights(options);
        }

        public Profile GetPersonalityInsight(string text, string language = null)
        {
            Content content = new Content()
            {
                ContentItems = new List<ContentItem>()
                {
                    new ContentItem()
                    {
                        Contenttype = ContentItem.ContenttypeEnum.TEXT_PLAIN,
                        Language = ContentItem.LanguageEnum.EN,
                        Content = text
                    }
                }
            };

           return this.personalityInsigth.Profile(content: content, contentType: "application/json", contentLanguage: language,
               acceptLanguage: null, rawScores: true, consumptionPreferences: true, csvHeaders: true);

        
        }
    }
    
}
