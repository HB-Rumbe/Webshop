using System.Runtime.InteropServices;

namespace Webshop
{
    internal static class program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Admin admin = new Admin();
            ApplicationConfiguration.Initialize();
            KundeList.LoadKundeList();
            VareList.LoadVareList();
            Application.Run(new Login());
            VareList.SaveVareList(Global.VareList);
            KundeList.SaveKundeList(Global.KundeList);
        }
    }
}