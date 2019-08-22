using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AssgmtSecond : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Dictionary<string, string> ds = new Dictionary<string, string>();
        foreach (string i in Session.Keys)
        {
            ds.Add(i, Session[i].ToString());
        }
        dgv.DataSource = ds;
        dgv.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        

    }
   
}