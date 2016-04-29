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
using DataAccess;

/// <summary>
/// Summary description for logic
/// </summary>

namespace Business_Logic
{
    public class logic
    {


        private string _seekuser,_seekpwd;

        //General
        private int _usertype,_security,_userid;
        private string _fname,_lname,_email,_username,_password,_answer;
        
        //Personal
        private int _nationality, _state;
        private long _contact;
        private string _dob, _city,_gender;      

        //Educational
        private int _highqua, _degree, _course, _university, _college,_yop;
        private string _certification,_freshex,_collname;

        //Experience
         private string _emp1, _emp2,_exp1, _exp2,_desig1,_desig2;

        //Resume
        private string _cover, _abtme, _resume, _url,_keyskills;
        private byte _resume1;

        //Employer Insertion
        private string _compname, _contperson, _empcity, _abtemp, _compurl, _eusername, _epassword, _empaddress;
        private int _empnationality, _empstate;
        private long _number;

        private string _date;


        //Profile details
        private string _uname,_upwd,_upwd1;

        private int _ddnation, _ddstate,_ddhq,_dduni,_dddegree,_ddcourse,_ddins,_ddyear;

        private int _enation, _estate;

        //Search jobs
        private string _keyword, _field, _loc, _abtcomp,_qua,_loc1,_field1;
        private int _vacancies, _exp;

        private int _jobcount, _status, _mfield, _mfield1, _experience;

        private string _seaname;

        
        public logic()
        {
            
        }

        //Parametrized Constructor
        public logic(string seekuser,string seekpwd,int userid,int usertype,string fname,string lname,string email,string username,string password,
                     int security, string answer, string dob,string gender, int nationality, int state, string city,long contact,
                     int highqua,int degree,int course,int university,int college,string collname,int yop,string certification,string freshex,
                     string emp1, string emp2,string exp1,string exp2,string desig1,string desig2,string cover, string abtme,
                     string resume,byte resume1, string url, string keyskills, string compname,string contperson,long number,string empaddress,int empnationality,
                     int empstate,string empcity,string abtemp,string compurl,string eusername, string epassword,string uname,string upwd,string upwd1,int ddnation,int ddstate,int ddhq,
                     int dddegree,int ddcourse,int ddins,int year,int dduni,int enation,int estate,string keyword,string field,string loc,string abtcomp,string qua,int vacancies,int exp,
                     int jobcount,int status,int mfield,int mfield1,string loc1,int experience,string field1,string seaname,string date)

        {


            _ddnation = ddnation;
            _ddstate = ddstate;
            _ddhq = ddhq;
            _dddegree = dddegree;
            _ddcourse = ddcourse;
            _dduni = dduni;
            _ddins = ddins;
            _ddyear = ddyear;

            _date = date;


            _keyword = keyword;
            _field = field;
            _field1 = field1;
            _loc = loc;
            _loc1 = loc1;
            _qua = qua;
            _vacancies = vacancies;
            _exp = exp;
            _abtcomp = abtcomp;

            _jobcount = jobcount;
            _status = status;
            _mfield = mfield;
            _mfield1 = mfield1;
            _seaname = seaname;
            _experience = experience;


            _enation = enation;
            _estate = estate;
            //ViewProfile
            _uname = uname;
            _upwd = upwd;
            _upwd1 = upwd1;
            
            
            
            _seekuser =seekuser;
            _seekpwd =seekpwd;
            
            
            //seekers Parameters
            
            _userid = userid;
            _usertype = usertype;
            _fname=fname;
            _lname=lname;
            _email=email;
            _username=username;
            _password=password;
            _security = security;
            _answer = answer;
            _dob=dob;
            _gender=gender;
            _nationality=nationality;
            _state = state;
            _city=city;
            _contact=contact;
            _highqua=highqua;
            _degree=degree;
            _course=course;
            _university = university;
            _college = college;
            _yop = yop;
            _certification =certification;
            _freshex = freshex;
            _emp1 = emp1;
            _emp2 = emp2;
            _exp1 = exp1;
            _exp2 = exp2;
            _desig1 = desig1;
            _desig2 = desig2;
            _cover=cover;
            _abtme=abtme;
            _resume=resume;
            _resume1=resume1;
            _url=url;
            _keyskills=keyskills;
          
            //End of seekers Parameters


            //Employers Parameters
            
            _compname=compname;
            _contperson=contperson;
            _number=number;
            _empaddress = empaddress;
            _empnationality=empnationality;
            _empstate=empstate;
            _empcity=empcity;
            _abtemp=abtemp;
            _compurl=compurl;
            _eusername=eusername;
            _epassword = epassword;

            //End of Employers Parameters


        }


