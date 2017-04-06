using System;
using System.Windows.Forms;
using System.Threading;

namespace PrepareForDeployment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // Application's GUID
        static Mutex mutex = new Mutex(true, "0A96C093-261E-43CA-AC7B-A2A4502D7116");
        [STAThread]
        static void Main()
        {
            if(mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            }
            else
            {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                NativeMethods.PostMessage(
                    (IntPtr)NativeMethods.HWND_BROADCAST,
                    NativeMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
            }
            
        }
    }
}
