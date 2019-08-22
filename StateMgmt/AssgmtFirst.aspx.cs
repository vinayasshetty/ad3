using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AssgmtFirst : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnstore_Click(object sender, EventArgs e)
    {
        //string word = txtword.Text;
        
        Session.Add(txtword.Text, TxtMeaning.Text);
    }

    protected void btnfinish_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("AssgmtSecond.aspx");
    }
}