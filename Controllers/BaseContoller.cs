using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateManager.Dao.SqlServer.Models;

namespace RealEstateManager.Controllers
{
    public abstract class BaseContoller : Controller
    {
        protected readonly IConfiguration configuration;
        public BaseContoller(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected DbContextOptions<TContext> CreateDbOptions<TContext>(QueryTrackingBehavior queryTrackingBehavior = QueryTrackingBehavior.NoTracking) where TContext : DbContext
        {
            var optionsBuilder = new DbContextOptionsBuilder<TContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseQueryTrackingBehavior(queryTrackingBehavior);
            return optionsBuilder.Options;
        }


        protected RealEstateManagerContext GetContext(QueryTrackingBehavior queryTrackingBehavior = QueryTrackingBehavior.NoTracking)
            => new RealEstateManagerContext(this.CreateDbOptions<RealEstateManagerContext>(queryTrackingBehavior));
    }
}
