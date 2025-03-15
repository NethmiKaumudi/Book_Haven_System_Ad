using Book_Haven__Application.Business.Services;
using Book_Haven_System_Ad.Forms;

namespace Book_Haven_System_Ad
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            UserService userService = new UserService();

            userService.CreateInitialAdminUser();
            Application.Run(new frmLogin());
        }
    }
}