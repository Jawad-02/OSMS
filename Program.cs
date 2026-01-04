using OSMS.PublicClasses;
using OSMS.View;

namespace OSMS
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DatabaseInitializer init = new DatabaseInitializer();
                init.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database initialization failed:\n" + ex.Message);
            }
            Application.Run(new Form1());
        }
    }
}