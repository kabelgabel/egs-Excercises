using WinFormsUtil;

namespace PrimeDistances
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ErrorDumper _err = new ErrorDumper();
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new PrimeDistancesForm());
            }
            catch (Exception ex)
            {
                _err.Dump(ex);
            }
        }
    }
}
