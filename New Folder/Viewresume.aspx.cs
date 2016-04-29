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
using System.IO;
using Business_Logic;
using DataAccess;

public partial class Viewresume : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnupdate.Visible = false;
            btncancel.Visible = false;

            txtcletter.Enabled = false;
            txtaboutme.Enabled = false;
            lblpasteres.Visible = false;
            txtpasteres.Enabled = false;
            txtpasteres.Visible = false;
            txtskills.Enabled = false;
            lblres.Visible = false;
            lblupload.Visible = false;
            FileUpload1.Enabled = false;
            FileUpload1.Visible = false;
            btnupload.Visible = false;
            lblor.Visible = false;

            txtcletter.Text = Convert.ToString(Session["cover"]);
            txtaboutme.Text = Convert.ToString(Session["abtme"]);
            Data d=new Data();
            string name=Convert.ToString(Session["uname"]);
            string pwd=Convert.ToString(Session["upwd"]);
            GridView1.DataSource = d.resume(name, pwd);
            GridView1.DataBind();
            //txtres.Text = Convert.ToString(Session["resume"]);
            txtskills.Text = Convert.ToString(Session["keyskills"]);

        }
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        btnupdate.Visible = true;
        btncancel.Visible = true;
        btnedit.Visible = false;
        
        txtcletter.Enabled = true;
        txtaboutme.Enabled = true;
        lblpasteres.Visible = true;
        txtpasteres.Enabled = true;
        txtpasteres.Visible = true;
        txtskills.Enabled = true;
        lblres.Visible = true;
        lblupload.Visible = true;
        btnupload.Visible = true;
        FileUpload1.Enabled = true;
        FileUpload1.Visible = true;
        lblor.Visible = true;
        
        
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["userid1"];
        l.cover = txtcletter.Text;
        l.abtme = txtaboutme.Text;
        l.resume = txtpasteres.Text;
        l.keyskills = txtskills.Text;
        l.reg_res();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
        string foldername = Session["resfol"].ToString();
        logic l = new logic();
        if (Directory.Exists(Server.MapPath("Resume") + "\\" + foldername))
        {
        }
        else
        {
            Directory.CreateDirectory(Server.MapPath("Resume") + "\\" + foldername);
        }

        if (FileUpload1.PostedFile != null)
        {
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("Resume" + "\\" + foldername + FileName));
            l.url = "Resume/" + foldername + FileName;


        }

    }

    public void clearcontrols()
    {
        txtcletter.Enabled = false;
        txtaboutme.Enabled = false;
        lblpasteres.Visible = false;
        txtpasteres.Enabled = false;
        txtpasteres.Visible = false;
        lblres.Visible = false;
        txtskills.Enabled = false;
        lblupload.Visible = false;
        FileUpload1.Enabled = false;
        FileUpload1.Visible = false;
        btnupload.Visible = false;
        lblor.Visible = false;

        txtcletter.Text = Convert.ToString(Session["cover"]);
        txtaboutme.Text = Convert.ToString(Session["abtme"]);
        txtpasteres.Text = Convert.ToString(Session["resume"]);
        txtskills.Text = Convert.ToString(Session["keyskills"]);

    }
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("Welcome.aspx");
    }
}
