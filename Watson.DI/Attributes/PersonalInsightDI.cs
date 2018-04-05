using System;

namespace Watson.DI.Attributes
{
    public class PersonalInsightDI : Attribute
    {
        public PersonalInsightDI()
        {
            new PersonalInsights();
        }
    }
}
