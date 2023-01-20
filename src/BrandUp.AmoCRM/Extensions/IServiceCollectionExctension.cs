using Microsoft.Extensions.DependencyInjection;

namespace BrandUp.AmoCRM.Extensions
{
    public static class IServiceCollectionExctension
    {
        public static IServiceCollection AddAmoCRMIntegration(this IServiceCollection services)
        {
            services.AddHttpClient<AmoCRMClient>(client =>
            {
                client.BaseAddress = new("https://itamoelkastore.company.amocrm.ru");
            });

            return services;
        }
    }
}
