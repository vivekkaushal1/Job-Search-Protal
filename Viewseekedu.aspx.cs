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

public partial class Viewseekedu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            lblReqHq.Visible = false;
            lbldeg.Visible = false;

        }
        else
        {
            btnupdate.Visible = false;
            Btncancel.Visible = false;

            DDLHQ.Enabled = false;
            DDLDegree.Enabled = false;
            DDLCourse.Enabled = false;
            txtcerticou.Enabled = false;
            txtothers.Enabled = false;
            DDLUniversity.Enabled = false;
            DDLIns.Enabled = false;
            DDLYop.Enabled = false;
            Fresher.Enabled = false;
            Experienced.Enabled = false;

            DDLHQ.SelectedItem.Text = Convert.ToString(Session["hq1"]);
            DDLDegree.SelectedItem.Text = Convert.ToString(Session["degree1"]);
            DDLCourse.SelectedItem.Text = Convert.ToString(Session["course1"]);
            DDLUniversity.SelectedItem.Text = Convert.ToString(Session["university1"]);
            DDLIns.SelectedItem.Text = Convert.ToString(Session["institute1"]);
            DDLYop.SelectedItem.Text = Convert.ToString(Session["yop1"]);
            txtcerticou.Text = Convert.ToString(Session["certify"]);
            txtothers.Text = Convert.ToString(Session["insname"]);
            if (string.Compare(Convert.ToString(Session["f/e"]), "Fresher") == 1)
            {
                Fresher.Checked = true;
                Experienced.Checked = false;
            }
            else
            {
                Experienced.Checked = true;
                Fresher.Checked = false;

            }

        }
    }
    protected void DDLHQ_SelectedIndexChanged(object sender, EventArgs e)
    {
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
        if (DDLIns.SelectedItem.ToString() == ("Others"))
            txtothers.Visible = true;
    }
    protected void DDLYop_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btneduedit_Click(object sender, EventArgs e)
    {
        DDLHQ.Enabled = true;
        DDLDegree.Enabled = true;
        DDLCourse.Enabled = true;
        DDLHQ.SelectedItem.Text = "--Select--";
        DDLDegree.SelectedItem.Text = "--Select--";
        DDLCourse.SelectedItem.Text = "--Select--";
        DDLIns.SelectedItem.Text = "--Select--";
        DDLUniversity.SelectedItem.Text = "--Select--";
        DDLYop.SelectedItem.Text = "--Select--";
        txtcerticou.Enabled = true;
        txtothers.Enabled = true;
        DDLUniversity.Enabled = true;
        DDLIns.Enabled = true;
        DDLYop.Enabled = true;
        Fresher.Enabled = true;
        Experienced.Enabled = true;

        btneduedit.Visible = false;
        btnupdate.Visible = true;
        Btncancel.Visible = true;
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["userid1"];
        l.highqua = Convert.ToInt32(DDLHQ.SelectedItem.Value);
        l.degree = Convert.ToInt32(DDLDegree.SelectedItem.Value);
        l.course = Convert.ToInt32(DDLCourse.SelectedItem.Value);
        l.university = Convert.ToInt32(DDLUniversity.SelectedItem.Value);
        l.college = Convert.ToInt32(DDLIns.SelectedItem.Value);
        l.collname = txtothers.Text;
        l.yop = Convert.ToInt32(DDLYop.SelectedItem.Value);
        l.certification = txtcerticou.Text;
        if (Fresher.Checked)
            l.freshex = "Fresher";

        else
            l.freshex = "Experience";
        l.reg_edu();
    }
    protected void Btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
 
    public void clearcontrols()
    {
        DDLHQ.Enabled = false;
        DDLDegree.Enabled = false;
        DDLCourse.Enabled = false;
        txtcerticou.Enabled = false;
        txtothers.Enabled = false;
        DDLUniversity.Enabled = false;
        DDLIns.Enabled = false;
        DDLYop.Enabled = false;
        Fresher.Enabled = false;
        Experienced.Enabled = false;

        DDLHQ.SelectedItem.Text = Convert.ToString(Session["hq1"]);
        DDLDegree.SelectedItem.Text = Convert.ToString(Session["degree1"]);
        DDLCourse.SelectedItem.Text = Convert.ToString(Session["course1"]);
        DDLUniversity.SelectedItem.Text = Convert.ToString(Session["university"]);
        DDLIns.SelectedItem.Text = Convert.ToString(Session["institute1"]);
        DDLYop.SelectedItem.Text = Convert.ToString(Session["yop1"]);
        txtcerticou.Text = Convert.ToString(Session["certify"]);
        txtothers.Text = Convert.ToString(Session["insname"]);
        if (Convert.ToString(Session["f/e"]) == "Fresher")
            Fresher.Checked = true;
        else
            Experienced.Checked = true;
    }

}
