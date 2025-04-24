using DesktopAppProject;
using TurboMart.Entitites;
using TurboMart.WindowsForms.Products;

namespace TurboMart
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Dashboard());

            //AppDbContext appDbContext = new AppDbContext();

            //bool Exists = appDbContext.CurrentUser.Any();

            //if (Exists)
            //{
            //    new Dashboard().Show();
            //}
            //else
            //{
            //    Application.Run(new Login());
            //}
        }
    }
}