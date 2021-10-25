using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace ScreenCapture
{

    public static class CaptureScreen
    {
        static int screenLeft = SystemInformation.VirtualScreen.Left;
        static int screenTop = SystemInformation.VirtualScreen.Top;
        static int screenWidth = SystemInformation.VirtualScreen.Width;
        static int screenHeight = SystemInformation.VirtualScreen.Height;

        public static void Capture(string fileName)
        {

            fileName = fileName.Replace(".aspx", "").Replace("~/", "");
            // Create a bitmap of the appropriate size to receive the full-screen screenshot.
            using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            {
                // Draw the screenshot into our bitmap.
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                }

                //Save the screenshot as a Jpg image
                var uniqueFileName = "D:\\"+ fileName + ".jpg";
                try
                {
                    bitmap.Save(uniqueFileName, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
        }
    }
}