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

public partial class empViewprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnupdate.Visible = false;
            btncancel.Visible = false;

            txtcompname.Enabled = false;
            txtContactPerson.Enabled = false;
            txtPhNo.Enabled = false;
            txtwebsite.Enabled = false;
            txtcity.Enabled = false;
            txtAbtMe.Enabled = false;
            txtAddress1.Enabled = false;
            txtAddress2.Enabled = false;
            ddlcountry.Enabled = false;
            ddlstate.Enabled = false;

            txtcompname.Text=Convert.ToString(Session["Company_Name"]);
            txtContactPerson.Text = Convert.ToString(Session["Contact_Person"]);
            txtPhNo.Text = Convert.ToString(Session["ContactNo"]);
            txtwebsite.Text = Convert.ToString(Session["Compurl"]);
            txtcity.Text = Convert.ToString(Session["ecity"]);
            txtAbtMe.Text = Convert.ToString(Session["About_Emp"]);
            txtAddress1.Text = Convert.ToString(Session["Comp_Address"]);
            txtAddress2.Text = Convert.ToString(Session["Comp_Address"]);
            ddlcountry.SelectedItem.Text = Convert.ToString(Session["enation1"]);
            ddlstate.SelectedItem.Text = Convert.ToString(Session["estate1"]);
           
        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {

        txtcompname.Enabled = true;
        txtContactPerson.Enabled = true;
        txtPhNo.Enabled = true;
        txtwebsite.Enabled = true;
        txtcity.Enabled = true;
        txtAbtMe.Enabled = true;
        txtAddress1.Enabled = true;
        txtAddress2.Enabled = true;
        ddlcountry.SelectedItem.Text = "--Select";
        ddlstate.SelectedItem.Text = "--Select";
        
        btnedit.Visible = false;
        btnupdate.Visible = true;
        btncancel.Visible = true;

    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["empid"];
        l.compname = txtcompname.Text;
        l.contperson = txtContactPerson.Text;
        l.number = Convert.ToInt64(txtPhNo.Text);
        l.empaddress = (txtAddress1.Text) + (txtAddress2.Text);
        l.empnationality = Convert.ToInt32(ddlcountry.SelectedItem.Value);
        l.empstate = Convert.ToInt32(ddlstate.SelectedItem.Value);
        l.empcity = txtcity.Text;
        l.abtemp = txtAbtMe.Text;
        l.compurl = txtwebsite.Text;
        l.updateemp();     
             
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }

    public void clearcontrols()
    {
        txtcompname.Enabled = false;
        txtContactPerson.Enabled = false;
        txtPhNo.Enabled = false;
        txtwebsite.Enabled = false;
        txtcity.Enabled = false;
        txtAbtMe.Enabled = false;
        txtAddress1.Enabled = false;
        txtAddress2.Enabled = false;
        ddlcountry.Enabled = false;
        ddlstate.Enabled = false;

        txtcompname.Text = Convert.ToString(Session["Company_Name"]);
        txtContactPerson.Text = Convert.ToString(Session["Contact_Person"]);
        txtPhNo.Text = Convert.ToString(Session["ContactNo"]);
        txtwebsite.Text = Convert.ToString(Session["Compurl"]);
        txtcity.Text = Convert.ToString(Session["ecity"]);
        txtAbtMe.Text = Convert.ToString(Session["About_Emp"]);
        txtAddress1.Text = Convert.ToString(Session["Comp_Address"]);
        txtAddress2.Text = Convert.ToString(Session["Comp_Address"]);
        ddlcountry.SelectedItem.Text = Convert.ToString(Session["enation1"]);
        ddlstate.SelectedItem.Text = Convert.ToString(Session["estate1"]);
    }

    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
