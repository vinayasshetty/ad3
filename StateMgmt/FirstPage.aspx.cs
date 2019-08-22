using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FirstPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session.SessionID;
    }

    protected void btnNext_Click(object sender, EventArgs e)
    {
        string accno = txtAccno.Text;
        string city = txtCity.Text;
        //using query string
        //Response.Redirect("SecondPage.aspx?accno="+accno+"&city="+city);//~/foldername/filename relative path
        //using cookies
       // HttpCookie ck_accno = new HttpCookie("accno", accno1);
        //HttpCookie ck_city = new HttpCookie("city", city);
        //write the cookies data to file
        //Response.Cookies.Add(ck_accno);
        //Response.Cookies.Add(ck_city);

        //using session/application
        //Application.Add("Accno", accno);
        //Application.Add("City", city);
        Session.Add("Accno", accno);
        Session.Add("City", city);
        Response.Redirect("SecondPage.aspx");
    }
}