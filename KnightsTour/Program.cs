using WinFormsUtil;

namespace KnightsTour
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
                Application.Run(new KnightsTourForm());
            }
            catch (Exception ex)
            {
                _err.Dump(ex);
            }
        }
    }
}
