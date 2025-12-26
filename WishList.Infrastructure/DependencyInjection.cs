using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WishList.Infrastructure.Persistence;

namespace WishList.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<WishListDb>(options =>
                options.UseNpgsql(connectionString));
            return services;
        }
    }
}
