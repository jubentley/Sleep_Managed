// Sleep ~ Justin Bentley ~ 2025

// Trigger Monitor Down Power State

using System;
using System.Runtime.InteropServices;


namespace Sleep
{
    internal class Program
    {
        const int HWND_BROADCAST = 0xFFFF;
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xF170;

        // monitor states: -1 = On, 1 = Low Power, 2 = Off
        const int MONITOR_OFF = 2;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        static void Main()
        {
            System.Threading.Thread.Sleep(1000);

            SendMessage((IntPtr)HWND_BROADCAST, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)MONITOR_OFF);
        }
    }
}
