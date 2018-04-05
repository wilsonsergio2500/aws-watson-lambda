# aws-watson-lambda
.NET IBM Watson + Lambda Integration

## About
###### Ready to go .net core 2 lambda application for IBM Watson. Currently supporting two main services - Personal Insights, and Tone Analyzer.

## Getting Started
###### Install .NET AWS Toolkit
###### Request API access @ https://console.bluemix.net and generate proper credentials for Personal Insights and Tone Analyzer APIs
###### When deploying the lambda ensure to enter the obtained API credentials, as such:

![install-lambda](https://user-images.githubusercontent.com/2171533/38385962-e4d90c9e-38d8-11e8-974f-bd1d7805fbe7.PNG)

###### Create AWS API Gateway to target your created Lamba Functions.
###### In the method of the API Gateway -> Go To Integration Request -> Body Mapping Templates
###### Add content type "application/json"