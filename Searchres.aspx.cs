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
using Business_Logic;
using DataAccess;

public partial class Searchres : System.Web.UI.Page
{
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        logic l = new logic();
        l.field = Convert.ToString(Session["jobfield"]);
        l.compname = Convert.ToString(Session["cname"]);
        l.loc = Convert.ToString(Session["loc"]);
        l.searchres();
        l.userid =Convert.ToInt32(Session["recid"]);
        l.searchres1();

        lblcname.Text=Convert.ToString(Session["compname"]);
        lblfield.Text=Convert.ToString(Session["role"]);
        lblexp.Text=Convert.ToString(Session["experience"]);
        lblloc.Text=Convert.ToString(Session["location"]);
        lblqua.Text=Convert.ToString(Session["education" ]);
        lblskills.Text=Convert.ToString(Session["skills"]);
        lblcprofile.Text=Convert.ToString(Session["compprofile"]);
        lblnumber.Text=Convert.ToString(Session["number"]);
        lbldate.Text = Convert.ToString(Session["date"]);

        lblcontact.Text=Convert.ToString(Session["personname"]);
        lblurl.Text = Convert.ToString(Session["compurl"]);
        
      }
    protected void Btnapply_Click(object sender, EventArgs e)
    {
        i=i+1;
        logic l = new logic();
        l.userid = (int)(Session["userid1"]);
        int flag=l.checkjobuser();
        if (flag == 0)
        {
            Response.Write("<script>window.alert('You have already applied for this job')</script>");
        }
            
        
        else
        {
            l.jobcount = i;
            l.status = 1;
            l.field = lblfield.Text;
            l.userid = (int)(Session["userid1"]);
            l.compname = lblcname.Text;
            l.loc = lblloc.Text;
            l.date = System.DateTime.Now.ToString();
            l.jobinfo();
        }

    }
}
