using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace NSE.WebApp.MVC.Configuration
{
    public static class AuthConfig
    {
        public static void AddAuthenticationConfiguration(this IServiceCollection services)
        {
            // Vamos trabalhar com um tipo de autenticação: Cookie
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    // Senao estiver autenticado, será redirecionado
                    options.LoginPath = "/login";

                    // Acesso negado
                    options.AccessDeniedPath = "/acesso-negado";
                });
        }

        public static void UseAuthenticationConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
