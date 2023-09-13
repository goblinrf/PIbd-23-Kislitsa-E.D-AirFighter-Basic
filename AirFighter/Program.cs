using System.Drawing;

namespace AirFighter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI

 // see https://aka.ms/applicationconfiguration.
 ApplicationConfiguration.Initialize();
            Application.Run(new FormAirFighter());
        }
    }

}