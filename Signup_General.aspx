<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Signup_General.aspx.cs" Inherits="Signup_General" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
    <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <br /> <br /><br /> <br />
          
       <table align="center" width="60%">
       <tr>
       <td>
       <center><asp:Label ID="Label1" runat="server" Text="Registration Form" Font-Bold="True" 
            Font-Names="Monotype Corsiva" Font-Size="X-Large" ForeColor="#9900CC"></asp:Label></center>
        <br /><br />     
        <p align="right">
        <asp:Label ID="lblMandatory" runat="server" Forecolor="Red" Text="* Marked Fields are Mandatory"></asp:Label>
        </p>
       <fieldset>
       <legend style="font-family: 'Times New Roman', Times, serif; font-size:large; font-weight: bold; font-style: normal; color: #000000">PERSONAL INFORMATION</legend>
       <asp:ScriptManager ID="ScriptManager1" runat="server">
       </asp:ScriptManager>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate> 
       <br /><br />
       <table align="center" width="60%">
      
<%--FirstName--%>
      <tr>
       <td><asp:Label ID="lblmanfname" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
       <td><asp:Label ID="lblfname" runat="server"  Text="First Name : " Font-Bold="True" 
               Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
       <td><asp:TextBox ID="txtsfname" runat="server" MaxLength="30" Height="20px" 
               Width="135px" ></asp:TextBox>
           <asp:RequiredFieldValidator ID="Reqfname" runat="server" 
               ControlToValidate="txtsfname" Display="Dynamic" 
               ErrorMessage="Firstname is Required" >*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="Regfname" runat="server" 
               ErrorMessage="Alphabets Only" ControlToValidate="txtsfname" 
               Display="Dynamic" ValidationExpression="[a-zA-Z\s]+">Alphabets Only</asp:RegularExpressionValidator>
       </td>
      </tr> 
     
<%--LastName--%>
       
      <tr>
       <td></td>
       <td><asp:Label ID="lblslname" runat="server"  Text="Last Name : " Font-Bold="True" 
               Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
       <td><asp:TextBox ID="txtslname" runat="server" MaxLength="30" Height="20px" 
               Width="135px" ></asp:TextBox>
           <asp:RegularExpressionValidator ID="Reglname" runat="server" 
               ErrorMessage="Alphabets Only" ControlToValidate="txtslname" 
               Display="Dynamic" ValidationExpression="[a-zA-Z\s]+">Alphabets Only</asp:RegularExpressionValidator>
       </td>
     </tr> 

<%--Email--%>
      
    <tr>
      <td><asp:Label ID="lblmanemail" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsemail" runat="server" Text="Email-ID : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:TextBox ID="txtsemail" runat="server" Height="20px" Width="135px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqemail" runat="server" 
              ErrorMessage="Email-Id is a Missing" ControlToValidate="txtsemail" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="Regemail" runat="server" 
              ErrorMessage="Valid emeil is required" ControlToValidate="txtsemail" 
              Display="Dynamic" 
              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Enter a Valid Email</asp:RegularExpressionValidator>
          
      </td>
    </tr>       

<%--Username--%>
   <tr>
    <td><asp:Label ID="lblmanuser" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lblsuser" runat="server" Text="Username : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
    <td><asp:TextBox ID="txtsuser" runat="server"  MaxLength="30" Height="20px" 
            Width="135px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Requser" runat="server" 
         ErrorMessage="Username is Required" ControlToValidate="txtsuser" 
         Text="*"  Display="Dynamic"></asp:RequiredFieldValidator></td>
        <asp:RegularExpressionValidator ID="Reguser" runat="server" 
         ErrorMessage="Username is required" ControlToValidate="txtsuser" 
        Text="Username is required" Display="Dynamic" 
        ValidationExpression="[a-zA-Z\s]+"></asp:RegularExpressionValidator></td>
       
   </tr>
  
<%--Password--%>
        
    <tr>
      <td><asp:Label ID="lblmanpwd" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblspwd" runat="server" Text="Password : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:TextBox ID="txtspwd" runat="server" MaxLength="7" TextMode="Password" 
              Height="20px" Width="135px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqpwd" runat="server" 
              ErrorMessage="Password is Missing" ControlToValidate="txtspwd" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
    </tr>        
  
  
 <%--Re-enter Password--%>
        
    <tr>
      <td><asp:Label ID="lblmanconfirm" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsconfirm" runat="server" Text="Re-enter Password : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:TextBox ID="txtsconfirm" runat="server" MaxLength="7" TextMode="Password" 
              Height="20px" Width="135px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqrepwd" runat="server" 
              ErrorMessage="Confirm ur Password" ControlToValidate="txtsconfirm" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
          <asp:CompareValidator ID="Compconfirm" runat="server" 
              ControlToCompare="txtspwd" ControlToValidate="txtsconfirm" Display="Dynamic" 
              ErrorMessage="Re-enter ur Password">Re-enter the password</asp:CompareValidator>
          
      </td>
    </tr>  
    
<%--Security Question--%>
        
    <tr>
      <td><asp:Label ID="lblmansec" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsecurity" runat="server" Text="Security Question : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:DropDownList ID="DDLssecurity" runat="server" AppendDataBoundItems="True" 
              DataSourceID="SqlDataSource1" DataTextField="Security_Ques" 
              DataValueField="PK_Security_Qn_ID" Height="20px" 
              onselectedindexchanged="DDLssecurity_SelectedIndexChanged">
          <asp:ListItem Value="0">--Select--</asp:ListItem>
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
              SelectCommand="SELECT [PK_Security_Qn_ID], [Security_Ques] FROM [tblSecurityQuestion]">
          </asp:SqlDataSource>
          <asp:Label ID="lblmsgsec" runat="server" ForeColor="Red"></asp:Label>
      </td>
    </tr>   
    
       
  
<%--Answer--%>
        
    <tr>
      <td><asp:Label ID="lblmanAns" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
      <td><asp:Label ID="lblsAns" runat="server" Text="Answer : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
      <td><asp:TextBox ID="txtsans" runat="server" MaxLength="30" Height="20px" 
              Width="135px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="Reqans" runat="server" 
              ErrorMessage="Answer field is Missing" ControlToValidate="txtsans" 
              Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
    </tr>  
    </table> 
   
    <br /><br />
    
<%--Save--%>
    <table align="right">
    <tr><td>
    <p align="right">
    <asp:Button ID="BtnSave" runat="server" Text="Save&Proceed" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="BtnSave_Click" />
    <asp:Button ID="Btncancel" runat="server" Text="Cancel"  
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="Btncancel_Click"  />
    </p>
    </td></tr>
    </table>
  
    </ContentTemplate>
    </asp:UpdatePanel>
    </fieldset>
    </td>
    </tr>
    </table>
    <br /><br /><br /><br />
</asp:Content>

