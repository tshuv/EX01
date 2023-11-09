namespace EX01
{
    public class Middleware
    {
        public readonly RequestDelegate _next;
            public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task invoke(HttpContext httpContext)
        {
            await request(httpContext);
            await  httpContext.Response.WriteAsync("that the return message");
        }

        private System.Threading.Tasks.Task request(HttpContext httpContext)
        {
            throw new NotImplementedException();
        }
    }
}