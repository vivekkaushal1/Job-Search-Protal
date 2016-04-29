<%@ Page Language="C#" MasterPageFile="~/SeekMasterPage.master" AutoEventWireup="true" CodeFile="Searchres.aspx.cs" Inherits="Searchres" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <script type="text/javascript"> 
    function Apply() 
    { 
      alert('You have already applied for this job');
    } 
  </script> 

   <table>
   <tr>
   <td>
   <table>
    <tr>
     <td><asp:Button ID="Btnapply" runat="server" Text="Apply" 
             onclick="Btnapply_Click" /></td>
    </tr>
   </table>
   
   <fieldset>
    <legend>Summary</legend>
    <table>
     <tr>
     <td><asp:Label ID="Label1" runat="server" Text="Experience"></asp:Label></td>
     <td><asp:Label ID="lblexp" runat="server"></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label3" runat="server" Text="Location"></asp:Label></td>
     <td><asp:Label ID="lblloc" runat="server" ></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label></td>
     <td><asp:Label ID="lblqua" runat="server" ></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label7" runat="server" Text="Field"></asp:Label></td>
     <td><asp:Label ID="lblfield" runat="server"></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label2" runat="server" Text="Keyskills"></asp:Label></td>
     <td><asp:Label ID="lblskills" runat="server"></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label4" runat="server" Text="Posted Date"></asp:Label></td>
     <td><asp:Label ID="lbldate" runat="server"></asp:Label></td>
     </tr>
     </table>
     </fieldset>
     
     <table>
     <tr>
     <td><asp:Label ID="lblcprofile" runat="server" ></asp:Label></td>
     </tr>
     </table>
     
     <fieldset>
      <legend>Contact Details</legend>
     <table>
     <tr>
     <td><asp:Label ID="Label9" runat="server" Text="CompanyName"></asp:Label></td>
     <td><asp:Label ID="lblcname" runat="server" ></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label11" runat="server" Text="ContactPerson"></asp:Label></td>
     <td><asp:Label ID="lblcontact" runat="server" ></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label13" runat="server" Text="Contact No"></asp:Label></td>
     <td><asp:Label ID="lblnumber" runat="server" ></asp:Label></td>
     </tr>
     <tr>
     <td><asp:Label ID="Label15" runat="server" Text="Website"></asp:Label></td>
     <td><asp:Label ID="lblurl" runat="server"></asp:Label></td>
     </tr>
    </table>
    </fieldset>
   </td>
   </tr>
   </table> 
    
</asp:Content>

