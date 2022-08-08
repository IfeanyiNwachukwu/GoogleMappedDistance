using GoogleMap.Library;

namespace Mapped.Api.Extensions
{
    public static class ServicesExtension
    {
        public static void RegisterGoogleDistanceApi(this IServiceCollection services)
        {
            services.AddTransient<GoogleDistanceApi>();
        }
    }
}
