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

public partial class Signup_Personal : System.Web.UI.Page
{         
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            lblNation.Visible = false;
        }
                  
        
      
    }
    public void DDLNationlality_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLState.Items.Clear();
        DDLState.Items.Add("--Select--");
             
    }
    public void DDLState_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        RegularExp();
        logic l = new logic();
        l.userid = (int)Session["id"];
        l.dob = txtdate.Text;
        if (Male.Checked)
            l.gender = "Male";
        else
            l.gender = "Female";
        l.nationality = Convert.ToInt32(DDLNationlality.SelectedItem.Value);
        l.state = Convert.ToInt32(DDLState.SelectedItem.Value);
        l.city = txtcity.Text;
        l.contact = Convert.ToInt64(txtContact.Text);
        l.reg_per();
        clearcontrols();
        Response.Redirect("Signup_Edu.aspx");
   
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }


    public void RegularExp()
    {
        if (Male.Checked || Female.Checked)
            lblcheck.Visible = false;
        else
            lblcheck.Text = "Required Field";

        if (DDLNationlality.SelectedItem.Text == "--Select--")
        {
            lblNation.Visible = true;
            lblNation.Text = "Select Ur Nationality";
        }
        else
            lblNation.Visible = false;

        if (DDLState.SelectedItem.Text != "--Select--")
            lblreqState.Visible = false;
        else
            lblreqState.Text = "Select Ur State";
    }


    public void clearcontrols()
    {
        txtdate.Text = "";
        if (Male.Checked)
            Male.Checked = false;
        else
            Female.Checked = false;
        DDLNationlality.SelectedItem.Text="--Select-";
        DDLState.SelectedItem.Text="--Select--";
        txtcity.Text="";
        txtContact.Text="";
    }
}
