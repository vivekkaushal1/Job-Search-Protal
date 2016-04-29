<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Viewjobs.aspx.cs" Inherits="Viewjobs" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
     <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
     
  <br /><br />
  <table align="center" width="60%">
    <tr>
     <td>
     <fieldset>
     <table align="left" >
      <tr>
        <td >
            <asp:Label ID="lbljobtype" runat="server" Text="Jobs In"></asp:Label>
            <asp:Label ID="lbljobtype1" runat="server" ></asp:Label>
        </td>
      </tr>
      </table>
      
      <table>
       <tr>
         <td>
             <asp:Label ID="lblview" runat="server"></asp:Label>
         </td>
       </tr>
      </table>
        
      <table align="right">
        <tr>
        <td>
            <asp:Label ID="lblwelcome" runat="server" Text="Hi!"></asp:Label>
            <asp:Label ID="lblwelcome1" runat="server" ></asp:Label>           
        </td>
      </tr>
      <tr>
        <td>
        <fieldset>
            <asp:Label ID="lblfeajob" runat="server" Text="Featured Jobs"></asp:Label>
            <asp:Label ID="lbldesc" runat="server" ></asp:Label>
            <asp:LinkButton ID="Linkjob" runat="server">View</asp:LinkButton>   
        </fieldset>       
        </td>
      </tr>
     </table>
              
     <br /><br />
     </fieldset>
     </td>
    </tr>
  </table>
  
  <br /><br /><br /><br />
    
</asp:Content>


