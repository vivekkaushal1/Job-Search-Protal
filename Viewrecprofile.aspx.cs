using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Viewrecprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text=Convert.ToString( Session["company"]);
        lblper.Text = Convert.ToString(Session["person"]);
        lblcontact.Text = Convert.ToString(Session["contact"]) + "</br>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToString(Session["contact1"]);
        lblloc.Text = Convert.ToString(Session["clocation"]);
        website.Text = Convert.ToString(Session["curl"]);
        website.NavigateUrl = "http://"+website.Text;
        website.Target = "blank";
    }
}
