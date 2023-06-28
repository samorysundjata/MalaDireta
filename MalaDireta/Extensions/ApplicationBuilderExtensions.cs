namespace MalaDireta.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            return app;
        }

        //public static IApplicationBuilder UseAppCors(this IApplicationBuilder app) 

        //public static IApplicationBuilder UseSwaggerMiddleware(this IApplicationBuilder app)
    }
}
