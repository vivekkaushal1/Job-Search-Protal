using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Data
/// </summary>
namespace DataAccess
{
    public class Data
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adp;
        DataTable dt;

        //Establishing a SqlConnection
        public Data()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["JobportalConnectionString"].ConnectionString);
        }

       
        //Authentication
        public int checkuser(string seekuser, string seekpwd)
        {
            cmd = new SqlCommand("Select * from tblsignup where Username='"+seekuser+"' and Password='"+seekpwd+"'",conn);
            conn.Open();
            dr=cmd.ExecuteReader();
            int flag=0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("name", dr.GetValue(2));
                HttpContext.Current.Session.Add("userid1", dr.GetValue(0));
            }
            conn.Close();
            return flag;


        }
        public int checkemp(string seekuser, string seekpwd)
        {
            cmd = new SqlCommand("Select * from tblrecEmployer where Emp_Username='" + seekuser + "' and Emp_Password='" + seekpwd + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("eid", dr.GetValue(0));
                HttpContext.Current.Session.Add("ename", dr.GetValue(3));
                
            }
            conn.Close();
            return flag;


        }

        
        
        //Insertion of General Information into tblseeksignup   
        public int insert_general(int usertype,string fname, string lname, string email, string username, string password, int security, string answer)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_General";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@User_typeID", usertype);
            cmd.Parameters.AddWithValue("@F_Name", fname);
            cmd.Parameters.AddWithValue("@L_Name", lname);
            cmd.Parameters.AddWithValue("@Email_ID", email);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@FK_Security_Qn_ID", security);
            cmd.Parameters.AddWithValue("@Answer", answer);
            SqlParameter param = cmd.Parameters.AddWithValue("@PK_User_ID", 0);
            param.Direction = ParameterDirection.Output;
            int i = -1;
            conn.Open();
            i = cmd.ExecuteNonQuery();
            int newval = Convert.ToInt32(cmd.Parameters["@PK_User_ID"].Value);
            conn.Close();
            HttpContext.Current.Session.Add("id",(newval.ToString()));
            newval.ToString();
            return newval;

        }

        //Insertion of Personal Information
        public int update_personal(int userid, string dob,string gender, int nationality, int state, string city, Int64 contact)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_Personal";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@PK_User_ID", userid);
            cmd.Parameters.AddWithValue("@Date_of_Birth", dob);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@FK_Nationality_ID", nationality);
            cmd.Parameters.AddWithValue("@FK_State_ID", state);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@Contact_No", contact);

            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        //Insertion of Educational Information
        public int update_educational(int userid, int highqua, int degree, int course, int university, int college, string collname, int yop, string certification,string freshex)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_Education";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@PK_User_ID", userid);
            cmd.Parameters.AddWithValue("@FK_HQualification_ID", highqua);
            cmd.Parameters.AddWithValue("@FK_Degree_ID", degree);
            cmd.Parameters.AddWithValue("@FK_Course_ID", course);
            cmd.Parameters.AddWithValue("@FK_University_ID", university);
            cmd.Parameters.AddWithValue("@FK_College_ID", college);
            cmd.Parameters.AddWithValue("@College_Name", collname);
            cmd.Parameters.AddWithValue("@FK_Yearid", yop);
            cmd.Parameters.AddWithValue("@User_Certification", certification);
            cmd.Parameters.AddWithValue("@Freshex",freshex);

            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        //Insertion of Experience Information
        public int update_experience(int userid, string emp1, string emp2,string exp1,string exp2,string desig1,string desig2)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_Experience";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@PK_User_ID", userid);
            cmd.Parameters.AddWithValue("@User_Prev_Emp1", emp1);
            cmd.Parameters.AddWithValue("@User_Prev_Emp2", emp2);
            cmd.Parameters.AddWithValue("@User_Experience1", exp1);
            cmd.Parameters.AddWithValue("@User_Experience2", exp2);
            cmd.Parameters.AddWithValue("@User_Desig1",desig1);
            cmd.Parameters.AddWithValue("@User_Desig2", desig2);

            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        //Insertion of Resume Information
        public int update_resume(int userid, string cover, string abtme, string resume,string url,byte resume1, string keyskills)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_Resume";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@PK_User_ID", userid);
            cmd.Parameters.AddWithValue("@User_Coverletter", cover);
            cmd.Parameters.AddWithValue("@User_About", abtme);
            cmd.Parameters.AddWithValue("@User_Resume", resume);
            cmd.Parameters.AddWithValue("@Resume",resume1);
            cmd.Parameters.AddWithValue("@Resume_url", url);
            cmd.Parameters.AddWithValue("@User_Keyskills", keyskills);

            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        //Insertion of Employer Information
        public int insert_emp(int usertype,string compname, string contperson,long number,string empaddress,int empnationality,int empstate,string empcity,string abtemp,string compurl,string eusername, string epassword,string seaname)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_Employer";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@User_type", usertype);
            cmd.Parameters.AddWithValue("@Company_Name",compname);
            cmd.Parameters.AddWithValue("@Contact_Person",contperson);
            cmd.Parameters.AddWithValue("@ContactNo",number);
            cmd.Parameters.AddWithValue("@Comp_Address",empaddress);
            cmd.Parameters.AddWithValue("@FK_Nationality_ID",empnationality);
            cmd.Parameters.AddWithValue("@FK_State_ID", empstate);
            cmd.Parameters.AddWithValue("@Emp_City",empcity);
            cmd.Parameters.AddWithValue("@About_Emp",abtemp);
            cmd.Parameters.AddWithValue("@Comp_url", compurl);
            cmd.Parameters.AddWithValue("@secure",seaname);
            cmd.Parameters.AddWithValue("@Emp_Username",eusername);
            cmd.Parameters.AddWithValue("@Emp_Password",epassword);
            SqlParameter param = cmd.Parameters.AddWithValue("@PK_Emp_ID", 0);
            param.Direction = ParameterDirection.Output;
            int i = -1;
            conn.Open();
            i = cmd.ExecuteNonQuery();
            int newval = Convert.ToInt32(cmd.Parameters["@PK_Emp_ID"].Value);
            conn.Close();
            newval.ToString();
            return newval;

         }

        public int viewprofile(string uname,string upwd)
        {
            cmd = new SqlCommand("Select * from tblsignup where Username='" + uname + "' and Password='" + upwd + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("fname", dr.GetValue(2));
                HttpContext.Current.Session.Add("lname", dr.GetValue(3));
                HttpContext.Current.Session.Add("email", dr.GetValue(4));
                HttpContext.Current.Session.Add("nation",dr.GetValue(11));
                HttpContext.Current.Session.Add("state", dr.GetValue(12));        
                HttpContext.Current.Session.Add("city", dr.GetValue(13));
                HttpContext.Current.Session.Add("contact", dr.GetValue(14));
                HttpContext.Current.Session.Add("hq",dr.GetValue(15));
                HttpContext.Current.Session.Add("degree",dr.GetValue(16));
                HttpContext.Current.Session.Add("course",dr.GetValue(17));
                HttpContext.Current.Session.Add("university", dr.GetValue(18));
                HttpContext.Current.Session.Add("institute", dr.GetValue(19));
                HttpContext.Current.Session.Add("insname", dr.GetValue(20));
                HttpContext.Current.Session.Add("yop", dr.GetValue(21));
                HttpContext.Current.Session.Add("certify", dr.GetValue(22));
                HttpContext.Current.Session.Add("f/e", dr.GetValue(23));
                HttpContext.Current.Session.Add("empname", dr.GetValue(24));
                HttpContext.Current.Session.Add("emp2name", dr.GetValue(25));
                HttpContext.Current.Session.Add("exp1", dr.GetValue(26));
                HttpContext.Current.Session.Add("exp2", dr.GetValue(27));
                HttpContext.Current.Session.Add("desig1", dr.GetValue(28));
                HttpContext.Current.Session.Add("desig2", dr.GetValue(29));
                HttpContext.Current.Session.Add("cover", dr.GetValue(30));
                HttpContext.Current.Session.Add("abtme", dr.GetValue(31));
                HttpContext.Current.Session.Add("resume", dr.GetValue(32));
                HttpContext.Current.Session.Add("url", dr.GetValue(33));
                HttpContext.Current.Session.Add("keyskills", dr.GetValue(34));

               
                
            }
            conn.Close();
            return flag;


        }


         public int viewprofile1(string uname,string upwd)
        {
            cmd = new SqlCommand("Select * from tblrecEmployer where Emp_Username='" + uname + "' and Emp_Password='" + upwd + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("empid", dr.GetValue(0));
                HttpContext.Current.Session.Add("Company_Name", dr.GetValue(2));
                HttpContext.Current.Session.Add("Contact_Person", dr.GetValue(3));
                HttpContext.Current.Session.Add("ContactNo", dr.GetValue(4));
                HttpContext.Current.Session.Add("Comp_Address",dr.GetValue(5));
                HttpContext.Current.Session.Add("enation", dr.GetValue(6));        
                HttpContext.Current.Session.Add("estate", dr.GetValue(7));
                HttpContext.Current.Session.Add("ecity", dr.GetValue(8));
                HttpContext.Current.Session.Add("About_Emp",dr.GetValue(9));
                HttpContext.Current.Session.Add("Compurl",dr.GetValue(10));
             }
            conn.Close();
            return flag;


        }



        public int getnation(int value)
        {
            cmd = new SqlCommand("Select User_Nationality from tblseekNationality where PK_Nationality_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                   HttpContext.Current.Session.Add("nation1",dr.GetValue(0));
            }

            conn.Close();
            return flag;
        }


        public int getstate(int value)
        {
            cmd = new SqlCommand("Select User_State from tblseekState1 where PK_State_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                   HttpContext.Current.Session.Add("state1",dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;
        
        }

        public int getenation(int value)
        {
            cmd = new SqlCommand("Select Empcomp_Nationality from tblrecNationality where PK_Nationality_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("enation1", dr.GetValue(0));
            }

            conn.Close();
            return flag;
        }


        public int getestate(int value)
        {
            cmd = new SqlCommand("Select Empcomp_State from tblrecState where PK_State_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("estate1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }


        public int gethq(int value)
        {
            cmd = new SqlCommand("Select User_HQualification from tblseekHQ where PK_HQualification_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("hq1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }

        public int getdegree(int value)
        {
            cmd = new SqlCommand("Select User_Degree from tblseekDegree where PK_Degree_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("degree1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }


        public int getcourse(int value)
        {
            cmd = new SqlCommand("Select Course_Name from tblseekCourse where PK_Course_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("course1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }

        public int getcollege(int value)
        {
            cmd = new SqlCommand("Select User_College from tblseekCollege where PK_College_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("institute1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }

        public int getuniversity(int value)
        {
            cmd = new SqlCommand("Select User_University from tblseekUniversity where PK_University_ID='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("university1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }

        public int getyear(int value)
        {
            cmd = new SqlCommand("Select Year from tblYearOfPassing where PK_Yearid='" + value + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            if (!dr.Read())
            {
                flag = 1;

            }
            else
            {
                HttpContext.Current.Session.Add("yop1", dr.GetValue(0).ToString());
            }

            conn.Close();
            return flag;

        }

        public DataTable resume(string uname,string upwd)
        {
            cmd = new SqlCommand("Select Resume_url from tblsignup where Username='" + uname + "' and Password='" + upwd + "'", conn);
            conn.Open();
            dr=cmd.ExecuteReader();
            adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            return dt;
        }



        public int update_gen(int userid, string fname, string lname, string email,int nationality,int state,string city,long contact)
        {
            cmd = new SqlCommand("Update tblsignup set F_Name=@F_Name,L_Name=@L_Name,Email_ID=@Email_ID,FK_Nationality_ID=@FK_Nationality_ID,FK_State_ID=@FK_State_ID,City=@City,Contact_No=@Contact_No where PK_User_ID=@PK_User_ID",conn);
            cmd.Parameters.AddWithValue("@PK_User_ID", userid);
            cmd.Parameters.AddWithValue("@F_Name", fname);
            cmd.Parameters.AddWithValue("@L_Name", lname);
            cmd.Parameters.AddWithValue("@Email_ID", email);
            cmd.Parameters.AddWithValue("@FK_Nationality_ID", nationality);
            cmd.Parameters.AddWithValue("@FK_State_ID", state);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@Contact_No", contact);

            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        public int update_emp(int userid,string compname,string contperson,long  number,string empaddress,int empnationality,int empstate,string empcity,string abtemp,string compurl)
        {
            cmd = new SqlCommand("Update tblrecEmployer set Company_Name=@Company_Name,Contact_Person=@Contact_Person,ContactNo=@ContactNo,Comp_Address=@Comp_Address,FK_Nationality_ID=@FK_Nationality_ID,FK_State_ID=@FK_State_ID,Emp_City=@Emp_City,About_Emp=@About_Emp,Comp_url=@Comp_url  where PK_Emp_ID=@PK_Emp_ID", conn);
            cmd.Parameters.AddWithValue("@Company_Name", compname);
            cmd.Parameters.AddWithValue("@Contact_Person", contperson);
            cmd.Parameters.AddWithValue("@ContactNo", number);
            cmd.Parameters.AddWithValue("@Comp_Address", empaddress);
            cmd.Parameters.AddWithValue("@FK_Nationality_ID", empnationality);
            cmd.Parameters.AddWithValue("@FK_State_ID", empstate);
            cmd.Parameters.AddWithValue("@Emp_City", empcity);
            cmd.Parameters.AddWithValue("@About_Emp", abtemp);
            cmd.Parameters.AddWithValue("@Comp_url", compurl);
            cmd.Parameters.AddWithValue("@PK_Emp_ID",userid);
            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        public int update_pwd(string uname, string upwd,string upwd1)
        {
            cmd = new SqlCommand("Update tblseeksignup set Password=@Password where Username='"+uname+"' and Password='"+upwd+"'", conn);
            cmd.Parameters.AddWithValue("@Username", uname);
            cmd.Parameters.AddWithValue("@Password", upwd1);
            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int update_epwd(string uname, string upwd,string upwd1)
        {
            cmd = new SqlCommand("Update tblrecEmployer set Emp_Password=@Emp_Password where Emp_Username='"+uname+"' and Emp_Password='"+upwd+"'", conn);
            cmd.Parameters.AddWithValue("@Emp_Username", uname);
            cmd.Parameters.AddWithValue("@Emp_Password", upwd1);
            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

    public int ins_jobs(string compname,int vacancies,string keyword,int mfield,string field,int exp,string loc,string qua,string keyskills,string abtcomp,long contact,int userid,string date)
    {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Reg_jobs";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Company_Name",compname);
            cmd.Parameters.AddWithValue("@Job_Vacancies",vacancies);
            cmd.Parameters.AddWithValue("@Job_Keywords",keyword);
            cmd.Parameters.AddWithValue("@FK_Job_Majorfield",mfield);
            cmd.Parameters.AddWithValue("@Job_Field",field);
            cmd.Parameters.AddWithValue("@Job_Experience",exp);
            cmd.Parameters.AddWithValue("@Job_Location",loc);
            cmd.Parameters.AddWithValue("@Job_Qualification",qua);
            cmd.Parameters.AddWithValue("@Job_Keyskills",keyskills);
            cmd.Parameters.AddWithValue("@About_Company",abtcomp);
            cmd.Parameters.AddWithValue("@Job_Contact",contact);
            cmd.Parameters.AddWithValue("@FK_Emp_ID",userid);
            cmd.Parameters.AddWithValue("@Date",date);
            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
     
        }

    public DataTable searchjobs()
    {
        cmd = new SqlCommand("Select * from tblsearchjobs" , conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public int searchresult(string field,string compname,string loc)
    {
        cmd = new SqlCommand("Select * from tblsearchjobs where Job_Field='" + field + "' and Company_Name='"+compname+"' and Job_Location='"+loc+"'", conn);
        //cmd.Parameters.AddWithValue("@Job_Field",field);
        //cmd.Parameters.AddWithValue("@Company_Name",compname);
        //cmd.Parameters.AddWithValue("@Job_Location",loc);
        conn.Open();
        dr = cmd.ExecuteReader();
        int flag = 0;
        if (!dr.Read())
        {
            flag = 1;

        }
        else
        {
            HttpContext.Current.Session.Add("compname", dr.GetValue(1).ToString());
            HttpContext.Current.Session.Add("role", dr.GetValue(5).ToString());
            HttpContext.Current.Session.Add("experience", dr.GetValue(6).ToString());
            HttpContext.Current.Session.Add("location", dr.GetValue(7).ToString());
            HttpContext.Current.Session.Add("education", dr.GetValue(8).ToString());
            HttpContext.Current.Session.Add("skills", dr.GetValue(9).ToString());
            HttpContext.Current.Session.Add("compprofile", dr.GetValue(10).ToString());
            HttpContext.Current.Session.Add("number", dr.GetValue(11).ToString());
            HttpContext.Current.Session.Add("recid", dr.GetValue(12).ToString());
            HttpContext.Current.Session.Add("date", dr.GetValue(13).ToString());
        }

        conn.Close();
        return flag;

    }

    public int result(int userid)
    {
        cmd = new SqlCommand("Select * from tblrecEmployer where PK_Emp_ID='" + userid + "'", conn);
        conn.Open();
        dr = cmd.ExecuteReader();
        int flag = 0;
        if (!dr.Read())
        {
            flag = 1;

        }
        else
        {
            HttpContext.Current.Session.Add("personname", dr.GetValue(3).ToString());
            HttpContext.Current.Session.Add("compurl", dr.GetValue(10).ToString());
                    
        }

        conn.Close();
        return flag;

    }

    public int jobinformation(int jobcount,int status,string compname,string field,string loc,int userid,string date)
    {
        cmd = new SqlCommand("insert into tblseekJobinfo values (@User_Jobcount,@User_Status,@User_Company,@User_Comp_Location,@User_Field,@FK_User_ID,@date)", conn);
        cmd.Parameters.AddWithValue("@User_Jobcount", jobcount);
        cmd.Parameters.AddWithValue("@User_Status",status);
        cmd.Parameters.AddWithValue("@User_Company",compname);
        cmd.Parameters.AddWithValue("@User_Comp_Location",loc);
        cmd.Parameters.AddWithValue("@User_Field",field);
        cmd.Parameters.AddWithValue("@FK_User_ID", userid);
        cmd.Parameters.AddWithValue("@date",date);

        int i = -1;
        try
        {
            conn.Open();
            return i = cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            return 0;
        }
        finally
        {
            conn.Close();
        }
     }

    public int majorresult(string seaname)
    {
        cmd = new SqlCommand("Select PK_Job_Majorfield from tblfield where Job_Field='" + seaname + "'", conn);
        conn.Open();
        dr = cmd.ExecuteReader();
        int flag = 0;
        if (!dr.Read())
        {
            flag = 1;

        }
        else
        {
            flag =Convert.ToInt32(dr.GetValue(0));
            HttpContext.Current.Session.Add("mfieldid", dr.GetValue(0).ToString());
                      
        }

        conn.Close();
        return flag;

    }
   
    public DataTable searchmfield(int x)
    {
        cmd = new SqlCommand("Select * from tblsearchjobs where FK_Job_Majorfield='" + x + "'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public int getvacancy(int userid,string field,int mfield,string loc,int exp)
    {
        cmd = new SqlCommand("Select * from tblsearchjobs where FK_Emp_ID='"+userid+"' and Job_Field='"+field+"'and FK_Job_Majorfield='"+mfield+"' and Job_Location='"+loc+"' and Job_Experience='"+exp+"'" , conn);
        conn.Open();
        dr = cmd.ExecuteReader();
        int flag = 0;
        if (!dr.Read())
        {
            flag = 1;

        }
        else
        {
           
            HttpContext.Current.Session.Add("compname", dr.GetValue(1).ToString());
            HttpContext.Current.Session.Add("Vacancy", dr.GetValue(2).ToString());
            HttpContext.Current.Session.Add("keyword", dr.GetValue(3).ToString());
            HttpContext.Current.Session.Add("mfield", dr.GetValue(4));
            HttpContext.Current.Session.Add("role", dr.GetValue(5).ToString());
            HttpContext.Current.Session.Add("experience", dr.GetValue(6).ToString());
            HttpContext.Current.Session.Add("location", dr.GetValue(7).ToString());
            HttpContext.Current.Session.Add("education", dr.GetValue(8).ToString());
            HttpContext.Current.Session.Add("skills", dr.GetValue(9).ToString());
            HttpContext.Current.Session.Add("compprofile", dr.GetValue(10).ToString());
            HttpContext.Current.Session.Add("number", dr.GetValue(11).ToString());
            HttpContext.Current.Session.Add("recid", dr.GetValue(12).ToString());
        }

        conn.Close();
        return flag;

    }

    public int update_jobs(string compname, int vacancies, string keyword, int mfield, string field, int exp, string loc, string qua, string keyskills, string abtcomp, long contact, int userid,string field1,int experience,string loc1,int mfield1,string date)
    {
        cmd = new SqlCommand("Update tblsearchjobs set Company_Name=@Company_Name,Job_Vacancies=@Job_Vacancies,Job_Keywords=@Job_Keywords,FK_Job_Majorfield=@FK_Job_Majorfield,Job_Field=@Job_Field,Job_Experience=@Job_Experience,Job_Location=@Job_Location,Job_Qualification=@Job_Qualification,Job_Keyskills=@Job_Keyskills,About_Company=@About_Company,Job_Contact=@Job_Contact,Date=@Date where FK_Emp_ID='"+userid+"'and Job_Field='"+field1+"' and Job_Experience='"+experience+"' and FK_Job_Majorfield='"+mfield1+"' and Job_Location='"+loc1+"'",conn);
        cmd.Parameters.AddWithValue("@Company_Name", compname);
        cmd.Parameters.AddWithValue("@Job_Vacancies", vacancies);
        cmd.Parameters.AddWithValue("@Job_Keywords", keyword);
        cmd.Parameters.AddWithValue("@FK_Job_Majorfield", mfield);
        cmd.Parameters.AddWithValue("@Job_Field", field);
        cmd.Parameters.AddWithValue("@Job_Experience", exp);
        cmd.Parameters.AddWithValue("@Job_Location", loc);
        cmd.Parameters.AddWithValue("@Job_Qualification", qua);
        cmd.Parameters.AddWithValue("@Job_Keyskills", keyskills);
        cmd.Parameters.AddWithValue("@About_Company", abtcomp);
        cmd.Parameters.AddWithValue("@Job_Contact", contact);
        cmd.Parameters.AddWithValue("@Date",date);
        int i = -1;
        try
        {
            conn.Open();
            return i = cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            return 0;
        }
        finally
        {
            conn.Close();
        }

    }
    public int mfield(int x)
    {
        cmd = new SqlCommand("Select * from tblfield where PK_Job_Majorfield='" + x + "'", conn);
        conn.Open();
        dr = cmd.ExecuteReader();
        int flag = 0;
        if (!dr.Read())
        {
            flag = 1;

        }
        else
        {
            
            HttpContext.Current.Session.Add("mfieldname", dr.GetValue(1).ToString());

        }

        conn.Close();
        return flag;
        
    }

    public DataTable viewcomp(int userid)
    {
        cmd = new SqlCommand("Select Company_Name,Job_Field from tblsearchjobs where FK_Emp_ID='" + userid + "'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public DataTable viewjob()
    {
        cmd = new SqlCommand("Select User_Company,User_Field,FK_User_ID from tblseekJobinfo", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public DataTable viewseekprofile(int id)
    {
        cmd = new SqlCommand("Select F_Name,L_Name,Contact_No,FK_Degree_ID,FK_Course_ID,Freshex,User_Experience1,User_Experience2,User_Resume,Resume_url from tblsignup where PK_User_ID='"+id+"'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }
    public int insert_recvis(int userid, int jobcount,int usertype)
    {
        cmd = new SqlCommand("insert into tblvisitor values(@Recentvisitors,@Recentcount,@FK_User_ID)", conn);
        cmd.Parameters.AddWithValue("@Recentvisitors",userid);
        cmd.Parameters.AddWithValue("@Recentcount",jobcount);
        cmd.Parameters.AddWithValue("@FK_User_ID",usertype);
        int i = -1;
        try
        {
            conn.Open();
            return i = cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            return 0;
        }
        finally
        {
            conn.Close();
        }
    }

    public int visitor_count(int userid,int usertype)
    {
        cmd = new SqlCommand("Select Recentcount from tblvisitor where Recentvisitors= '"+userid+"'and FK_User_ID='"+usertype+"'", conn);
        int flag = 0;
        conn.Open();
        dr = cmd.ExecuteReader();
        if (!dr.Read())
        {
            flag = 1;
        }
        else
        {
            HttpContext.Current.Session.Add("count", dr.GetValue(0));
        }
        conn.Close();
        return flag;
        
    }

    public int update_count(int userid, int jobcount,int usertype)
    {
        cmd = new SqlCommand("Update tblvisitor set Recentcount='" + jobcount + "' where FK_User_ID='" + usertype+ "' and Recentvisitors='" + userid + "'", conn);
        int i = -1;
        try
        {
            conn.Open();
            return i = cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            return 0;
        }
        finally
        {
            conn.Close();
        }
    }

    public int view_rec(int userid)
    {
        cmd=new SqlCommand("Select Recentvisitors from tblvisitor where FK_User_ID='"+userid+"'",conn);
        conn.Open();
        int i = 0;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            i++;
        }
        return i;       
    }

    public DataTable visitor(int userid)
    {
        cmd = new SqlCommand("Select * from tblvisitor where FK_User_ID='"+userid+"'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }
    public DataTable viewrecprofile(int userid)
    {
        cmd = new SqlCommand("Select * from tblrecEmployer where PK_Emp_ID='" + userid + "'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }
    public DataTable viewvac(int userid)
    {
        cmd = new SqlCommand("Select * from tblsearchjobs where FK_Emp_ID='" + userid + "'", conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public int check_jobuser(int userid)
    {
        cmd = new SqlCommand("Select* from tblseekJobinfo where FK_User_ID= '" + userid + "'", conn);
        int flag = 0;
        conn.Open();
        dr = cmd.ExecuteReader();
        if (!dr.Read())
        {
            flag = 1;
        }
        conn.Close();
        return flag;
        
    }

    public DataTable searchbtn(string key, string loc, int exp)
    {
        cmd = new SqlCommand("Select * from tblsearchjobs where Job_Keywords='"+key+"' or Job_Location='"+loc+"' or Job_Experience='"+exp+"'" , conn);
        conn.Open();
        adp = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adp.Fill(dt);
        conn.Close();
        return dt;
    }

    public int forgorpwd(string username, int security, string ans)
    {
        cmd = new SqlCommand("Select F_Name from tblsignup where Username= '" + username + "' and FK_Security_Qn_ID='"+security+"' and Answer='"+ans+"'", conn);
        int flag = 0;
        conn.Open();
        dr = cmd.ExecuteReader();
        if (!dr.Read())
        {
            flag = 1;
           
        }
        else
            HttpContext.Current.Session.Add("pwd", dr.GetValue(0));
        conn.Close();
        return flag;
    }
    public int forgorpwd1(string username, string secure)
    {
        cmd = new SqlCommand("Select Emp_Username from tblrecEmployer where Emp_Username= '" + username + "' and  ='" + secure + "'", conn);
        int flag = 0;
        conn.Open();
        dr = cmd.ExecuteReader();
        if (!dr.Read())
        {
            flag = 1;
           
        }
        else
            HttpContext.Current.Session.Add("pwd1", dr.GetValue(0));
        conn.Close();
        return flag;
    }

      public int updpwd(string upwd)
      {
          
            cmd = new SqlCommand("Update tblsignup set Password=@Password where Username='"+upwd+"'", conn);
            cmd.Parameters.AddWithValue("@Username", upwd);
            cmd.Parameters.AddWithValue("@Password", upwd);
            int i = -1;
            try
            {
                conn.Open();
                return i = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        
      }

      public int updpwd1(string upwd1)
      {

          cmd = new SqlCommand("Update tblrecEmployer set Emp_Password=@Password where Emp_Username='" + upwd1 + "'", conn);
          cmd.Parameters.AddWithValue("@Username", upwd1);
          cmd.Parameters.AddWithValue("@Password", upwd1);
          int i = -1;
          try
          {
              conn.Open();
              return i = cmd.ExecuteNonQuery();
          }
          catch (Exception e)
          {
              return 0;
          }
          finally
          {
              conn.Close();
          }

      }
      public int fuser(string seekuser)
      {
          cmd = new SqlCommand("Select * from tblsignup where Username='" + seekuser + "'", conn);
          conn.Open();
          dr = cmd.ExecuteReader();
          int flag = 0;
          if (!dr.Read())
          {
              flag = 1;

          }
          conn.Close();
          return flag;


      }

      public int jobcount(int userid)
      {
          string date = System.DateTime.Now.ToString();
          cmd = new SqlCommand("Select count(*) from tblseekJobinfo where date='" + date+ "'", conn);
          conn.Open();
          dr = cmd.ExecuteReader();
          int flag = 0;
          if (!dr.Read())
          {
              flag = 1;

          }
          else
             HttpContext.Current.Session.Add("count",dr.GetValue(0));
          conn.Close();
          return flag;
      }
   }
}
