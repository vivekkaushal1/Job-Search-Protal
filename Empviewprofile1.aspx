<%@ Page Language="C#" MasterPageFile="~/EmpMasterPage.master" AutoEventWireup="true" CodeFile="Empviewprofile1.aspx.cs" Inherits="Empviewprofile1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" width="80%">
<tr>
<td>
<fieldset>
<legend>Sign-Up</legend>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate> 
      <p align="right">
       <asp:Label ID="Label7" runat="server" Text="* Marked Fields are Mandatory" ForeColor="Red"></asp:Label>
        </p> 
    
 <table align="center" width="50%">
   
<%--Company Name--%>
   <tr>
    <td><asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td>
         <asp:Label ID="lblcompname" runat="server" Text=" Company Name : "></asp:Label>
    <td><asp:TextBox ID="txtcompname" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="Reqcompname" runat="server" 
        ControlToValidate="txtcompname"
        ErrorMessage="Company Name is Missing">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="Regcompname" runat="server" ControlToValidate="txtcompname"
        ErrorMessage="Alphabets Only" ValidationExpression="[a-zA-Z\s]+" Text="Enter a valid company name" >
        </asp:RegularExpressionValidator>
    </td>
  </tr>


<%--Contact person--%>
  <tr>
    <td><asp:Label ID="lblmandatory" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td>
        <asp:Label ID="lblContactPerson" runat="server" Text=" Contact Person : "></asp:Label>
    </td>
    <td><asp:TextBox ID="txtContactPerson" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validContactPerson" runat="server" 
        Display="Dynamic" ControlToValidate="txtContactPerson"
        ErrorMessage="Contact PersonName is Missing">*</asp:RequiredFieldValidator><br />
        <asp:RegularExpressionValidator ID="validContactPersonExpression" runat="server" ControlToValidate="txtContactPerson" Display="Dynamic"
        ErrorMessage="Alphabets Only" ValidationExpression="[a-zA-Z\s]+" Text="Contact Person's name can have only alphabets" >
        </asp:RegularExpressionValidator>
        
    </td>
    </tr>

<%--Phone number--%>
  <tr>
    <td><asp:Label ID="lbl" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td>
        <asp:Label ID="lblPhNo" runat="server" Text=" Phone Number : "></asp:Label>
    </td>
    <td><asp:TextBox ID="txtPhNo" runat="server" MaxLength="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Reqphno" runat="server"  ControlToValidate="txtPhNo" Display="Dynamic"
        ErrorMessage="Phone number Missing" >*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="Regphno" 
        runat="server" ControlToValidate="txtPhNo" ValidationExpression="[0-9]+" Display="Dynamic"
        ErrorMessage="Numerics Only"></asp:RegularExpressionValidator>
    </td>
  </tr> 
  

<%--Address--%>
  <tr>
    <td><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td>
        <asp:Label ID="lblAddress" runat="server" Text=" Address : "></asp:Label>
    </td>
    <td><asp:TextBox ID="txtAddress1" runat="server" TextMode="SingleLine"></asp:TextBox>
        <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Reqaddress" runat="server" ControlToValidate="txtAddress1"
        ErrorMessage="Address is Missing" Display="Dynamic">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="Regadd1" runat="server" 
              ControlToValidate="txtAddress1" Display="Dynamic" ErrorMessage="Valid Characters Only" 
               ValidationExpression="[a-zA-Z0-9\s,.& /]+" ></asp:RegularExpressionValidator>
       <asp:RegularExpressionValidator ID="Regadd2" runat="server" 
              ControlToValidate="txtAddress2" Display="Dynamic" ErrorMessage="Valid Characters Only" 
               ValidationExpression="[a-zA-Z0-9\s,.& /]+" ></asp:RegularExpressionValidator>
       
    </td>
    </tr>
    
   
    
