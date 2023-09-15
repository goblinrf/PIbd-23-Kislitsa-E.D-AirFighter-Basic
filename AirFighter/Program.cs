using System.Drawing;

namespace ProjectAirFighter
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

 ApplicationConfiguration.Initialize();
            Application.Run(new FormAirFighter());
        }
    }


}