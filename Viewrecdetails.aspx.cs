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

public partial class Viewrecdetails : System.Web.UI.Page
{
    int id;
    private string[] compname = new string[50];
    private string[] cperson = new string[50];
    private string[] contact1 = new string[50];
    private string[] curl = new string[50];
    private string[] contact = new string[50];
    private string[] location = new string[50];

    protected void Page_Load(object sender, EventArgs e)
    {
        search();      
       
    }
   public void search()
   {
       Data d = new Data();
       id = Convert.ToInt32(Session["userid1"]);
       GridView1.DataSource=d.visitor(id);
       GridView1.DataBind();
       GridView1.Visible = false;

       for (int i = 0; i < GridView1.Rows.Count; i++)
       {
           Label space = new Label();
           space.Text = "&nbsp";

           LinkButton view = new LinkButton();
           view.ID = "View" + i.ToString();
           Label identity = new Label();
           Label cname = new Label();

           identity.Text = GridView1.Rows[i].Cells[0].Text;
           GridView2.DataSource = d.viewrecprofile(Convert.ToInt32(identity.Text));
           GridView2.DataBind();
           GridView2.Visible = false;
           GridView3.DataSource = d.viewvac(Convert.ToInt32(identity.Text));
           GridView3.DataBind();
           GridView3.Visible = false;
           view.Text = "View Details";
           view.Click += new EventHandler(LinkButton1_Click);

           compname[i] = GridView2.Rows[0].Cells[2].Text;
           cperson[i] = GridView2.Rows[0].Cells[3].Text;
           contact[i] = GridView2.Rows[0].Cells[4].Text;
           curl[i] = GridView2.Rows[0].Cells[10].Text;
           location[i] = GridView3.Rows[0].Cells[7].Text;
           contact1[i]=GridView3.Rows[0].Cells[11].Text;


           cname.Text = GridView2.Rows[0].Cells[2].Text;
           Place.Controls.Add(cname);
           Place.Controls.Add(space);
           Place.Controls.Add(view);

       }

   }

   protected void LinkButton1_Click(object sender, EventArgs e)
   {
       LinkButton view = (LinkButton)sender;
       string id1 = view.ID.Substring(4);

       for (int i = 0; i < GridView1.Rows.Count; i++)
       {
           if (string.Compare(id1, i.ToString()) == 0)
           {
               Session["company"] = compname[i];
               Session["person"] = cperson[i];
               Session["contact"] = contact[i];
               Session["contact1"] = contact1[i];
               Session["curl"] = curl[i];
               Session["clocation"] =location[i];
               
           }
       }
       Response.Redirect("Viewrecprofile.aspx");
   }
}