<%--country--%>
    <tr>
      
      <td><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td>
          <asp:Label ID="lblcountry" runat="server" Text=" Country : "></asp:Label>
      </td>
      <td><asp:DropDownList ID="ddlcountry" runat="server" 
               AppendDataBoundItems="True" AutoPostBack="True" 
              DataSourceID="SqlDataSource1" DataTextField="Empcomp_Nationality" 
              DataValueField="PK_Nationality_ID" 
              onselectedindexchanged="ddlcountry_SelectedIndexChanged" >
          <asp:ListItem Value="0">--Select--</asp:ListItem>
          </asp:DropDownList>
          
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
              SelectCommand="SELECT [PK_Nationality_ID], [Empcomp_Nationality] FROM [tblrecNationality]">
          </asp:SqlDataSource>
          <asp:Label ID="lblcou" runat="server" ForeColor="Red"></asp:Label>
          
      </td>
  </tr>

<%--state--%>
  <tr>
    <td><asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblState" runat="server" Text=" State : "></asp:Label></td>
    <td>
    <asp:DropDownList ID="ddlstate" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource2" DataTextField="Empcomp_State" 
            DataValueField="PK_State_ID" 
            onselectedindexchanged="ddlstate_SelectedIndexChanged">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_State_ID], [Empcomp_State], [FK_Nationality_ID] FROM [tblrecState] WHERE ([FK_Nationality_ID] = @FK_Nationality_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlcountry" Name="FK_Nationality_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
         <asp:Label ID="lblsta" runat="server" ForeColor="Red"></asp:Label>
    
   </td>
  </tr>
  
  
<%--city--%>
  <tr>
    <td><asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
    <td><asp:Label ID="lblcity" runat="server" Text=" City:"></asp:Label></td>
    <td><asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="ReqCity" runat="server" 
        ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="City Field is Missing" 
       >*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="Regcity" runat="server" 
        ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="specify city" 
        ValidationExpression="[a-zA-Z\s]+" ></asp:RegularExpressionValidator>
    </td>
  </tr>

<%--About Me--%>
    <tr>
      <td><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
      <td><asp:Label ID="lblAbtMe" runat="server" Text="About Me : "></asp:Label></td>
      <td><asp:TextBox ID="txtAbtMe" runat="server" TextMode="MultiLine"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqabtme" runat="server" 
              ErrorMessage="Aboutme Field is Missing" ControlToValidate="txtAbtMe" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="Regabtme" runat="server" 
              ControlToValidate="txtAbtMe" Display="Dynamic" ErrorMessage="Valid Characters Only" 
               ValidationExpression="[a-zA-Z0-9\s,.& /]+" ></asp:RegularExpressionValidator>
        </td>
    </tr>
    
    
<%--website--%>
     <tr>
       <td><asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label></td>       
       <td><asp:Label ID="lblwebsite" runat="server" Text=" Website : "></asp:Label></td>
       <td><asp:TextBox ID="txtwebsite" runat="server" ValidationGroup="suemp"></asp:TextBox>
           <asp:RequiredFieldValidator ID="Reqwebsite" runat="server" 
                ControlToValidate="txtwebsite" Display="Dynamic" 
                ErrorMessage="web-id is Missing" >*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="Reqwesite" runat="server" 
                ControlToValidate="txtwebsite" Display="Dynamic" 
                ErrorMessage="specify a proper web-id" 
                ValidationExpression="([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"></asp:RegularExpressionValidator>
       </td>
     </tr> 
   </table>
 
 <table align="right">
   <tr>
      <td>
        <asp:Button ID="btnedit" align="right" runat="server" Text="Edit" Height="27px" 
              onclick="btnedit_Click" >
        </asp:Button>
      </td>
      <td>
        <asp:Button ID="btnupdate" align="right" runat="server" Text="Update" 
              Height="27px" onclick="btnupdate_Click" >
        </asp:Button>
      </td>
      <td>  
        <asp:Button ID="btncancel" align="right" runat="server" Text="Cancel" 
              onclick="btncancel_Click">
        </asp:Button> 
      </td>
   </tr>
  </table> 
        </ContentTemplate>
        </asp:UpdatePanel> 
        </fieldset>
        </td>
        </tr>
      </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

