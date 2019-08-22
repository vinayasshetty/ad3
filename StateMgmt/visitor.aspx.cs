using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class visitor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //lbtvisitor.Text = "The count is" + x;
        lbtvisitor.Text = "Visitors:" + Application["visitors"].ToString();

        
    }
}