<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Resume.aspx.cs" Inherits="Resume" Title="Untitled Page" ClientTarget="DownLevel"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
     <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
     
     <br /><br /><br />    

<table align="center" width="60%">
 <tr>
   <td>
    <fieldset>
      <legend>RESUME DETAILS</legend>
      <br /><br /><br />  
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanelfp" runat="server">
          <ContentTemplate>  
   
   <table align="center" width="60%">
    
<%--Cover Letter--%>
    <tr>
      <td><asp:Label ID="lblmletter" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblcletter" runat="server" Text="Cover Letter : "></asp:Label></td>
      <td><asp:TextBox ID="txtcletter" runat="server" Height="64px" TextMode="MultiLine" 
              Width="250px" ></asp:TextBox></td>
      <td><asp:RequiredFieldValidator ID="requsername" runat="server" 
           ControlToValidate="txtcletter" Display="Dynamic" 
           ErrorMessage="Cover Letter is a must" >*</asp:RequiredFieldValidator>
      </td>
    </tr>
    
    
    
<%-- About Me--%>
    <tr>
      <td><asp:Label ID="lblmaboutme" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblaboutme" runat="server" Text="About Me : "></asp:Label></td>
      <td><asp:TextBox ID="txtaboutme" runat="server" Height="64px" TextMode="MultiLine" 
              Width="250px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqabtme" runat="server" 
              ErrorMessage="This Field is a Must" ControlToValidate="txtaboutme" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
      </td>
    </tr> 
  
        
  <%--upload Resume--%>
   <tr>
      <td><asp:Label ID="lblres" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblupload" runat="server" Text="Upload Resume"></asp:Label></td>
      <td><asp:FileUpload ID="FileUpload1" runat="server" Height="22px" Width="250px" /></td> 
      <td><asp:Button ID="btnupload" runat="server" Text="Upload" onclick="btnupload_Click"></asp:Button></td>
   </tr>
   
   
   <tr><td></td><td></td><td align="center"><asp:Label ID="lblor" runat="server" Text="Or"></asp:Label></td></tr>
   
   <tr>
     <td></td>
     <td><asp:Label ID="lblpasteres" runat="server" Text="Paste Resume"></asp:Label></td>
     <td><asp:TextBox ID="txtpasteres" runat="server" Height="64px" TextMode="MultiLine" 
             Width="250px"></asp:TextBox></td>
   </tr>
   
   
 <%--Keyskills--%>
    <tr>
      <td><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="Label2" runat="server" Text="Key Skills : "></asp:Label></td>
      <td><asp:TextBox ID="txtskills" runat="server" Height="64px" TextMode="MultiLine" 
              Width="250px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqtxtskills" runat="server" 
              ErrorMessage="This Field is a Must" ControlToValidate="txtskills" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
      </td>
    </tr> 
  
  </table>
    
    <%--buttons--%>
    <table align="right">
      <tr>
       <td>
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" 
               onclick="btnsubmit_Click" Width="100px" />&nbsp;&nbsp;
        <asp:Button ID="btncancel" runat="server" Text="Cancel" 
                Width="100px" />
        <asp:Label ID="lblstatus" runat="server" ></asp:Label>
        <asp:Label ID="lblstatus1" runat="server" ></asp:Label>
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

<br /><br /><br />  

</asp:Content>


