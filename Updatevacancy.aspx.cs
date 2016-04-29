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

public partial class Updatevacancy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DDLstream_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnproceed_Click(object sender, EventArgs e)
    {
        Session["Umfield"] =Convert.ToInt32(DDLstream.SelectedItem.Value);
        Session["Uexp"]=txtexp.Text;
        Session["Ufield"]=txtfield.Text;
        Session["Uloc"]=txtloc.Text;
        Response.Redirect("Updatevacancies.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}
