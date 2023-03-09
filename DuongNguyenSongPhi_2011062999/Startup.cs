using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongNguyenSongPhi_2011062999.Startup))]
namespace DuongNguyenSongPhi_2011062999
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
