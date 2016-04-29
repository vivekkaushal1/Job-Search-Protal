<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Signup_Experience.aspx.cs" Inherits="Signup_Experience" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
    <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
    
   <table width="60%" align="center">
    <tr>
     <td>
    <br /><br />   
    <fieldset>
    <p align="right">
        <asp:Label ID="lblMandatory" runat="server" Forecolor="Red" Text="* Marked Fields are Mandatory"></asp:Label>
    </p>
    <legend>Work Experience</legend>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
      </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate>
   
   <br /><br />   
   <table>
    <tr>
     <td><asp:Label ID="Label5" runat="server" Forecolor="Red" Text="*"></asp:Label></td>
     <td><asp:Label ID="lblPrevEmpName" runat="server" Text="Previous Employer Name: "></asp:Label></td>
     <td align="center"><asp:Label ID="lblmon" runat="server" Text="Month"></asp:Label></td>
     <td align="center"><asp:Label ID="lblyr" runat="server" Text="Year"></asp:Label></td>
    </tr>
    
    <tr>
     <td><asp:Label ID="lblnumber1" runat="server" Text="1: "></asp:Label></td>
     <td><asp:TextBox ID="txtempname1" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Reqempname" runat="server" 
             ErrorMessage="Employer name is a Must" ControlToValidate="txtempname1" 
             Display="Dynamic">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regempname" runat="server" 
             ErrorMessage="Alphabets Only" Display="Dynamic" 
             ControlToValidate="txtempname1" ValidationExpression="[a-zA-Z\s]+">Alphabets Only</asp:RegularExpressionValidator>
        </td>
     <td><asp:TextBox ID="txtMonth1" runat="server" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="Reqmonth1" runat="server" ErrorMessage="Specify ur experience" Display="Dynamic" 
         ControlToValidate="txtMonth1">*Atleast 0</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regmonth1" runat="server" ValidationExpression="\d{1}"
             ErrorMessage="Numerics only" Display="Dynamic" ControlToValidate="txtMonth1">Numerics only</asp:RegularExpressionValidator>
         <asp:Label ID="lblmonth" runat="server" Forecolor="Red"></asp:Label>
     </td>
     <td><asp:TextBox ID="txtYear1" runat="server" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="Reqtxtyear" runat="server" ErrorMessage="Specify ur Experience" Display="Dynamic" ControlToValidate="txtYear1">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regyear1" runat="server" 
             ErrorMessage="Numerics only" ControlToValidate="txtYear1" ValidationExpression="\d{1}"
             Display="Dynamic">Numerics only</asp:RegularExpressionValidator>
         <asp:Label ID="lblyear" runat="server" Forecolor="Red" ></asp:Label>
     </td>
   </tr>
   
   <tr>
    <td><asp:Label ID="lblnumber2" runat="server" Text="2: "></asp:Label></td>
    <td><asp:TextBox ID="txtempname2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="Regempname2" runat="server" 
            ErrorMessage="Alphabets Only" ControlToValidate="txtempname2" ValidationExpression="[a-zA-Z\s]+"
            Display="Dynamic">Alphabets Only</asp:RegularExpressionValidator>
       </td>
    <td><asp:TextBox ID="txtMonth2" runat="server" ></asp:TextBox>
        <asp:RegularExpressionValidator ID="Regmonth2" runat="server" 
            ErrorMessage="Numerics Only" ControlToValidate="txtMonth2" 
            Display="Dynamic" ValidationExpression="\d{1}">Numerics only</asp:RegularExpressionValidator>
       </td>
    <td><asp:TextBox ID="txtYear2" runat="server" ></asp:TextBox>
        <asp:RegularExpressionValidator ID="Regyear2" runat="server" 
            ErrorMessage="Numerics Only" ControlToValidate="txtYear2" 
            Display="Dynamic" ValidationExpression="\d{1}">Numerics only</asp:RegularExpressionValidator>
       </td>
   </tr>
   
   
   <tr>
    <td><asp:Label ID="Label1" runat="server" Forecolor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lbldesignation" runat="server" Text="Designation: "></asp:Label></td>
   </tr>
   
   <tr>
    <td><asp:Label ID="lblnumber3" runat="server" Text="1:"></asp:Label></td>
    <td><asp:TextBox ID="txtdesignation1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Reqdesign" runat="server" 
            ErrorMessage="Designation is a Must" ControlToValidate="txtdesignation1" 
            Display="Dynamic" >*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="Regdesig" runat="server" 
            ErrorMessage="Alphabets Only" ControlToValidate="txtdesignation1" 
            Display="Dynamic" ValidationExpression="[a-zA-Z\s]+">Alphabets Only</asp:RegularExpressionValidator>
       </td>
   </tr>
   

   <tr>
     <td><asp:Label ID="lblnumber4" runat="server" Text="2:"></asp:Label></td>
     <td><asp:TextBox ID="txtdesignation2" runat="server"></asp:TextBox>
         <asp:RegularExpressionValidator ID="Regdesig2" runat="server" 
             ErrorMessage="Alphabets Only" ControlToValidate="txtdesignation2" 
             Display="Dynamic" ValidationExpression="[a-zA-Z\s]+">Alphabets Only</asp:RegularExpressionValidator>
       </td>
   </tr>
  </table>
   
   <table align="right">
      <tr>
      <td>     
        <p align="right"> 
            <asp:Button ID="btnsave" runat="server" Text="Save and Proceed" 
                OnClientClick="validator()" onclick="btnsave_Click"/> &nbsp; &nbsp;
            <asp:Button ID="btncancel" runat="server" Text="Cancel" 
                onclick="btncancel_Click" style="height: 26px" />
        </p>
      </td>
     </tr>
   </table>
        </ContentTemplate>
		</asp:UpdatePanel>
    </fieldset>
         
  <br /><br />
   </td>  
  </tr>
 </table>

</asp:Content>


