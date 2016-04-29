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
using DataAccess;
using Business_Logic;

public partial class Viewjobs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbljobtype1.Text =(string)Session["search"];
        lblwelcome1.Text = Session["name"].ToString();
        logic l = new logic();


      
    }
}
