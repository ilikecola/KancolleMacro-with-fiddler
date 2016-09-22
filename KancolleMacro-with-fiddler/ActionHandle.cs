using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace KancolleMacro_with_fiddler
{
    class ActionHandle
    {
        [DllImport("user32.dll", EntryPoint = "PostMessage")]//发送鼠标消息
        private static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// 辅助类 定义User32 API函数
        /// </summary>
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }
            [DllImport("user32.dll")]
            public static extern IntPtr GetDesktopWindow();
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
        }



        //鼠标操作部分
        //常数
        const int WM_MOUSEMOVE = 0x200;
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x202;
        const int MK_LBUTTON = 0x0001;

        //DPI scale
        int scale = convarible.DPIscale;

        public void MOUSEMOVE(IntPtr hWnd, int xPos, int yPos)
        {
            //y为高16位
            //x为低16位
            Thread.Sleep(5 + RndTime());
            xPos = xPos * scale;
            yPos = (yPos + convarible.poiYcorrect) * scale;
            PostMessage(hWnd, WM_MOUSEMOVE, 0, (yPos << 16) | xPos);
            Thread.Sleep(5 + RndTime());
        }

        public void LeftClick(IntPtr hWnd, int xPos, int yPos)
        {
            //y为高16位
            //x为低16位
            xPos = xPos * scale;
            yPos = (yPos + convarible.poiYcorrect) * scale;
            PostMessage(hWnd, WM_LBUTTONDOWN, 0, (yPos << 16) | xPos);
            Thread.Sleep(300 + this.RndTime());
            PostMessage(hWnd, WM_LBUTTONUP, 0, (yPos << 16) | xPos);
        }

        public int[] Getwidth_height(IntPtr hWnd)
        {
            int[] size = new int[2];
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(hWnd, ref windowRect);
            size[0] = windowRect.right - windowRect.left;
            size[1] = windowRect.bottom - windowRect.top;
            return size;
        }

        private int RndTime()
        {
            int rnd;
            rnd = (int)(rndint() * 20 - 20 / 2);
            if (rnd < 0) rnd = (-1) * rnd;
            return rnd;
        }

        private double rndint()
        {
            double rnd;
            Thread.Sleep(100);
            Random ra = new Random();
            rnd = ra.NextDouble();
            return rnd;
        }
    }
}
