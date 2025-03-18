namespace MiddlewareScopedDependency;

public class TestMiddleware(RequestDelegate next, TestDependency dependency)
{
    public async Task InvokeAsync(HttpContext context)
    {

    }
}