<%@ Page Language="C#" MasterPageFile="~/SeekMasterPage.master" AutoEventWireup="true" CodeFile="Viewrecprofile.aspx.cs" Inherits="Viewrecprofile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table>
     <tr>
      <td>
         <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label>
         <asp:Label ID="lblname" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="Label3" runat="server" Text="Contact Person"></asp:Label>
         <asp:Label ID="lblper" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="Label5" runat="server" Text="Location"></asp:Label>
         <asp:Label ID="lblloc" runat="server" ></asp:Label>
      </td>
     </tr>
     
     <tr>
      <td>
         <asp:Label ID="Label9" runat="server" Text="Contact"></asp:Label>
         <asp:Label ID="lblcontact" runat="server" ></asp:Label>
      </td>
     </tr>
     
     <tr>
      <td>
         <asp:Label ID="Label15" runat="server" Text="Website"></asp:Label>
         <asp:HyperLink ID="website" runat="server"></asp:HyperLink>
      </td>
     </tr>
    </table>
</asp:Content>

