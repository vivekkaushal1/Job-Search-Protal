using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Business_Logic;
using DataAccess;

public partial class Iseek_MasterPage : System.Web.UI.MasterPage
{
    public string search, keyword, experience, location;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlsearchjobs_SelectedIndexChanged(object sender, EventArgs e)
    {
        logic l = new logic();
        keyword = txtkeyword.Text;
        experience = txtExperience.Text;
        location = txtLocation.Text;
        if (ddlsearchjobs.SelectedItem.Text != "Search Jobs")
        {
            string name=Convert.ToString(Session["name"]);
            string name1 = String.Empty;
            if (string.Compare(name,name1) ==0)
            {
                Response.Write("<script>window.alert('Please Sign up')</script>");
            }
            else
            {
                Session["search1"] = ddlsearchjobs.SelectedItem.ToString();
                Response.Redirect("Viewseekjobs1.aspx");
            }
        }
         
    }
}
