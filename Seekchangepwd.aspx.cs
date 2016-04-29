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

public partial class Seekchangepwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.uname = txtusername.Text;
        l.upwd = txtOpassword.Text;
        l.upwd1 = txtNpassword.Text;
        l.updatepwd();
        txtusername.Text = "";
        txtNpassword.Text = "";
        txtOpassword.Text = "";
        txtCNpassword.Text = "";
    }
}
