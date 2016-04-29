<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Viewseeker.aspx.cs" Inherits="Viewseeker" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table>
  <tr>
  <td>
      <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>
  </td>
  <td>
      <asp:GridView ID="GridView2" runat="server">
      </asp:GridView>
  </td>
  <td>
      <asp:GridView ID="GridView3" runat="server">
      </asp:GridView>
  </td>
  <td>
      <asp:PlaceHolder ID="Place" runat="server"></asp:PlaceHolder>
  </td>
  </tr>
 </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

