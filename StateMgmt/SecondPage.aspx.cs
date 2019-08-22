using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SecondPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //using querystring
        // string accno = Request.QueryString.Get("accno");//string accno = Request.QueryString[0];
        //string city = Request.QueryString.Get("city");//string accno = Request.QueryString[1];

        //using cookies
        //string accno, city;
        //read the cokie
        //HttpCookie ck_accno = Request.Cookies.Get("accno");
        //HttpCookie ck_city = Request.Cookies.Get("city");
        //accno = ck_accno.Value;
        //city = ck_city.Value;

        //using session/applocation
        string accno = Session["Accno"].ToString();
        string City = Session["City"].ToString();

        //string accno = Application["Accno"].ToString();
        //string City =Application["City"].ToString();

        lblAccno.Text = "Your Account Number is:" + accno;
        lblCity.Text = "City is:" + City;
    }
}