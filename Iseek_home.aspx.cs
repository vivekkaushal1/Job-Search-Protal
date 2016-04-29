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

public partial class Iseek_home : System.Web.UI.Page
{
    public int flag = -1;
    public int usertype;
    public string username;
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnsignin_Click(object sender, EventArgs e)
    {
        
        if (Jobseeker.Checked || Employer.Checked)
           lblusertype.Text = "";
        else
            lblusertype.Text = "Choose the Field";


        logic l = new logic();
        l.uname = txtid.Text;
        l.upwd = txtpwd.Text;
        Session["uname"] = txtid.Text;
        Session["upwd"] = txtpwd.Text;
        l.seekuser = txtid.Text;
        l.seekpwd = txtpwd.Text;

        if (Jobseeker.Checked)
        {
            Session["usertype"] = 1;
            Session["name"] = null;
            flag = l.check();
            if (flag == 1)
                lblvalid.Text = "Invalid User";
            else
            {
                l.viewprofile();
                l.ddnation = (int)Session["nation"];
                l.nation();
                l.ddstate = (int)Session["state"];
                l.tblstate();
                l.ddhq = (int)Session["hq"];
                l.hq();
                l.dddegree = (int)Session["degree"];
                l.getdeg();
                l.ddcourse = (int)Session["course"];
                l.getcou();
                l.dduni = (int)Session["university"];
                l.getuni();
                l.ddins = (int)Session["institute"];
                l.getins();
                l.ddyear = (int)Session["yop"];
                l.getyop();
                Response.Redirect("WelcomeSeek.aspx");
            }
            
        }
        else
        {
            Session["usertype"] = 2;
            flag = l.checkemp();
            if (flag == 1)
                lblvalid.Text = "Invalid User";
            else
            {
                l.viewprofile1();
                l.enation = (int)Session["enation"];
                l.getempnation();
                l.estate = (int)Session["estate"];
                l.getempstate();
                Response.Redirect("WelcomeEmp.aspx");
            }
           
        }

        
        
        
           
     }
    protected void btnseek_Click(object sender, EventArgs e)
    {
        if (Jobseeker.Checked)
        {
            Session["usertype"] = 1;
            Response.Redirect("Signup_General.aspx");
        }
        else
        {
            Session["usertype"] = 2;
            Response.Redirect("Iseek_SignUp_Employer.aspx");
        }
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Jobseeker.Checked)
        {
            Session["usertype"] = 1;
            
        }
        else
        {
            Session["usertype"] = 2;
           
        }
        Data d = new Data();
        usertype = Convert.ToInt32(Session["usertype"]);
        username = txtid.Text;
        Session["uname"] = txtid.Text;
        int x = d.fuser(username);
        if (x == 0)
        {
            if ((usertype != 1) && (usertype != 2))
            {
                Response.Write("<script>window.alert('Please specify the usertype')</script>");
                
            }
            else
                Response.Redirect("Forgotpassword.aspx");
       }
        
    }
}
