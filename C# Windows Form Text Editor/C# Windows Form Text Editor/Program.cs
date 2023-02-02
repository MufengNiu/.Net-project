namespace Assignment_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Make form DIP aware for high DPI monitor to avoid blurr
            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow());
            //Application.Run(new TextEditor());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}