<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Forgotpwd.aspx.cs" Inherits="Forgotpwd" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
    <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <br /><br /><br />    

<table align="center" width="60%">
 <tr>
   <td>
    <fieldset>
      <legend>FORGOT---PASSWORD</legend>
      <br /><br /><br />  
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanelfp" runat="server">
          <ContentTemplate>  
   
   <table align="center" width="60%">
    
<%--user-name--%>
    <tr>
    <td><asp:Label ID="lblmuser" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblusername" runat="server" Text="UserName : "></asp:Label></td>
    <td><asp:TextBox ID="txtusername" runat="server" Width="136px"></asp:TextBox></td>
    <td><asp:RequiredFieldValidator ID="requsername" runat="server" 
        ControlToValidate="txtusername" Display="Dynamic" 
        ErrorMessage="Username is a Must" >UserName is a Must</asp:RequiredFieldValidator>
    </td>
    </tr>
    
    
    
<%-- secutiry-question--%>
    <tr>
      <td><asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblsecque" runat="server" Text="SecurityQuestion : "></asp:Label></td>
      <td><asp:DropDownList ID="ddlsecque" runat="server" AppendDataBoundItems="True" 
              AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Security_Ques" 
              DataValueField="PK_Security_Qn_ID" 
              onselectedindexchanged="ddlsecque_SelectedIndexChanged" >
          <asp:ListItem Value="0">--SELECT--</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
              SelectCommand="SELECT [PK_Security_Qn_ID], [Security_Ques] FROM [tblSecurityQuestion]">
          </asp:SqlDataSource>
      </td>
      <td><asp:Label ID="lblsec" runat="server" ForeColor="Red" ></asp:Label></td>
    </tr> 
        
        
        
  <%--sec-answer--%>
   <tr>
     <td><asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblsecans" runat="server" Text="Answer : `"></asp:Label></td>
     <td><asp:TextBox ID="txtsecans" runat="server"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="reqseans" runat="server" ControlToValidate="txtsecans" Display="Dynamic" 
              ErrorMessage="Enter the Right answer">Specify ur answer</asp:RequiredFieldValidator>
     </td>
   </tr> 
  </table>
    
    <%--buttons--%>
    <table align="right">
      <tr>
       <td>
        <asp:Button ID="btnsubmit" runat="server" Text="Save" 
               onclick="btnsubmit_Click" />
       </td>
      </tr>
    </table>
       
        </ContentTemplate>
      </asp:UpdatePanel> 
      <br /><br /><br /> 
    </fieldset>
    </td>
  </tr>
</table>

<br /><br /><br />  
</asp:Content>

