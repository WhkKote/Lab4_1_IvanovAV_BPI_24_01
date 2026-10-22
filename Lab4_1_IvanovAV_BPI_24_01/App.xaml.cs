
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace Lab4_1_IvanovAV_BPI_24_01
{
    public partial class App : Application
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int dwAttribute,
            ref int pvAttribute,
            int cbAttribute);

        protected override void OnStartup(StartupEventArgs e)
        {
            EventManager.RegisterClassHandler(
                typeof(Window),
                FrameworkElement.LoadedEvent,
                new RoutedEventHandler(OnWindowLoaded));

            base.OnStartup(e);
        }

        private static void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is not Window window)
                return;

            IntPtr hwnd = new WindowInteropHelper(window).Handle;

            if (hwnd == IntPtr.Zero)
                return;

            int darkMode = 1;
            int captionColor = 0x00221A15;
            int textColor = 0x00FAF5F1;

            DwmSetWindowAttribute(
                hwnd, 20, ref darkMode, sizeof(int));

            DwmSetWindowAttribute(
                hwnd, 35, ref captionColor, sizeof(int));

            DwmSetWindowAttribute(
                hwnd, 36, ref textColor, sizeof(int));
        }
    }
}
