using System.Runtime.InteropServices;

namespace Aimp4.Api
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE 
    {
        public int cx;
        public int cy;

        public SIZE(int cx, int cy) 
        {
            this.cx = cx;
            this.cy = cy;
        }
    }
}