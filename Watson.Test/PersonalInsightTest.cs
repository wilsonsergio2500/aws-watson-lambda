using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Watson.DI.Attributes;
using Watson.Interfaces.Functions;
using System.Linq;

namespace Watson.Test
{
    [TestClass]
    public class PersonalInsightTest
    {
        public PersonalInsightTest()
        {
            new PersonalInsightDI();
        }

        [TestMethod]
        public void PersonalInsightActionTest() {
            string text = "The IBM Watson™ Personality Insights service provides a Representational State Transfer (REST) Application Programming Interface (API) that enables applications to derive insights from social media, enterprise data, or other digital communications. The service uses linguistic analytics to infer individuals' intrinsic personality characteristics, including Big Five, Needs, and Values, from digital communications such as email, text messages, tweets, and forum posts. The service can automatically infer, from potentially noisy social media, portraits of individuals that reflect their personality characteristics. The service can report consumption preferences based on the results of its analysis, and for JSON content that is timestamped, it can report temporal behavior.";
            IFuncPersonalityInsights service = (IFuncPersonalityInsights)DI.PersonalInsights.DIServiceProvider.GetService(typeof(IFuncPersonalityInsights));
            Profile profile = service.GetPersonalityInsight(text);
            Assert.IsTrue(profile.Personality.Count() != 0);
        }

    }
}
