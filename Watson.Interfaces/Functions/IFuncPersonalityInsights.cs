using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Watson.Interfaces.Functions
{
    public interface IFuncPersonalityInsights
    {
        Profile GetPersonalityInsight(string text, string language = null); 
    }
}
