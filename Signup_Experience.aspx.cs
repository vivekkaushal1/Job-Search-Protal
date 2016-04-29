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

public partial class Signup_Experience : System.Web.UI.Page
{
    public string experience1, experience2;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        experience1=(txtYear1.Text)+" yrs"+" "+(txtMonth1.Text)+" mon";
        experience2 =(txtYear2.Text) + " yrs" + " " + (txtMonth2.Text) + " mon";
        logic l = new logic();
        l.userid = (int)Session["id"];
        l.emp1 = txtempname1.Text;
        l.emp2 = txtempname2.Text;
        l.exp1 = experience1;
        l.exp2 = experience2;
        l.desig1 = txtdesignation1.Text;
        l.desig2 = txtdesignation2.Text;
        l.reg_exp();
        Response.Redirect("Resume.aspx");
        clearcontrols();

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    public void clearcontrols()
    {
        txtempname1.Text = "";
        txtempname2.Text = "";
        txtMonth1.Text = "";
        txtMonth2.Text = "";
        txtYear1.Text = "";
        txtYear2.Text = "";
        txtdesignation1.Text ="";
        txtdesignation2.Text ="";
    }
}
