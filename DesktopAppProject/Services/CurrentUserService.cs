
using DesktopAppProject;
using Microsoft.EntityFrameworkCore;
using TurboMart.Entitites;

namespace TurboMart.Services
{
    public class CurrentUserService
    {

        public int AddCurrentUser(CurrentUser currentUser) 
        {
            AppDbContext db = new AppDbContext();

            db.CurrentUser.Add(currentUser);
            int rowChanges = db.SaveChanges();

            return rowChanges;
        }

        public bool AnyCurrentUser() 
        {
            AppDbContext appDbContext = new AppDbContext();

            return appDbContext.CurrentUser.Any();
        }

        public void DeleteAllCurrentUsers() 
        {
            AppDbContext appDbContext = new AppDbContext();

            appDbContext.CurrentUser.ExecuteDelete();
        }
    }
}
