<%@ Page Language="C#" MasterPageFile="~/SeekMasterPage.master" AutoEventWireup="true" CodeFile="Viewrecdetails.aspx.cs" Inherits="Viewrecdetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table align="center">
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

