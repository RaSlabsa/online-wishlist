using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WishList.Application.Common.Interfaces;
using WishList.Application.Common.Interfaces.Repositories;
using WishList.Domain.Entities;
using WishList.Infrastructure.Persistence;
using WishList.Infrastructure.Persistence.Authentication;
using WishList.Infrastructure.Persistence.Repositories;

namespace WishList.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            services.AddDbContext<WishListDb>(options =>
                options.UseNpgsql(connectionString));

            services.AddIdentityCore<User>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<WishListDb>()
            .AddDefaultTokenProviders();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.Configure<JwtOptions>(configuration.GetSection("Jwt"));

            services.AddScoped<IJwtProvider, JwtProvider>();

            return services;
        }
    }
}
