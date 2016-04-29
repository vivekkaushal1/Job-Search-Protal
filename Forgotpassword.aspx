<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Forgotpassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table align="center">

 <%--UserName--%>
  <tr>
   <td></td>
   <td><asp:Label ID="lbluser" runat="server" Text="Username : "></asp:Label></td>
   <td><asp:TextBox ID="txxtuser" runat="server"></asp:TextBox></td>
   <td></td><td></td>
  </tr>
  
  
 <tr>
   <td></td><td></td>
   <td><asp:Label ID="Lblsecure" runat="server" Text="Secure word : "></asp:Label></td>
   <td><asp:TextBox ID="txtsecure" runat="server"></asp:TextBox></td>
  </tr>
  <%--Security Question--%>
        
    <tr>
      <td><asp:Label ID="lblmansec" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsecurity" runat="server" Text="Security Question : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:DropDownList ID="DDLssecurity" runat="server" AppendDataBoundItems="True" 
              DataSourceID="SqlDataSource1" DataTextField="Security_Ques" 
              DataValueField="PK_Security_Qn_ID" Height="20px" 
              onselectedindexchanged="DDLssecurity_SelectedIndexChanged">
          <asp:ListItem Value="0">--Select--</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
              SelectCommand="SELECT [PK_Security_Qn_ID], [Security_Ques] FROM [tblSecurityQuestion]">
          </asp:SqlDataSource>
          <asp:Label ID="lblmsgsec" runat="server" ForeColor="Red"></asp:Label>
      </td>
    </tr>   
    
       
  
<%--Answer--%>
        
    <tr>
      <td><asp:Label ID="lblmanAns" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsAns" runat="server" Text="Answer : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:TextBox ID="txtsans" runat="server" MaxLength="30" Height="20px" 
              Width="135px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqans" runat="server" 
              ErrorMessage="Answer field is Missing" ControlToValidate="txtsans" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
    </tr> 
    
    <tr>
    <td></td><td></td>
    <td>
        <asp:Button ID="Btn" runat="server" Text="Save" onclick="Btn_Click" />
    </td>
    <td>
        <asp:Button ID="Btncancel" runat="server" Text="Cancel" 
            onclick="Btncancel_Click" />
    </td>
    </tr>
    
    <tr>
    <td></td>
    <td><asp:Label ID="Label1" runat="server" Text="Your New Password Is:"></asp:Label></td>
    <td><asp:Label ID="lblPassword" runat="server" ></asp:Label></td>
    </tr>
     
 </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

