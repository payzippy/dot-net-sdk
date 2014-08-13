using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayzippyDotNetSDK
{
    public partial class ChargeIframe : System.Web.UI.Page
    {
        public object chargingUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            chargingUrl = this.Context.Items["charging_url"];


        }
    }
}