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

public partial class Viewseekerprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Show();
    }

    public void Show()
    {
        lblname.Text = Convert.ToString(Session["pname"]);
        lbldeg.Text = Convert.ToString(Session["pdegree"]);
        lblcourse.Text = Convert.ToString(Session["pcourse"]);
        lblexp.Text = Convert.ToString(Session["year"]);
        if (lblexp.Text == "&nbsp;&nbsp;")
        {
            lblexp1.Visible = false;
            lblexp.Visible = false;
        }
        lblcontact.Text = Convert.ToString(Session["pcontact"]);
        lblres.Text = Convert.ToString(Session["resume"]);
        if (lblres.Text == "&nbsp;")
        {
            lblres1.Visible = false;
            lblres.Visible = false;
        }
        lblresurl.Text = Convert.ToString(Session["resurl"]);
        if (lblresurl.Text == "&nbsp;")
        {
            lblresurl1.Visible = false;
            lblresurl.Visible = false;
        }
        lbltype.Text = Convert.ToString(Session["pfreshex"]);

    }
}
