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

public partial class Viewseelres : System.Web.UI.Page
{
    string p;
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl.Visible = false;
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
            txtres.Enabled = false;

            txtcletter.Text = Convert.ToString(Session["cover"]);
            txtaboutme.Text = Convert.ToString(Session["abtme"]);
            Data d = new Data();
            string name = Convert.ToString(Session["uname"]);
            string pwd = Convert.ToString(Session["upwd"]);
            GridView1.DataSource = d.resume(name, pwd);
            //GridView1.Visible = false;
            GridView1.DataBind();
            //txtres.Text = Convert.ToString(Session["resume"]);
            //txtres.Text = GridView1.Rows[0].Cells[0].Text;
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
        txtres.Visible = false;
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["userid1"];
        l.cover = txtcletter.Text;
        l.abtme = txtaboutme.Text;
        l.resume = txtpasteres.Text;
        l.url = lbl.Text;
        l.keyskills = txtskills.Text;
        l.reg_res();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearcontrols();
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
        txtres.Visible =true;
        txtres.Enabled = false;

        txtcletter.Text = Convert.ToString(Session["cover"]);
        txtaboutme.Text = Convert.ToString(Session["abtme"]);
        txtpasteres.Text = Convert.ToString(Session["resume"]);
        txtskills.Text = Convert.ToString(Session["keyskills"]);

    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
        if (Directory.Exists(Server.MapPath("Upload" + "\\")))
        {
        }
        else
            Directory.CreateDirectory(Server.MapPath("Upload" + "\\"));   
        
        if (FileUpload1.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                p = Server.MapPath("Upload" + "\\") + filename;
                lbl.Text = p;
                FileUpload1.SaveAs(Server.MapPath("Upload" + "\\") + filename);
                string ext = Path.GetExtension(p);
                switch (ext)
                {
                    case ".doc":
                          break;

                    case ".docx":
                           break;
                    default:
                           break;
                }

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
