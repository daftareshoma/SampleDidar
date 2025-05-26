

using Sample.Didar.Configuration;

namespace Sample.Didar.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var setting = _configuration.GetSection(nameof(DidarSetting)).Get<DidarSetting>();
            services.AddSingleton(setting);
            services.AddSwaggerGen();
            services.AddHttpClient();
           
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            //app.UseSwaggerUI();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseRouting();
            app.UseWebSockets();
            app.UseCors("CorsPolicy");
            app.UseEndpoints(GetEndpoints());
        }
        private static Action<IEndpointRouteBuilder> GetEndpoints()
        {
            return endpoints =>
            {
                endpoints.MapControllers();
            };
        }

    }
}
