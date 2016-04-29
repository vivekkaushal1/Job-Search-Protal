<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Empchangepwd.aspx.cs" Inherits="Empchangepwd" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--user-name--%>
  <table width="60%">
  <tr>
   <td>
    <fieldset>
      <legend>CHANGE---PASSWORD</legend>
      <br /><br /><br />  
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <ContentTemplate>  
   
   <table align="center" width="60%">
    <tr>
    <td><asp:Label ID="lblmuser" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblusername" runat="server" Text="Enter the UserName : "></asp:Label></td>
    <td><asp:TextBox ID="txtusername" runat="server" Width="136px"></asp:TextBox></td>
    <td><asp:RequiredFieldValidator ID="requsername" runat="server" 
        ControlToValidate="txtusername" Display="Dynamic" 
        ErrorMessage="Username is a Must" >&lt;-----</asp:RequiredFieldValidator>
    </td>
    </tr>
   
   
   <%-- exist password--%>
   
   <tr>
   <td><asp:Label ID="lblmoldpwd" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
   <td><asp:Label ID="lblOpassword" runat="server" Text="Existing Password : "></asp:Label></td>
   <td><asp:TextBox ID="txtOpassword" runat="server" TextMode="Password" MaxLength="7"></asp:TextBox></td>
    <td><asp:RequiredFieldValidator ID="reqep" runat="server" 
        ControlToValidate="txtOpassword" Display="Dynamic" 
        ErrorMessage="Enter existing password" >&lt;----</asp:RequiredFieldValidator>
    </td>
    </tr>
    
    
    <%--new password--%>
    <tr>
      <td><asp:Label ID="lblmnewpwd" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblNpassword" runat="server" Text="New Password : "></asp:Label></td>
     <td><asp:TextBox ID="txtNpassword" runat="server" TextMode="Password" MaxLength="7"></asp:TextBox>
         <cc1:PasswordStrength ID="txtNpassword_PasswordStrength" runat="server" 
             TargetControlID="txtNpassword" PreferredPasswordLength="5">
         </cc1:PasswordStrength>
        </td>
     <td><asp:RequiredFieldValidator ID="reqnp" runat="server" 
        ControlToValidate="txtNpassword" Display="Dynamic" 
        ErrorMessage="Enter the password" >&lt;-----</asp:RequiredFieldValidator></td>
    </tr>
    
    
    <%--confirmation--%>
    <tr>
     <td><asp:Label ID="lblmconfirm" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblCNpassword" runat="server" Text="Confirm Password : "></asp:Label></td>
     <td><asp:TextBox ID="txtCNpassword" runat="server" TextMode="Password" 
             MaxLength="7"></asp:TextBox>
     <td><asp:RequiredFieldValidator ID="reqcp" runat="server" ControlToValidate="txtCNpassword" Display="Dynamic" 
              ErrorMessage="Reqcnpwd" >&lt;-----</asp:RequiredFieldValidator> 
     </td>
     <td><asp:CompareValidator ID="Compconfirm" runat="server" 
             ControlToCompare="txtNpassword" ControlToValidate="txtCNpassword" 
             Display="Dynamic" ErrorMessage="Re-enter the same password"></asp:CompareValidator>
     </td>
    </tr>
    </table>
    
    <%--buttons--%>
    <table align="right">
      <tr>
       <td>
        <asp:Button ID="btnsubmit" align="right" runat="server" Text="Save" 
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

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

