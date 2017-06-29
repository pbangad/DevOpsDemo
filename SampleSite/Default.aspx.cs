using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BTN1_Click(object sender, EventArgs e)
    {
        TXT1.Text = "Test Text";
        BTN2.Visible = true;
    }

    protected void BTN2_Click(object sender, EventArgs e)
    {
        TXT1.Text = "";
        BTN2.Visible = false;
    }
}