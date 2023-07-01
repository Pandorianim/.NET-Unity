using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(l10z1.Areas.Identity.IdentityHostingStartup))]
namespace l10z1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}