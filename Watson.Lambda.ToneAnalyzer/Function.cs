
using Amazon.Lambda.Core;
using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using System;
using Watson.Interfaces.Functions;
using Watson.Models;
using Watson.Models.Requests;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
[assembly: Watson.DI.Attributes.ToneAnalyzerDI()]

namespace Watson.Lambda.ToneAnalyzer
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public ToneAnalysis FunctionHandler(LambdaRequest<ToneAnalyzerRequest>  request, ILambdaContext context)
        {

            IFuncToneAnalyzer toneAnalyzerService = (IFuncToneAnalyzer)DI.ToneAnalyzer.DIServiceProvider.GetService(typeof(IFuncToneAnalyzer));
            if (!String.IsNullOrEmpty(request.body.text))
            {
                return toneAnalyzerService.GetToneAnalysis(request.body.text, request.body.language);
            }
            else {
                throw new Exception("Bad Formatted Request");
            }

            
            
        }
    }
}
