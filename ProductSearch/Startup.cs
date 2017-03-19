using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductSearch.Startup))]
namespace ProductSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
