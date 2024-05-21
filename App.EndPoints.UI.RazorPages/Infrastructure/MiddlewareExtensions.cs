namespace App.EndPoints.UI.RazorPages.Infrastructure
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder CustomExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
