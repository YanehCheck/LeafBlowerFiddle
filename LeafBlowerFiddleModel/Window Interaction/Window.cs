using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LeafBlowerFiddleModel {
    public static class Window {
        
        private const string ProcessName = "Leaf Blower Revolution";
        internal static IntPtr GameHandlePtr { get; private set; } = IntPtr.Zero;
        internal static IntPtr GameContextPtr { get; private set; } = IntPtr.Zero;
        public static bool IsGameHandlerPtrSet => GameHandlePtr != IntPtr.Zero;

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hwnd, out RECT rectangle);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hwnd, out RECT rectangle);

        [DllImport("user32.dll")]
        private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        [DllImport("gdi32.dll")]
        static extern uint SetPixel(IntPtr hdc, int X, int Y, uint crColor);

        public static void SetGameHandlePtr() {
            foreach(Process pList in Process.GetProcesses()) {
                if(pList.MainWindowTitle.Contains(ProcessName)) {
                    GameHandlePtr = pList.MainWindowHandle;
                    GameContextPtr = GetWindowDC(GameHandlePtr);
                    return;
                }
            }
        }

        internal static RECT GetSize() {
            RECT rect;
            GetWindowRect(GameHandlePtr, out rect);
            return rect;
        }

        internal static Point GetBorderSize() {
            RECT client, window;
            Point point = new Point();
            GetClientRect(GameHandlePtr, out client);
            GetWindowRect(GameHandlePtr, out window);
            point.X = window.Right - window.Left - client.Right;
            point.Y = window.Bottom - window.Top - client.Bottom;
            return point;

        }

        public static Bitmap PrintWindow() {
            RECT rc;
            GetWindowRect(GameHandlePtr, out rc);

            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(GameHandlePtr, hdcBitmap, 0x1);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }

        public static Color GetPixel(int x, int y) {
            uint pixel = GetPixel(GameContextPtr, x, y);
            return Color.FromArgb((int) (pixel & 0x000000FF),
                (int) (pixel & 0x0000FF00) >> 8,
                (int) (pixel & 0x00FF0000) >> 16);
        }
    }
}
