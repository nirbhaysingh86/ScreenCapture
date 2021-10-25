using Segment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ScreenCapture
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = ((System.Web.UI.Control)sender).Page.AppRelativeVirtualPath;

            Task.Delay(new TimeSpan(0, 0, 1)).ContinueWith(o => { CaptureScreen.Capture(fileName); });
        }
    }
}