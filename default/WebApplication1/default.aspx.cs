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
        protected void SubmitButton_Onclick(object sender, EventArgs e)
        {            
            //string message = TextBox.Text;
            // Läser av Textfält och anropar min metod som räknar antalet stora bokstäver och presenterar det som sträng för min response label.
            Response.Text = TextBox.Text.GetNumberOfCapitals().ToString();

            // Döljer och visar knappar.
            TextBox.Enabled = false;        
            SubmitButton.Visible = false;
            Response.Visible = true;
            ResetButton.Visible = true;
            // Eftersom min Resetbutton ej har en egen metod så blir det en tom post när den trycks och ihop med viewstate disabled så laddas blank sida igen.
        }

    }
}