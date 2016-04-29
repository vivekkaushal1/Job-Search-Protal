<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Updatevacancy.aspx.cs" Inherits="Updatevacancy" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center">
   <tr>
    <td><asp:Label ID="Label1" runat="server" Text="Major Field"></asp:Label></td>
    <td>
        <asp:DropDownList ID="DDLstream" runat="server" 
              onselectedindexchanged="DDLstream_SelectedIndexChanged" 
              AppendDataBoundItems="True" AutoPostBack="False" DataSourceID="SqlDataSource1" 
              DataTextField="Job_Field" DataValueField="PK_Job_Majorfield">
              <asp:ListItem Value="0">--Select--</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
              SelectCommand="SELECT [PK_Job_Majorfield], [Job_Field] FROM [tblfield]">
          </asp:SqlDataSource>
    </td>
   </tr>
  <tr>
    <td><asp:Label ID="Label2" runat="server" Text="Field"></asp:Label></td>
    <td><asp:TextBox ID="txtfield" runat="server"></asp:TextBox></td>
  </tr>
 <tr>
   <td><asp:Label ID="Label3" runat="server" Text="Experience"></asp:Label></td>
   <td><asp:TextBox ID="txtexp" runat="server"></asp:TextBox></td>
 </tr>
 <tr>
   <td><asp:Label ID="Label4" runat="server" Text="Location"></asp:Label></td>
   <td><asp:TextBox ID="txtloc" runat="server"></asp:TextBox></td>
 </tr>
 </table>
 
<table align="center">
 <tr>
 <td><asp:Button ID="btnproceed" runat="server" Text="Proceed" 
         onclick="btnproceed_Click" /></td>
 <td><asp:Button ID="btncancel" runat="server" Text="Cancel" 
         onclick="btncancel_Click" /></td>
 </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

