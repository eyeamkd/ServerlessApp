using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SampleServerlessApp;

public class NameFeature
{
    /// <summary>
    /// Default constructor that Lambda will invoke.
    /// </summary>
    public NameFeature()
    {
    }


    /// <summary>
    /// A Lambda function to respond to HTTP Get methods from API Gateway
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The API Gateway response.</returns>
/*    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "Hello AWS Serverless",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }*/


    public APIGatewayProxyResponse GetAllNames(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "This is an endpoint to get all names",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }


    public APIGatewayProxyResponse GetNameById(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "This is an endpoint to get name",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }


    public APIGatewayProxyResponse DeleteNameById(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "This is an endpoint to delete name",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }


    public APIGatewayProxyResponse EditNameById(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "This is an endpoint to edit name",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }

    public APIGatewayProxyResponse AddName(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogInformation("Get Request\n");

        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "This is an endpoint to add name",
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }
}