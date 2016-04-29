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

public partial class Updatevacancies : System.Web.UI.Page
{
    int x;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        if (!IsPostBack)
        {
            logic l = new logic();
            l.userid = Convert.ToInt32(Session["eid"]);
            l.field = Convert.ToString(Session["Ufield"]);
            l.loc = Convert.ToString(Session["Uloc"]);
            l.exp = Convert.ToInt32(Session["Uexp"]);
            l.mfield = Convert.ToInt32(Session["Umfield"]);
            l.fetchvacancies();
            l.userid = Convert.ToInt32(Session["mfield"]);
            l.fetchmfield();

            btnupdate.Visible = false;
            btncancel.Visible = false;

            txtCompanyName.Enabled = false;
            txtContact.Enabled = false;
            txtFieldName.Enabled = false;
            txtKeySkills.Enabled = false;
            txtExp.Enabled = false;
            txtabtcmp.Enabled = false;
            txtkeywrd.Enabled = false;
            txtLoc.Enabled = false;
            txtQual.Enabled = false;
            txtvacancy.Enabled = false;
            DDLstream.Enabled = false;

            txtCompanyName.Text=Convert.ToString(Session["compname"]);
            txtvacancy.Text=Convert.ToString(Session["Vacancy"]);
            txtkeywrd.Text=Convert.ToString(Session["keyword"]);
            txtFieldName.Text=Convert.ToString(Session["role"]);
            txtExp.Text=Convert.ToString(Session["experience"]);
            txtLoc.Text=Convert.ToString(Session["location"]);
            txtQual.Text=Convert.ToString(Session["education"]);
            txtKeySkills.Text=Convert.ToString(Session["skills"]);
            txtabtcmp.Text=Convert.ToString(Session["compprofile"]);
            txtContact.Text=Convert.ToString(Session["number"]);
            l.userid=Convert.ToInt32(Session["eid"]);
            DDLstream.SelectedItem.Text = Convert.ToString(Session["mfieldname"]);


            
        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        txtCompanyName.Enabled = true;
        txtContact.Enabled = true;
        txtFieldName.Enabled = true;
        txtKeySkills.Enabled = true;
        txtExp.Enabled = true;
        txtabtcmp.Enabled = true;
        txtkeywrd.Enabled = true;
        txtLoc.Enabled = true;
        txtQual.Enabled = true;
        txtvacancy.Enabled = true;
        DDLstream.Enabled = true;
        DDLstream.SelectedItem.Text = "--Select--";
                
        btnupdate.Visible = true;
        btncancel.Visible = true;
        btnedit.Visible = false;

        

    }
    protected void btnupdate_Click(object sender, EventArgs e)
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
        l.userid = Convert.ToInt32(Session["eid"]);
        l.field1 = Convert.ToString(Session["Ufield"]);
        l.loc1= Convert.ToString(Session["Uloc"]);
        l.experience = Convert.ToInt32(Session["Uexp"]);
        l.mfield1 = Convert.ToInt32(Session["Umfield"]);
        l.date = System.DateTime.Now.ToLongDateString();
        l.upd_vac();
    }
   protected void btncancel_Click(object sender, EventArgs e)
    {
        logic l = new logic(); 
        txtCompanyName.Enabled = false;
        txtContact.Enabled = false;
        txtFieldName.Enabled = false;
        txtKeySkills.Enabled = false;
        txtExp.Enabled = false;
        txtabtcmp.Enabled = false;
        txtkeywrd.Enabled = false;
        txtLoc.Enabled = false;
        txtQual.Enabled = false;
        txtvacancy.Enabled = false;
        DDLstream.Enabled = false;

        txtCompanyName.Text = Convert.ToString(Session["compname"]);
        txtvacancy.Text = Convert.ToString(Session["Vacancy"]);
        txtkeywrd.Text = Convert.ToString(Session["keyword"]);
        txtFieldName.Text = Convert.ToString(Session["role"]);
        txtExp.Text = Convert.ToString(Session["experience"]);
        txtkeywrd.Text = Convert.ToString(Session["location"]);
        txtQual.Text = Convert.ToString(Session["education"]);
        txtKeySkills.Text = Convert.ToString(Session["skills"]);
        txtabtcmp.Text = Convert.ToString(Session["compprofile"]);
        txtContact.Text = Convert.ToString(Session["number"]);
        l.userid = Convert.ToInt32(Session["mfield"]);
        DDLstream.SelectedItem.Text = Convert.ToString(Session["mfieldname"]);

    }
   protected void DDLstream_SelectedIndexChanged(object sender, EventArgs e)
   {
       x = Convert.ToInt32(DDLstream.SelectedItem.Value);
   }
}