        public int ddnation { get { return _ddnation; } set { _ddnation = value; } }
        public int ddstate { get { return _ddstate; } set { _ddstate = value; } }
        public int ddhq { get { return _ddhq; } set { _ddhq = value; } }
        public int dddegree { get { return _dddegree; } set { _dddegree = value; } }
        public int dduni { get { return _dduni; } set { _dduni = value; } }
        public int ddcourse { get { return _ddcourse; } set { _ddcourse = value; } }
        public int ddins { get { return _ddins; } set { _ddins = value; } }
        public int ddyear { get { return _ddyear; } set { _ddyear = value; } }
        public int experience { get { return _experience; } set { _experience = value; } }

        public int enation { get { return _enation; } set { _enation = value; } }
        public int estate { get { return _estate; } set { _estate = value; } }

        public string date { get { return _date; } set { _date = value; } }


        public string uname { get { return _uname; } set { _uname = value; } }
        public string upwd { get { return _upwd; } set { _upwd = value; } }
        public string upwd1 { get { return _upwd1; } set { _upwd1 = value; } }
        
        
        public string seekuser { get { return _seekuser; } set { _seekuser = value; } }
        public string seekpwd { get { return _seekpwd; } set { _seekpwd = value; } }



        public string keyword { get { return _keyword; } set { _keyword = value; } }
        public string field { get { return _field; } set { _field = value; } }
        public string field1 { get { return _field1; } set { _field1 = value; } }
        public string qua { get { return _qua; } set { _qua = value; } }
        public string loc { get { return _loc; } set { _loc = value; } }
        public string loc1 { get { return _loc1; } set { _loc1 = value; } }
        public string abtcomp { get { return _abtcomp; } set { _abtcomp = value; } }
        public int exp {get { return _exp; } set { _exp = value; }}
        public int vacancies { get { return _vacancies; } set { _vacancies = value; } }

        public int jobcount { get { return _jobcount; } set { _jobcount= value; } }
        public int status{ get { return _status; } set { _status = value; } }
        public int mfield { get { return _mfield; } set { _mfield = value; } }
        public int mfield1 { get { return _mfield1; } set { _mfield1= value; } }
        public string seaname { get { return _seaname; } set { _seaname = value; } }



        
        //seekers Parameters
       
        public int userid {get { return _userid; } set { _userid = value; }}
        public int usertype {get { return _usertype; }set { _usertype = value; }}
        public string fname {get { return _fname; }set { _fname = value; }}
        public string lname {get { return _lname; }set { _lname = value; }}
        public string email {get { return _email; }set { _email = value; }}
        public string username {get { return _username; } set { _username = value; }}
        public string password {get { return _password; }set { _password = value; }}
        public int security {get { return _security; }set { _security = value; }}
        public string answer{get { return _answer; }set { _answer = value; }}
        public string dob{get { return _dob; }set { _dob = value; }}
        public string gender{get { return _gender; }set { _gender = value; }}
        public int nationality{get { return _nationality; }set { _nationality = value; }}
        public int state {get { return _state; }set { _state = value; }}
        public string city {get { return _city; }set { _city = value; }}
        public long contact{get { return _contact; }set { _contact = value; }}
        public int highqua{get { return _highqua; }set { _highqua = value; }}
        public int degree{get { return _degree; }set { _degree = value; }}
        public int course{get { return _course; }set { _course = value; }}
        public int university{get { return _university; }set { _university = value; }}
        public int college{get { return _college; } set { _college = value; }}
        public string collname{get { return _collname; } set { _collname = value; }}
        public int yop{get { return _yop; }set { _yop = value; }}
        public string certification {get { return _certification; }set { _certification = value; }}
        public string freshex { get { return _freshex; } set { _freshex = value; } }
        public string emp1 {get { return _emp1; }set { _emp1 = value; }}
        public string emp2 {get { return _emp2; }set { _emp2 = value; }}
        public string exp1 {get { return _exp1; }set { _exp1 = value; }}
        public string exp2 {get { return _exp2; }set { _exp2 = value; }}
        public string desig1{get { return _desig1; } set { _desig1 = value; }}
        public string desig2{get { return _desig2; } set { _desig2 = value; }}
        public string cover {get { return _cover; }set { _cover = value; }}
        public string abtme{get { return _abtme; }set { _abtme = value; }}
        public string resume { get { return _resume; } set { _resume = value; } }
        public byte resume1{get { return _resume1; }set { _resume1 = value; }}
        public string url{get { return _url; }set { _url = value; }}
        public string keyskills {get { return _keyskills; }set { _keyskills = value; }}

