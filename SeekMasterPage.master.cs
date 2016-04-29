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

public partial class SeekMasterPage : System.Web.UI.MasterPage
{
    public string search, keyword, experience, location;
    public int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        Data d=new Data();
        user.Text =Convert.ToString(Session["name"]);
        if (string.Compare((Convert.ToString(Session["f/e"])), "Fresher") == 1)
            exp.Enabled = false;
        else
            exp.Enabled = true;
        
        logic l = new logic();
        l.userid = Convert.ToInt32(Session["userid1"]);
        int id=Convert.ToInt32(Session["userid1"]);
        count = l.viewrec();
        recview.Text = count.ToString();
        d.jobcount(id);
        int x=Convert.ToInt32(Session["count"]);
        Label6.Text = x.ToString();
        
        
    }
    protected void ddlsearchjobs_SelectedIndexChanged(object sender, EventArgs e)
    {
        keyword = txtkeyword.Text;
        experience = txtExperience.Text;
        location = txtLocation.Text;

        if (ddlsearchjobs.SelectedItem.Text != "Search Jobs")
        {
                Session["search1"] = ddlsearchjobs.SelectedItem.ToString();
                Response.Redirect("Viewseekjobs1.aspx");
           
        }
    }

    protected void view_Click(object sender, EventArgs e)
    {
        Response.Redirect("Viewrecdetails.aspx");
    }





    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["key"] = txtkeyword.Text;
        Session["se-exp"] = txtExperience.Text;
        Session["se-loc"] = txtLocation.Text;
        Response.Redirect("Viewseekjobs2.aspx");
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Iseek_home.aspx");
    }
}
