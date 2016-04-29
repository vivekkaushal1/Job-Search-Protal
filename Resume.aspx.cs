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

public partial class Resume : System.Web.UI.Page
{
    string p;
    public byte[] resume = new byte[20000];
    protected void Page_Load(object sender, EventArgs e)
    {
        lblstatus.Visible = false;
        lblstatus1.Visible = false;
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        logic l = new logic();
        l.userid = (int)Session["id"];
        l.cover = txtcletter.Text;
        l.abtme = txtaboutme.Text;
        l.resume = txtpasteres.Text;
        l.url =lblstatus.Text;
        l.resume1 = resume[0];
        l.keyskills = txtskills.Text;
        l.reg_res();
        Response.Redirect("Iseek_home.aspx");

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
                lblstatus.Text = "Upload" + "\\" + filename;
                                
                Stream resumeStream = FileUpload1.PostedFile.InputStream;
                int resumeLength = FileUpload1.PostedFile.ContentLength;
                string resumeMime = FileUpload1.PostedFile.ContentType;
                string resumeName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                byte[] resumeData = new byte[resumeLength - 1];
                resumeStream.Read(resumeData, 0, resumeLength-1);
                resume= resumeData;
                        
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
