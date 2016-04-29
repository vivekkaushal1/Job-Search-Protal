<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Uploadvacancies.aspx.cs" Inherits="Uploadvacancies" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />    

<table align="center" width="60%">
 <tr>
   <td>
    <fieldset>
      <legend>VACANCIES</legend>
      <br /><br /><br />  
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanelfp" runat="server">
          <ContentTemplate>  
   
   <table align="center" width="60%">

 <%--company-name--%>

    <tr>
      <td><asp:Label ID="lblmcomp" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblCompanyName" runat="server" Text="CompanyName:"></asp:Label></td>
      <td><asp:TextBox ID="txtCompanyName" runat="server" MaxLength="30"></asp:TextBox></td>
      <td><asp:RequiredFieldValidator ID="reqcompname" runat="server" ControlToValidate="txtCompanyName" 
               Display="Dynamic" ErrorMessage="Company Name is required" >*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="Regcompname" runat="server" 
               ControlToValidate="txtCompanyName" Display="Dynamic" 
               ErrorMessage="Enter a Valid Characters " ValidationExpression="[a-zA-Z\s]+">Enter a Valid Characters </asp:RegularExpressionValidator>
      </td>
    </tr>  
    
    
    
<%--vacancy--%>
   <tr>
     <td><asp:Label ID="lblmvacancy" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblvacancy" runat="server" Text="Vacancies:"></asp:Label></td>
     <td><asp:TextBox ID="txtvacancy" runat="server"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="reqvac" runat="server" ControlToValidate="txtvacancy" Display="Dynamic" 
              ErrorMessage="Specify the no of vacancy" >*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regvacancy" runat="server" 
             ControlToValidate="txtvacancy" Display="Dynamic" 
             ErrorMessage="Only Numeric values" ValidationExpression="\d{1}">Only Numeric values </asp:RegularExpressionValidator>
     </td>
    </tr>
    
 
 <%--key-Word--%>
    <tr>
     <td><asp:Label ID="keywrd" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblkeywrd" runat="server" Text="Keywords:"></asp:Label></td>
     <td><asp:TextBox ID="txtkeywrd" runat="server" MaxLength="150"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="Reqkeywrd" runat="server" ControlToValidate="txtkeywrd" Display="Dynamic" 
              ErrorMessage="Specify the Keywords">*</asp:RequiredFieldValidator>
     </td>
    </tr>
        
   <tr><td></td></tr>
  
  <%--Mfield--%>
    <tr>
      <td><asp:Label ID="Label1" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="Lblstream" runat="server" Text="Stream :"></asp:Label></td>
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
      <td></td>
    </tr>     
        
   <tr><td></td></tr>
 
  <%--field--%>
    <tr>
      <td><asp:Label ID="lblmfield" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblFieldName" runat="server" Text="FieldName:"></asp:Label></td>
      <td><asp:TextBox ID="txtFieldName" runat="server" MaxLength="25"></asp:TextBox></td>
      <td><asp:RequiredFieldValidator ID="reqfld" runat="server" ControlToValidate="txtFieldName" Display="Dynamic" 
               ErrorMessage="Specify field name" >*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegFieldName" runat="server" 
               ControlToValidate="txtFieldName" Display="Dynamic" 
               ErrorMessage="Enter a valid Characters " ValidationExpression="[a-zA-Z._^%$#!~@,-]+">Enter a valid Characters</asp:RegularExpressionValidator>
      </td>
    </tr>
  
  
  <%--experience--%>
    <tr>  
     <td><asp:Label ID="lblmexp" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblExp" runat="server" Text="Experience:"></asp:Label></td>
     <td><asp:TextBox ID="txtExp" runat="server"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtExp" Display="Dynamic" ErrorMessage="Specify experience " 
              >*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regexp" runat="server" 
              ControlToValidate="txtExp" Display="Dynamic" 
              ErrorMessage="Only Numeric Values" ValidationExpression="\d{1}">Only Numeric Values</asp:RegularExpressionValidator>
    
    </td>
    </tr>
    
    
    <%--location--%>
    <tr>
     <td><asp:Label ID="lblmloc" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblLoc" runat="server" Text="Location:"></asp:Label></td>
     <td><asp:TextBox ID="txtLoc" runat="server" MaxLength="20"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="reqloc" runat="server" 
              ControlToValidate="txtLoc" Display="Dynamic" ErrorMessage="Specify location" 
              >*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="Regloc" runat="server" 
              ControlToValidate="txtLoc" Display="Dynamic" ErrorMessage="Only alphabetical characters" 
              ValidationExpression="[a-zA-Z\s]+" >Only alphabetical characters </asp:RegularExpressionValidator>
    
     </td>
    </tr>
    
       
    <%--Qualification--%>
    <tr>
     <td><asp:Label ID="Label8" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblQual" runat="server" Text="Qualification:"></asp:Label></td>
     <td><asp:TextBox ID="txtQual" runat="server" MaxLength="20"></asp:TextBox></td>
      <td><asp:RequiredFieldValidator ID="reqqual" runat="server" 
               ControlToValidate="txtQual" Display="Dynamic" 
               ErrorMessage="Specify qualification needed" >*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
              ControlToValidate="txtQual" Display="Dynamic" 
              ErrorMessage="Enter the qualification needed" 
              ValidationExpression="[a-zA-Z\s\.\,]+" >Enter a Valid Qualification</asp:RegularExpressionValidator>
    
    </td>
    </tr>
    
    <%--key-skills--%>
    <tr>
     <td><asp:Label ID="lblmkeyskills" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblKeySkills" runat="server" Text="KeySkills-Required:"></asp:Label></td>
     <td><asp:TextBox ID="txtKeySkills" runat="server" MaxLength="150"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="reqks" runat="server" ControlToValidate="txtKeySkills" Display="Dynamic" 
              ErrorMessage="Specify skills needed">*</asp:RequiredFieldValidator>
     </td>
    </tr>
    
      <%--About_Company--%>
    <tr>
     <td><asp:Label ID="lblmabt" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblabtcomp" runat="server" Text="About Company : "></asp:Label></td>
     <td><asp:TextBox ID="txtabtcmp" runat="server" MaxLength="150" TextMode="MultiLine"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="Reqabtcomp" runat="server" ControlToValidate="txtabtcmp" Display="Dynamic" 
              ErrorMessage="Specify skills needed">*</asp:RequiredFieldValidator>
     </td>
    </tr>
    
    
    
     <%--Contact-Details--%>
    <tr>
     <td><asp:Label ID="lblmcontact" runat="server" Text="*"  ForeColor="Red"></asp:Label></td>
     <td><asp:Label ID="lblContact" runat="server" Text="Contact-Details:"></asp:Label></td>
     <td><asp:TextBox ID="txtContact" runat="server" MaxLength="10"></asp:TextBox></td>
     <td><asp:RequiredFieldValidator ID="reqcont" runat="server" 
              ControlToValidate="txtContact" Display="Dynamic" 
              ErrorMessage="Enter the Contact Details" >*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegContact" runat="server" 
              ControlToValidate="txtContact" Display="Dynamic" 
              ErrorMessage="Must be a 10 digit Numeric" ValidationExpression="\d{10}">Must be a 10 digit Numeric</asp:RegularExpressionValidator>
    
    </td>
    </tr> 
  </table>
    
    <%--buttons--%>
    <table align="right">
      <tr>
       <td>
        <asp:Button ID="btnsubmit" runat="server" Text="Save" 
               onclick="btnsubmit_Click" Height="32px" Width="100px" />
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

