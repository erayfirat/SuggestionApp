using System.Runtime.CompilerServices;

namespace SuggestionAppUI;

public static class RegisterServices
{
    public static void ConfigurationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddMemoryCache();
    }
}
