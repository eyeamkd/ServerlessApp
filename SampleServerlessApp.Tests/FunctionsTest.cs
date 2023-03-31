using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;


namespace SampleServerlessApp.Tests;

public class FunctionTest
{
    public FunctionTest()
    {
    }

    [Fact]
    public void TestGetAllNamesMethod()
    {
        TestLambdaContext context;
        APIGatewayProxyRequest request;
        APIGatewayProxyResponse response;

        NameFeature functions = new NameFeature();


        request = new APIGatewayProxyRequest();
        context = new TestLambdaContext();
        response = functions.GetAllNames(request, context);
        Assert.Equal(200, response.StatusCode);
        Assert.Equal("This is an endpoint to get all names", response.Body);
    }

    [Fact]
    public void TestGetNameByIdMethod()
    {
        TestLambdaContext context;
        APIGatewayProxyRequest request;
        APIGatewayProxyResponse response;

        NameFeature functions = new NameFeature();


        request = new APIGatewayProxyRequest();
        context = new TestLambdaContext();
        response = functions.GetNameById(request, context);
        Assert.Equal(200, response.StatusCode);
        Assert.Equal("This is an endpoint to get name", response.Body);
    }

    [Fact]
    public void TestDeleteNameByIdMethod()
    {
        TestLambdaContext context;
        APIGatewayProxyRequest request;
        APIGatewayProxyResponse response;

        NameFeature functions = new NameFeature();


        request = new APIGatewayProxyRequest();
        context = new TestLambdaContext();
        response = functions.DeleteNameById(request, context);
        Assert.Equal(200, response.StatusCode);
        Assert.Equal("This is an endpoint to delete name", response.Body);
    }

    [Fact]
    public void TestEditNameByIdMethod()
    {
        TestLambdaContext context;
        APIGatewayProxyRequest request;
        APIGatewayProxyResponse response;

        NameFeature functions = new NameFeature();


        request = new APIGatewayProxyRequest();
        context = new TestLambdaContext();
        response = functions.EditNameById(request, context);
        Assert.Equal(200, response.StatusCode);
        Assert.Equal("This is an endpoint to edit name", response.Body);
    }
}