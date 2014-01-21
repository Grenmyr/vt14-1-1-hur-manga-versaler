using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Versaler.Model;

namespace Versaler
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Onclick(object sender, EventArgs e)
        {
            //string message = TextBox.Text;
           Response.Text = TextBox.Text.GetNumberOfCapitals().ToString();
        }

        
    }
}