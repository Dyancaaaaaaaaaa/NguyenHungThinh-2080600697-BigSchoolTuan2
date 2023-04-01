using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHungThinh_2080600697.Startup))]
namespace NguyenHungThinh_2080600697
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
