<%@ Page Language="C#" MasterPageFile="~/SeekMasterPage.master" AutoEventWireup="true" CodeFile="Viewseekedu.aspx.cs" Inherits="Viewseekedu" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br />
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanelEdu" runat="server">
    <ContentTemplate>
   
    <table align="center" width="60%">
    
    <tr>
    <td>
    <fieldset>
    <legend style="font-size: x-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; color: #000000">EDUCATIONAL INFO</legend>
    
    <br /><br /><br />
    
    <table align="center" width="60%">
    <tr>
    <td><asp:Label ID="lblmanedu" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblHQ" runat="server" Text="Highest Qualification :" 
            Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
    <td><asp:DropDownList ID="DDLHQ" runat="server" AppendDataBoundItems="True" 
            AutoPostBack="True" DataSourceID="SqlDataSource1" 
            DataTextField="User_HQualification" DataValueField="PK_HQualification_ID" 
            OnSelectedIndexChanged="DDLHQ_SelectedIndexChanged">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_HQualification_ID], [User_HQualification] FROM [tblseekHQ]">
        </asp:SqlDataSource>
        </td>
        <td><asp:Label ID="lblReqHq" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
   
    <tr>
    <td><asp:Label ID="lblmanDeg" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblDegree" runat="server" Text="Degree :" Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
    <td><asp:DropDownList ID="DDLDegree" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource2" DataTextField="User_Degree" 
            DataValueField="PK_Degree_ID" 
            OnSelectedIndexChanged="DDLDegree_SelectedIndexChanged" 
            AutoPostBack="True">
        <asp:ListItem Value="0" Selected="True">--Select--</asp:ListItem>
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_Degree_ID], [User_Degree], [FK_HQualification_ID] FROM [tblseekDegree] WHERE ([FK_HQualification_ID] = @FK_HQualification_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDLHQ" Name="FK_HQualification_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </td>
        <td><asp:Label ID="lbldeg" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
    
    <tr>
    <td><asp:Label ID="lblmancourse" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblCourse" runat="server" Text="Course :" Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
    <td><asp:DropDownList ID="DDLCourse" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource3" DataTextField="Course_Name" 
            DataValueField="PK_Course_ID" 
           OnSelectedIndexChanged="DDLCourse_SelectedIndexChanged">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_Course_ID], [Course_Name], [FK_Degree_ID] FROM [tblseekCourse] WHERE ([FK_Degree_ID] = @FK_Degree_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDLDegree" Name="FK_Degree_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </td>
        <td><asp:Label ID="lblcou" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
    
    
   
        
    <tr>
    <td><asp:Label ID="lblmanuni" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblUniversity" runat="server" Text="University :" 
            Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
    <td><asp:DropDownList ID="DDLUniversity" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource4" 
            DataTextField="User_University" DataValueField="PK_University_ID" 
            OnSelectedIndexChanged="DDLUniversity_SelectedIndexChanged" 
            AutoPostBack="True">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_University_ID], [User_University] FROM [tblseekUniversity]">
        </asp:SqlDataSource>
        </td>
        <td><asp:Label ID="lblUni" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
    
    <tr>   
    <td><asp:Label ID="lblmanIns" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblIns" runat="server" Text="Institute :" Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
    <td>
        <asp:DropDownList ID="DDLIns" runat="server" DataSourceID="SqlDataSource6" 
            DataTextField="User_College" DataValueField="PK_College_ID" 
            onselectedindexchanged="DDLIns_SelectedIndexChanged" 
            AppendDataBoundItems="True">
            <asp:ListItem Value="0">--Select--</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_College_ID], [User_College], [FK_University_ID] FROM [tblseekCollege] WHERE ([FK_University_ID] = @FK_University_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDLUniversity" Name="FK_University_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </td>
    <td><asp:TextBox ID="txtothers" runat="server" ></asp:TextBox></td>
    <td><asp:Label ID="lblIns1" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
    
    <tr>
    <td><asp:Label ID="lblmanyop" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblyop" runat="server" Text="Year Of Passing :" Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
    <td><asp:DropDownList ID="DDLYop" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource5" DataTextField="Year" 
            DataValueField="PK_Yearid" 
            onselectedindexchanged="DDLYop_SelectedIndexChanged">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_Yearid], [Year] FROM [tblYearOfPassing]">
        </asp:SqlDataSource>
        </td>
        <td><asp:Label ID="lblyear" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
    
    <tr>
    <td></td>
    <td><asp:Label ID="lblCerticou" runat="server" Text="Certifiction Course :" 
            Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" ></asp:Label></td>
    <td><asp:TextBox ID="txtcerticou" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
    <td><asp:Label ID="lblmantype" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lbltype" runat="server" Text="Fresher/Experienced :" 
            Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large"></asp:Label></td>
            
     <td><asp:RadioButton ID="Fresher" runat="server" GroupName="F/E" Text="Fresher"/>      
           <asp:RadioButton ID="Experienced" runat="server" GroupName="F/E" Text="Experienced"/>
     </td>
     <td><asp:Label ID="lbltype1" runat="server" Forecolor="Red"></asp:Label></td>
    </tr>
   </table>
    
    <table align="right">
      <tr> 
       <td>
         <p align="center">
             <asp:Button ID="btneduedit" runat="server" Text="Edit" onclick="btneduedit_Click" 
                 />
         </p>
         </td>
         <td>
         <p align="center">
             <asp:Button ID="btnupdate" runat="server" Text="Update" onclick="btnupdate_Click" 
                  />
         </p>
         </td>
         <td>
          <p align="center">
             <asp:Button ID="Btncancel" runat="server" Text="Cancel" onclick="Btncancel_Click" 
                 />
         </p>
         </td>
        
      </tr>
    </table>
    <br /><br /><br />
    </fieldset>
    </td>
    </tr>
    </table>   
     
    </ContentTemplate>
    </asp:UpdatePanel>
     
    <br /><br /><br /><br />

</asp:Content>

