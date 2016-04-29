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

public partial class Uploadvacancies : System.Web.UI.Page
{
    int x;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.compname = txtCompanyName.Text;
        l.vacancies = Convert.ToInt32(txtvacancy.Text);
        l.keyword = txtkeywrd.Text;
        l.mfield = x;
        l.field = txtFieldName.Text;
        l.exp = Convert.ToInt32(txtExp.Text);
        l.loc = txtLoc.Text;
        l.qua = txtQual.Text;
        l.keyskills = txtKeySkills.Text;
        l.abtcomp = txtabtcmp.Text;
        l.contact = Convert.ToInt64(txtContact.Text);
        l.userid = (int)Session["eid"];
        l.date = System.DateTime.Now.ToLongDateString();
        l.uploadvacancy();
        clearcontrols();

    }
    public void clearcontrols()
    {
        txtCompanyName.Text="";
        txtvacancy.Text="";
        txtkeywrd.Text="";
        txtFieldName.Text="";
        txtExp.Text="";
        txtLoc.Text="";
        txtQual.Text="";
        txtKeySkills.Text="";
        txtabtcmp.Text="";
        txtContact.Text="";
    }
    protected void DDLstream_SelectedIndexChanged(object sender, EventArgs e)
    {
       x=Convert.ToInt32(DDLstream.SelectedItem.Value);
    }
}
