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

public partial class Signup_Edu : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
           lblReqHq.Visible = false;
           lbldeg.Visible = false;
                             
        }
       if (DDLHQ.SelectedItem.Text == "--Select--")                        
         lblReqHq.Text = "* Select Ur Qualification";
        txtothers.Visible = false;
         
    }
    protected void DDLHQ_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DDLCourse.Items.Add("--SELECT--");
        DDLDegree.Items.Clear();
               
    }
    protected void DDLDegree_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLCourse.Items.Clear();
        DDLCourse.Items.Add("--Select--");
               
    }
    protected void DDLCourse_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DDLUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLIns.Items.Clear();
        DDLIns.Items.Add("--Select--");         
                   
    }
    protected void DDLIns_SelectedIndexChanged(object sender, EventArgs e)
    {
         if (DDLIns.SelectedItem.ToString()==("Others"))
            txtothers.Visible = true;
        
    }
    protected void DDLYop_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btneduSave_Click(object sender, EventArgs e)
    {
        RegularExp();
        txtothers.Visible = true;
        logic l = new logic();
        l.userid = (int)Session["id"];
        l.highqua = Convert.ToInt32(DDLHQ.SelectedItem.Value);
        l.degree = Convert.ToInt32(DDLDegree.SelectedItem.Value);
        l.course = Convert.ToInt32(DDLCourse.SelectedItem.Value);
        l.university = Convert.ToInt32(DDLUniversity.SelectedItem.Value);
        l.college =Convert.ToInt32(DDLIns.SelectedItem.Value);
        l.collname = txtothers.Text;
        l.yop = Convert.ToInt32(DDLYop.SelectedItem.Value);
        l.certification = txtcerticou.Text;
        if (Fresher.Checked)
            l.freshex = "Fresher";
        else
            l.freshex = "Experience";
        l.reg_edu();

        if (Fresher.Checked)
            Response.Redirect("Resume.aspx");
        else
            Response.Redirect("Signup_Experience.aspx");

        clearcontrols();


    }

    protected void Btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }

   public void  RegularExp()
    {
        if (DDLHQ.SelectedItem.Text == "--Select--")
        {
            lblReqHq.Visible = true;
            lblReqHq.Text = "* Select Ur Qualification";
        }
        else
            lblReqHq.Visible = false;

        if (DDLDegree.SelectedItem.Text == "--Select--")
        {
            lbldeg.Visible = true;
            lbldeg.Text = "* Select Ur Degree";
        }
        else
            lbldeg.Visible = false;

        if (DDLCourse.SelectedItem.Text != "--Select--")
            lblcou.Visible = false;
        else
            lblcou.Text = "Select Ur Course"; 

        if (DDLUniversity.SelectedItem.Text != "--Select--")
            lblUni.Visible = false;
        else
            lblUni.Text = "Select Ur University";

        if (DDLIns.SelectedItem.Text != "--Select--")
            lblIns1.Visible = false;
        else
            lblIns1.Text = "Mention ur Institute";

        if (DDLIns.SelectedItem.ToString() == "Others")
        {
            txtothers.Visible = true;
            txtothers.Text = "If Others Specify here";
        }
       
        
       if (DDLYop.SelectedItem.Text != "--Select--")
            lblyear.Visible = false;
        else
            lblyear.Text = "Mention the year of passing";

       if (Fresher.Checked || Experienced.Checked)
           lbltype1.Text = "*";
       else
           lbltype1.Visible = false;
     }

   public void clearcontrols()
   {
       DDLHQ.SelectedItem.Text = "--Select--";
       DDLDegree.SelectedItem.Text = "--Select--";
       DDLCourse.SelectedItem.Text = "--Select--";
       DDLUniversity.SelectedItem.Text = "--Select--";
       DDLIns.SelectedItem.Text = "--Select--";
       txtothers.Text = "";
       txtcerticou.Text = "";
       DDLYop.SelectedItem.Text = "--Select--";
   }


   
}
    

    
