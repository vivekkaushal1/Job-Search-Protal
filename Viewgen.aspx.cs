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

public partial class Viewgen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            lblNation.Visible = false;
        }
        else
        {

            Btnupdate.Visible = false;
            BtnCancel.Visible = false;

            txtsfname.Enabled = false;
            txtslname.Enabled = false;
            txtsemail.Enabled = false;
            DDLNationlality.Enabled = false;
            DDLState.Enabled = false;
            txtcity.Enabled = false;
            txtContact.Enabled = false;
            txtsfname.Text = Convert.ToString(Session["fname"]);
            txtslname.Text = Convert.ToString(Session["lname"]);
            txtsemail.Text = Convert.ToString(Session["email"]);
            DDLNationlality.SelectedItem.Text = Convert.ToString(Session["nation1"]);
            DDLState.SelectedItem.Text = Convert.ToString(Session["state1"]);
            txtcity.Text = Convert.ToString(Session["city"]);
            txtContact.Text = Convert.ToString(Session["contact"]);
        }

    }
    protected void Btnedit_Click(object sender, EventArgs e)
    {
        txtsfname.Enabled = true;
        txtslname.Enabled = true;
        txtsemail.Enabled = true;
        DDLNationlality.Enabled = true;
        DDLNationlality.SelectedItem.Text = "--Select--";
        DDLState.Enabled = true;
        DDLState.SelectedItem.Text = "--Select--";
        txtcity.Enabled = true;
        txtContact.Enabled = true;

        Btnedit.Visible = false;
        Btnupdate.Visible = true;
        BtnCancel.Visible = true;

    }
    protected void Btnupdate_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["userid1"];
        l.fname = txtsfname.Text;
        l.lname = txtslname.Text;
        l.email = txtsemail.Text;
        l.nationality = Convert.ToInt32(DDLNationlality.SelectedItem.Value);
        l.state = Convert.ToInt32(DDLState.SelectedItem.Value);
        l.city = txtcity.Text;
        l.contact = Convert.ToInt64(txtContact.Text);
        l.updategen();
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    protected void DDLNationlality_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLState.Items.Clear();
        DDLState.Items.Add("--Select--");
    }
    protected void DDLState_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public void clearcontrols()
    {
        txtsfname.Enabled = false;
        txtslname.Enabled = false;
        txtsemail.Enabled = false;
        DDLNationlality.Enabled = false;
        DDLState.Enabled = false;
        txtcity.Enabled = false;
        txtContact.Enabled = false;
        txtsfname.Text = Convert.ToString(Session["fname"]);
        txtslname.Text = Convert.ToString(Session["lname"]);
        txtsemail.Text = Convert.ToString(Session["email"]);
        DDLNationlality.SelectedItem.Text = Convert.ToString(Session["nation1"]);
        DDLState.SelectedItem.Text = Convert.ToString(Session["state1"]);
        txtcity.Text = Convert.ToString(Session["city"]);
        txtContact.Text = Convert.ToString(Session["contact"]);
    }
}
