namespace Task_19
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc((o) =>
            {
                o.EnableEndpointRouting = false;

            });

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseMvc((o) =>
            {
                o.MapRoute("home", "{controller=Home}/{action=Index}");
            });

        }
    }
}