      //End of seekers Parameters


        //Employer's Parameters
        public string compname { get { return _compname; } set { _compname = value; } }
        public string contperson { get { return _contperson; } set { _contperson = value; } }
        public long number { get { return _number; } set { _number = value; } }
        public string empaddress { get { return _empaddress; } set { _empaddress = value; } }
        public int empnationality { get { return _empnationality; } set { _empnationality = value; } }
        public int empstate { get { return _empstate; } set { _empstate = value; } }
        public string empcity { get { return _empcity; } set { _empcity = value; } }
        public string  abtemp{ get { return _abtemp; } set { _abtemp = value; } }
        public string compurl { get { return _compurl; } set { _compurl = value; } }
        public string eusername { get { return _eusername; } set { _eusername = value; } }
        public string epassword { get { return _epassword; } set { _epassword = value; } }
        //End of Employer's Parameters


        //Authentication

        public int check()
        {
            try
            {
                Data d = new Data();
                int x = d.checkuser(this._seekuser,this._seekpwd);
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int checkemp()
        {
            try
            {
                Data d = new Data();
                int x = d.checkemp(this._seekuser, this._seekpwd);
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        
        
        
        
        //Registration of seeker   
        public int reg_gen()
        {
            try
            {
                Data d = new Data();
                int x=d.insert_general(this._usertype,this._fname,this._lname,this._email,this._username,this._password,this._security,this._answer);
                return x;
            }
            catch(Exception e)
            {
                return 0;
            }
        }


        public int reg_per()
        {
            try
            {
                Data d = new Data();
                return (d.update_personal(this._userid,this._dob,this._gender,this._nationality,this._state,this._city,this._contact));
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public int reg_edu()
        {
            try
            {
                Data d = new Data();
                return (d.update_educational(this._userid,this._highqua,this._degree,this._course,this._university,this._college,this._collname,this._yop,this._certification,this._freshex));
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public int reg_res()
        {
            try
            {
                Data d = new Data();
                return (d.update_resume(this._userid,this._cover,this._abtme,this._resume,this._url,this._resume1,this._keyskills));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int reg_exp()
        {
            try
            {
                Data d = new Data();
                return (d.update_experience(this._userid,this._emp1,this._emp2,this._exp1,this._exp2,this._desig1,this._desig2));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //End of Seeker's Registration 

        //Employer's Registration
        public int reg_emp()
        {
            try
            {
                Data d = new Data();
                int x;
                x=d.insert_emp(this._usertype,this._compname,this._contperson,this._number,this._empaddress,this._empnationality,this._empstate,this._empcity,this._abtemp,this._compurl,this._eusername,this._epassword,this._seaname);
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        //End 


        public int viewprofile()
        {
            try
            {
                Data d = new Data();
                return (d.viewprofile(this._uname, this._upwd));
                
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public int viewprofile1()
        {
            try
            {
                Data d = new Data();
                return (d.viewprofile1(this._uname, this._upwd));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int nation()
        {
            try
            {
                Data d = new Data();
                return (d.getnation(this._ddnation));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int tblstate()
        {
            try
            {
                Data d = new Data();
                return (d.getstate(this._ddstate));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getempnation()
        {
            try
            {
                Data d = new Data();
                return (d.getenation(this._enation));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getempstate()
        {
            try
            {
                Data d = new Data();
                return (d.getestate(this._estate));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getdeg()
        {
            try
            {
                Data d = new Data();
                return (d.getdegree(this._dddegree));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int hq()
        {
            try
            {
                Data d = new Data();
                return (d.gethq(this._ddhq));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getcou()
        {
            try
            {
                Data d = new Data();
                return (d.getcourse(this._ddcourse));

            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int getuni()
        {
            try
            {
                Data d = new Data();
                return (d.getuniversity(this._dduni));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getins()
        {
            try
            {
                Data d = new Data();
                return (d.getcollege(this._ddins));

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getyop()
        {
            try
            {
                Data d = new Data();
                return (d.getyear(this._ddyear));

            }
            catch (Exception e)
            {
                return 0;
            }
        }



        public int updategen()
        {
            try
            {
                Data d=new Data();
                return (d.update_gen(this._userid, this._fname, this._lname, this._email, this._nationality, this._state, this._city, this._contact));
            } 
           catch (Exception e)
            {
                return 0;
            }
        }

        public int updateemp()
        {
            try
            {
                Data d = new Data();
                return (d.update_emp(this._userid,this._compname,this._contperson,this._number,this._empaddress,this._empnationality,this._empstate,this._empcity,this._abtemp,this._compurl));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int updatepwd()
        {
            try
            {
                Data d = new Data();
                return (d.update_pwd(this._uname,this._upwd,this._upwd1));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int updateepwd()
        {
            try
            {
                Data d = new Data();
                return (d.update_epwd(this._uname, this._upwd, this._upwd1));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int uploadvacancy()
        {
            try
            {
                Data d = new Data();
                return (d.ins_jobs(this._compname,this._vacancies,this._keyword,this._mfield,this._field,this._exp,this._loc,this._qua,this._keyskills,this._abtcomp,this._contact,this._userid,this._date));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int searchres()
        {
            try
            {
                Data d = new Data();
                return (d.searchresult(this._field,this.compname, this._loc));
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public int searchres1()
        {
            try
            {
                Data d = new Data();
                return (d.result(this._userid));
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int jobinfo()
        {
            try
            {
                Data d = new Data();
                return (d.jobinformation(this._jobcount,this._status,this._compname,this._field,this._loc,this._userid,this._date));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int majorsearch()
        {
            try
            {
                Data d = new Data();
                int x=(d.majorresult(this._seaname));
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int fetchvacancies()
        {
            try
            {
                Data d = new Data();
                return (d.getvacancy(this._userid,this._field,this._mfield,this._loc,this._exp));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int fetchmfield()
        {
            try
            {
                Data d = new Data();
                return (d.mfield(this._userid));
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int upd_vac()
        {
            try
            {
                Data d = new Data();
                return (d.update_jobs(this._compname,this._vacancies,this._keyword,this._mfield,this._field,this._exp,this._loc,this._qua,this._keyskills,this._abtcomp,this._contact,this._userid,this._field1,this._experience,this._loc1,this._mfield1,this._date));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int ins_tblvis()
        {
            try
            {
                Data d = new Data();
                return (d.insert_recvis(this._userid,this._jobcount,this._usertype));
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int fetchcount()
        {
            try
            {
                Data d = new Data();
                int x=(d.visitor_count(this._userid,this._usertype));
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int updatevis()
        {
            try
            {
                Data d = new Data();
                int x = (d.update_count(this._userid,this._jobcount,this._usertype));
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public int viewrec()
        {
            try
            {
                Data d = new Data();
                int x = (d.view_rec(this._userid));
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public int checkjobuser()
        {
            try
            {
                Data d = new Data();
                int x = (d.check_jobuser(this._userid));
                return x;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
           
    }
}
