using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LeafBlowerFiddleModel {
    public static class InputWrapper {

        [DllImport("user32.dll")]
        static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        internal static void Input(uint action, int wParam = 0, int lParam = 0) {
            SendMessage(Window.GameHandlePtr, action, wParam, lParam);
        }

        internal static int MakeLParam(int hi, int lo) {
            return ((hi << 16) | (lo & 0xFFFF));
        }
    }
}
