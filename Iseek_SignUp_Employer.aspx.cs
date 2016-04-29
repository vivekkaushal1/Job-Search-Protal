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

public partial class Iseek_SignUp_Employer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            
        if (ddlcountry.SelectedItem.Text == "--Select--")
            lblcou.Text = "*";
        else
            lblcou.Visible = false;

        if (ddlstate.SelectedItem.Text == "--Select--")
            lblsta.Text = "*";
        else
            lblsta.Visible = false;

    }

    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlstate.Items.Clear();
        ddlstate.Items.Add("--Select--");
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnproceed_Click(object sender, EventArgs e)
    {
        RegularExp();
        logic l = new logic();
        l.usertype =(int) Session["usertype"];
        l.compname = txtcompname.Text;
        l.contperson = txtContactPerson.Text;
        l.number = Convert.ToInt64(txtPhNo.Text);
        l.empaddress = (txtAddress1.Text) + (txtAddress2.Text);
        l.empnationality = Convert.ToInt32(ddlcountry.SelectedItem.Value);
        l.empstate = Convert.ToInt32(ddlstate.SelectedItem.Value);
        l.empcity = txtcity.Text;
        l.abtemp = txtAbtMe.Text;
        l.compurl = txtwebsite.Text;
        l.eusername = txteuser.Text;
        l.epassword = txtepwd.Text;
        l.seaname = txtsecure.Text;
        Session["eid"]=l.reg_emp();
        clearcontrols();
      

    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }

    public void RegularExp()
    {
        if (ddlcountry.SelectedItem.Text == "--Select--")
            lblcou.Text = "*";
        else
            lblcou.Visible = false;

        if (ddlstate.SelectedItem.Text == "--Select--")
            lblsta.Text = "*";
        else
            lblsta.Visible = false;

        //if (chkTC.Checked)
        //    //Response.Redirect("Signup_Personal.aspx");
        //else
        //    lblcheck.Text = "Accept the terms to continue else click cancel to quit the process";
    }

    public void clearcontrols()
    {
        txtcompname.Text = "";
        txtContactPerson.Text = "";
        txtPhNo.Text = "";
        txtAddress1.Text = "";
        txtAddress2.Text = "";
        ddlcountry.SelectedItem.Text = "--Select--";
        ddlstate.SelectedItem.Text = "--Select--";
        txtcity.Text = "";
        txtAbtMe.Text = "";
        txtwebsite.Text = "";
        txteuser.Text = "";
       
       
    }
}