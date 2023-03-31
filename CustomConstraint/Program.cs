namespace CustomConstraint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.Configure<RouteOptions>(option =>
            //    option.ConstraintMap.Add("Custom", typeof(Constraint.CustomConstraint)));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            // BuRA
            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapControllerRoute("Defoult3", "{controller = Home}/{action = Index}/{id:Custom}/{x:length(2)?}/{y:int?}");
                endpoints.MapControllers(); // Gelen isteyi controllerdekilere eslestir 
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapDefaultControllerRoute();
            });
            app.Run();
        }
    }
}