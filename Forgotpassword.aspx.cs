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

public partial class Forgotpassword : System.Web.UI.Page
{
    public string pwd;
    public int usertype;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        usertype=Convert.ToInt32(Session["usertype"]);
        txxtuser.Text = Convert.ToString(Session["uname"]);
        if (usertype == 1)
        {
            Lblsecure.Visible = false;
            txtsecure.Visible = false;
        }
        else
        {
            lblsAns.Visible = false;
            lblsecurity.Visible = false;
            DDLssecurity.Visible = false;
            txtsans.Visible = false;
        }

       
        
       
    }
    protected void DDLssecurity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

         
   protected void  Btn_Click(object sender, EventArgs e)
  {
      Data d = new Data();
       if (usertype == 1)
       {
           lblsAns.Visible = true;
           lblsecurity.Visible = true;
           DDLssecurity.Visible = true;
           txtsans.Visible = true;
           d.forgorpwd(txxtuser.Text,Convert.ToInt32(DDLssecurity.SelectedItem.Value), txtsans.Text);
           pwd=Convert.ToString(Session["pwd"]);
           lblPassword.Text = Convert.ToString(Session["pwd"]);
           d.updpwd(pwd);
       }
                
       else
            {
                Lblsecure.Visible = true;
                txtsecure.Visible = true;
                d.forgorpwd1(txxtuser.Text,txtsecure.Text);
                pwd = Convert.ToString(Session["pwd1"]);
                lblPassword.Text = Convert.ToString(Session["pwd1"]);
                d.updpwd1(pwd);
               
            }
   
   }


   protected void Btncancel_Click(object sender, EventArgs e)
   {
       txtsecure.Text="";
       txxtuser.Text = "";
       txtsans.Text = "";
       DDLssecurity.SelectedItem.Text = "--Select--";

   }
}
