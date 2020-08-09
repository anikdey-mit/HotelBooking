using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelBooking_Assignment.Startup))]
namespace HotelBooking_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
