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

public partial class Viewseekjobs2 : System.Web.UI.Page
{
    public string key, loc;
    public int exp;
    private string[] cname = new string[50];
    private string[] cloc = new string[50];
    private string[] cabt = new string[50];
    private string[] cjob = new string[50];
    private string[] jobpk = new string[50];

    protected void Page_Load(object sender, EventArgs e)
    {
        search();
    }
    public void search()
    {
        key = Convert.ToString(Session["key"]);
        loc = Convert.ToString(Session["se-loc"]);
        exp = Convert.ToInt32(Session["se-exp"]);
        Data d = new Data();
        GridView1.DataSource = d.searchbtn(key,loc,exp);
        GridView1.DataBind();
        GridView1.Visible = false;

        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            Label newline = new Label();
            newline.Text = "<br/><br/>";
            Label newline1 = new Label();
            newline1.Text = "<br/>";
            Label newline2 = new Label();
            newline2.Text = "<br/>";
            Label newline3 = new Label();
            newline3.Text = "<br/>";
            LinkButton jobs = new LinkButton();
            Label comp = new Label();
            Label location = new Label();
            Label abt = new Label();

            jobpk[i] = GridView1.Rows[i].Cells[0].Text;

            jobs.Text = GridView1.Rows[i].Cells[5].Text;
            jobs.ID = "job" + i.ToString();
            cjob[i] = jobs.Text;
            jobs.Click += new EventHandler(LinkButton1_Click);
            comp.Text = GridView1.Rows[i].Cells[1].Text;
            cname[i] = comp.Text;
            location.Text = GridView1.Rows[i].Cells[7].Text;
            cloc[i] = location.Text;
            abt.Text = GridView1.Rows[i].Cells[10].Text;
            cabt[i] = abt.Text;
            PlaceHolder1.Controls.Add(jobs);
            PlaceHolder1.Controls.Add(newline1);
            PlaceHolder1.Controls.Add(comp);
            PlaceHolder1.Controls.Add(newline2);
            PlaceHolder1.Controls.Add(location);
            PlaceHolder1.Controls.Add(newline3);
            PlaceHolder1.Controls.Add(abt);
            PlaceHolder1.Controls.Add(newline);

        }


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        LinkButton jobs = (LinkButton)sender;
        string jobs1 = jobs.Text.Trim();
        string id = jobs.ID.Substring(3);
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            string jobs2 = GridView1.Rows[i].Cells[5].Text.Trim();
            if (((string.Compare(jobs1, jobs2)) == 0) && (string.Compare(id, i.ToString())) == 0)
            {
                Session["jobfield"] = jobs.Text;
                Session["cname"] = GridView1.Rows[i].Cells[1].Text;
                Session["loc"] = GridView1.Rows[i].Cells[7].Text;
            }
        }
        Response.Redirect("Searchres.aspx");
    }

}
