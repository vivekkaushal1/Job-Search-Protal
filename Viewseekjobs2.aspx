<%@ Page Language="C#" MasterPageFile="~/SeekMasterPage.master" AutoEventWireup="true" CodeFile="Viewseekjobs2.aspx.cs" Inherits="Viewseekjobs2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
 <tr>
  <td>
   
    <table align="center">
     <tr>
     <td>
         <asp:GridView ID="GridView1" runat="server">
         </asp:GridView>
         <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
         
     </td>
     </tr>
    </table>
  
  </td>
 </tr>
</table>
</asp:Content>

