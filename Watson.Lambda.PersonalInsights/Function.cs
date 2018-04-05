
using Amazon.Lambda.Core;
using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;
using System;
using Watson.Interfaces.Functions;
using Watson.Lambda.PersonalInsights.Utils;
using Watson.Models;
using Watson.Models.Requests;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
[assembly: Watson.DI.Attributes.PersonalInsightDI()]

namespace Watson.Lambda.PersonalInsights
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Profile FunctionHandler(LambdaRequest<PersonalInsightRequest> request, ILambdaContext context)
        {
            IFuncPersonalityInsights personalityInsights = (IFuncPersonalityInsights)DI.PersonalInsights.DIServiceProvider.GetService(typeof(IFuncPersonalityInsights));
            if (!String.IsNullOrEmpty(request.body.text))
            {
                int count = Helpers.getWordCount(request.body.text);
                if (count >= 100)
                {
                    return personalityInsights.GetPersonalityInsight(request.body.text, request.body.language);
                }
                else {
                    throw new Exception("Insufficient word count, must be: 100");
                }
            }
            else
            {
                throw new Exception("Bad Formatted Request");
            }
        }
    }
}
