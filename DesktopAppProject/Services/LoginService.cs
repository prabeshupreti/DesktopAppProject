

using DesktopAppProject;

namespace TurboMart.Services
{
    public class LoginService
    {
        public bool IsLoggedIn(string Info, string Password) 
        {

            AppDbContext appDbContext = new AppDbContext();

            return appDbContext.ApplicationUser
                .Where(x => (x.Email == Info.Trim() ||
                x.UserName == Info.Trim()) && x.Password == Password.Trim())
                .Any();
        }
    }
}
