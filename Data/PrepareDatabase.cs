using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BankService.API.Data
{
    public static class PrepareDatabase
    {
        public static void PopulateDatabase(IApplicationBuilder app){
            using(var serviceScope = app.ApplicationServices.CreateScope()){
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                context.Database.Migrate();
            }
        }
        
    }
}