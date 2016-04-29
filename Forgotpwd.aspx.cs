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

public partial class Forgotpwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
             lblsec.Visible = false;
        }

       if (ddlsecque.SelectedItem.Text == "--SELECT--")
            lblsec.Text = "Select Ur Security Question";
       
           
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
    }
    protected void ddlsecque_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}
