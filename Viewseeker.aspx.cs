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

public partial class Viewseeker : System.Web.UI.Page
{
    int id,n=0;
    int[] seekid = new int[50];
    private string[] fname = new string[50];
    private string[] degree = new string[50];
    private string[] course = new string[50];
    private string[] freshex = new string[50];
    private string[] year= new string[50];
    private string[] contact = new string[50];
    private string[] resume = new string[50];
    private string[] resurl = new string[50];


    protected void Page_Load(object sender, EventArgs e)
    {
        Data d=new Data();
        id = Convert.ToInt32(Session["eid"]);
        GridView1.DataSource = d.viewcomp(id);
        GridView1.DataBind();
        GridView1.Visible = false;
        GridView2.DataSource = d.viewjob();
        GridView2.DataBind();
        GridView2.Visible = false;
        search();
    }

    public void search()
    {
        for (int j = 0; j < GridView2.Rows.Count; j++)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                string str1=GridView1.Rows[i].Cells[0].Text.TrimEnd();
                string str2 = GridView2.Rows[j].Cells[0].Text.TrimEnd();
                string job1=GridView1.Rows[i].Cells[1].Text.TrimEnd();
                string job2=GridView2.Rows[j].Cells[1].Text.TrimEnd();
                if (string.Compare(str1,str2) == 0)
                {
                    if (string.Compare(job1,job2 ) == 0)
                    {
                        seekid[n] = Convert.ToInt32(GridView2.Rows[j].Cells[2].Text);
                        n++;
                    }
                }
            }
        }

        for (int j = 0; j < n; j++)
        {
            logic l = new logic();
            Data d = new Data();
            GridView3.DataSource = d.viewseekprofile(seekid[j]);
            GridView3.DataBind();
            l.dddegree = Convert.ToInt32(GridView3.Rows[0].Cells[3].Text);
            l.ddcourse = Convert.ToInt32(GridView3.Rows[0].Cells[4].Text);
            l.getdeg();
            l.getcou();
            fname[j] = GridView3.Rows[0].Cells[0].Text + GridView3.Rows[0].Cells[1].Text;
            contact[j] = GridView3.Rows[0].Cells[2].Text;
            degree[j] = Convert.ToString(Session["degree1"]);
            course[j] = Convert.ToString(Session["course1"]);
            freshex[j] = GridView3.Rows[0].Cells[5].Text;
            year[j] = GridView3.Rows[0].Cells[6].Text + GridView3.Rows[0].Cells[7].Text;
            resume[j]= GridView3.Rows[0].Cells[8].Text;
            resurl[j] = GridView3.Rows[0].Cells[9].Text;

            GridView3.Visible = false;
            
            Label space = new Label();
            space.Text = "&nbsp";
            
            LinkButton view = new LinkButton();
            view.ID = "View" + j.ToString();
            Label name = new Label();
           
            name.Text = GridView3.Rows[0].Cells[0].Text + GridView3.Rows[0].Cells[1].Text;
            view.Text = "View Profile";
            view.Click += new EventHandler(LinkButton1_Click);

            Place.Controls.Add(name);
            Place.Controls.Add(space);
            Place.Controls.Add(view);


        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int count = 0;
        logic l=new logic();
        LinkButton view = (LinkButton)sender;
        string id = view.ID.Substring(4);
        for (int i = 0; i < n; i++)
        {
            if (string.Compare(id,i.ToString())==0)
            {
                Session["profileid"] = seekid[i];
                Session["pname"]=fname[i];
                Session["pcontact"]=contact[i];
                Session["pdegree"]=degree[i];
                Session["pcourse"]=course[i];
                Session["pfreshex"]=freshex[i];
                Session["year"]=year[i];
                Session["resume"]=resume[i];
                Session["resurl"]=resurl[i];
                count++;
                l.userid = Convert.ToInt32(Session["eid"]);
                l.usertype = Convert.ToInt32(Session["profileid"]);
                int flag=l.fetchcount();
                if (flag == 1)
                {
                    l.userid = Convert.ToInt32(Session["eid"]);
                    l.usertype = Convert.ToInt32(Session["profileid"]);
                    l.jobcount = count;
                    l.ins_tblvis();
                }
                else
                {
                    int count1 = Convert.ToInt32(Session["count"]);
                    count = count1 + count;
                    l.userid = Convert.ToInt32(Session["eid"]);
                    l.jobcount = count;
                    l.usertype = Convert.ToInt32(Session["profileid"]);
                    l.updatevis();
                }
                
            }

          
        }
        Response.Redirect("Viewseekerprofile.aspx");
        
    }
}
