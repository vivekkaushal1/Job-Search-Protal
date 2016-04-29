<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Viewseekerprofile.aspx.cs" Inherits="Viewseekerprofile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
     <tr>
      <td>
         <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
         <asp:Label ID="lblname" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="Label3" runat="server" Text="Degree"></asp:Label>
         <asp:Label ID="lbldeg" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="Label5" runat="server" Text="Course"></asp:Label>
         <asp:Label ID="lblcourse" runat="server" ></asp:Label>
      </td>
     </tr>
     
     <tr>
      <td>
         <asp:Label ID="Label9" runat="server" Text="Type"></asp:Label>
         <asp:Label ID="lbltype" runat="server" ></asp:Label>
      </td>
     </tr>
     
     <tr>
      <td>
         <asp:Label ID="Label15" runat="server" Text="Contact"></asp:Label>
         <asp:Label ID="lblcontact" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="lblexp1" runat="server" Text="Experience"></asp:Label>
         <asp:Label ID="lblexp" runat="server"></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="lblres1" runat="server" Text="Resume"></asp:Label>
         <asp:Label ID="lblres" runat="server" ></asp:Label>
      </td>
     </tr>
     <tr>
      <td>
         <asp:Label ID="lblresurl1" runat="server" Text="Resume"></asp:Label>
         <asp:Label ID="lblresurl" runat="server" ></asp:Label>
      </td>
     </tr>
    </table>
       
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

