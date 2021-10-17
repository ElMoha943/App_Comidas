using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AppBar
{
    class Theme
    {
        //Extern Methods
        [DllImport("uxtheme.dll", EntryPoint = "#95", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern uint GetImmersiveColorFromColorSetEx(uint immersiveColorSet, uint immersiveColorType,
                bool ignoreHighContrast, uint highContrastCacheMode);

        [DllImport("uxtheme.dll", EntryPoint = "#96", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern uint GetImmersiveColorTypeFromName(IntPtr name);

        [DllImport("uxtheme.dll", EntryPoint = "#98", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern uint GetImmersiveUserColorSetPreference(bool forceCheckRegistry, bool skipCheckOnFail);

        //Public Methods
        public static Color GetAccentColor()
        {
            var userColorSet = GetImmersiveUserColorSetPreference(false, false);
            var colorType = GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
            var colorSetEx = GetImmersiveColorFromColorSetEx((uint)userColorSet, colorType, false, 0);

            return DwordToRGB(colorSetEx);
        }

        //Private Methods
        private static Color DwordToRGB(uint colorSetEx)
        {
            byte redColor = (byte)((0x000000FF & colorSetEx) >> 0);
            byte greenColor = (byte)((0x0000FF00 & colorSetEx) >> 8);
            byte blueColor = (byte)((0x00FF0000 & colorSetEx) >> 16);
            //byte alphaColor = (byte)((0xFF000000 & colorSetEx) >> 24); <-- Transparency, not needed for this project.
            return Color.FromArgb(redColor, greenColor, blueColor);
        }
    }
}
