namespace Tours.Endpoints;

public static class UserEndpoints
{
    public static void ConfigureUserEndpoints(this WebApplication app)
    {
        app.MapGet("user/{name}", async)(
            string name,
            [FromServices] GetUser
        )
    }
}