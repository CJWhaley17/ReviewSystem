using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RatingReviewSystem.Startup))]
namespace RatingReviewSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
