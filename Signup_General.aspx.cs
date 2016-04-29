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

public partial class Signup_General : System.Web.UI.Page
{     
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.usertype = Convert.ToInt32(Session["usertype"]);
        Session["resfol"] = txtsfname.Text;
        l.fname = txtsfname.Text;
        l.lname = txtslname.Text;
        l.email = txtsemail.Text;
        l.username = txtsuser.Text;
        l.password = txtspwd.Text;
        l.security =Convert.ToInt32(DDLssecurity.SelectedItem.Value);
        l.answer = txtsans.Text;
        int y=l.reg_gen();
        Session["id"] =y;
        clearcontrols();
        Response.Redirect("Signup_Personal.aspx");
    }
    protected void Btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    protected void DDLssecurity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DDLssecurity.SelectedItem.Text == "--Select--")
            lblmsgsec.Text = "*";
        else
            lblmsgsec.Visible = false;
    }
    public void clearcontrols()
    {
        txtsfname.Text = "";
        txtslname.Text = "";
        txtsemail.Text = "";
        txtsuser.Text = "";
        txtspwd.Text = "";
        DDLssecurity.Items.Clear();
        DDLssecurity.Items.Add("--Select--");
        txtsans.Text = "";
    }
}
