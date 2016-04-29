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

public partial class Viewseekexp : System.Web.UI.Page
{
    public string experience1, experience2;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnupdate.Visible = false;
            btncancel.Visible = false;

            txtempname1.Enabled = false;
            txtempname2.Enabled = false;
            txtdesignation1.Enabled = false;
            txtdesignation2.Enabled = false;
            txtYear1.Enabled = false;
            txtYear2.Enabled = false;
            txtMonth1.Enabled = false;
            txtMonth2.Enabled = false;

            txtempname1.Text = Convert.ToString(Session["empname"]);
            txtempname2.Text = Convert.ToString(Session["emp2name"]);
            txtdesignation1.Text = Convert.ToString(Session["desig1"]);
            txtdesignation2.Text = Convert.ToString(Session["desig2"]);
            txtYear1.Text = Convert.ToString(Session["exp1"]);
            txtYear2.Text = Convert.ToString(Session["exp2"]);
            txtMonth1.Text = Convert.ToString(Session["exp1"]);
            txtMonth2.Text = Convert.ToString(Session["exp2"]);

        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        txtempname1.Enabled = true;
        txtempname2.Enabled = true;
        txtdesignation1.Enabled = true;
        txtdesignation2.Enabled = true;
        txtYear1.Enabled = true;
        txtYear2.Enabled = true;
        txtMonth1.Enabled = true;
        txtMonth2.Enabled = true;

        btnedit.Visible = false;
        btnupdate.Visible = true;
        btncancel.Visible = true;
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {

        experience1 = (txtYear1.Text) + " yrs" + " " + (txtMonth1.Text) + " mon";
        experience2 = (txtYear2.Text) + " yrs" + " " + (txtMonth2.Text) + " mon";
        logic l = new logic();
        l.userid = (int)Session["userid1"];
        l.emp1 = txtempname1.Text;
        l.emp2 = txtempname2.Text;
        l.exp1 = experience1;
        l.exp2 = experience2;
        l.desig1 = txtdesignation1.Text;
        l.desig2 = txtdesignation2.Text;
        l.reg_exp();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
   
    public void clearcontrols()
    {
        txtempname1.Enabled = false;
        txtempname2.Enabled = false;
        txtdesignation1.Enabled = false;
        txtdesignation2.Enabled = false;
        txtYear1.Enabled = false;
        txtYear2.Enabled = false;
        txtMonth1.Enabled = false;
        txtMonth2.Enabled = false;

        txtempname1.Text = Convert.ToString(Session["empname"]);
        txtempname2.Text = Convert.ToString(Session["emp2name"]);
        txtdesignation1.Text = Convert.ToString(Session["desig1"]);
        txtdesignation2.Text = Convert.ToString(Session["desig2"]);
        txtYear1.Text = Convert.ToString(Session["exp1"]);
        txtYear2.Text = Convert.ToString(Session["exp2"]);
        txtMonth1.Text = Convert.ToString(Session["exp1"]);
        txtMonth2.Text = Convert.ToString(Session["exp2"]);
    }
}
