using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace FontStyleViewer
{
    internal class c_Performance
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr Handle, int num1, int num2, int num3);

        public const int HOR_POSITIVE = 0x1;
        public const int HOR_NEGATIVE = 0x2;
        public const int VER_POSITIVE = 0x4;
        public const int VER_NEGATIVE = 0x8;
        public const int CENTER = 0x10;
        public const int BLEND = 0x80000;
        [DllImport("user32.DLL", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr handle, int time, int type_animation);
    }
}
