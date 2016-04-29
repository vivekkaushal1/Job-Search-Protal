<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Signup_Personal.aspx.cs" Inherits="Signup_Personal" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="Iseek_StyleSheet%20for%20jquery.css" rel="stylesheet" type="text/css" />
    <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
    
    
    <br /> <br /><br /> <br />
          
       <table align="center" width="60%">
       <tr>
       <td>
       <fieldset>
       <legend style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: bold; font-style: normal; color: #000000">PERSONAL INFORMATION</legend>
       <asp:ScriptManager ID="ScriptManager1" runat="server">
       </asp:ScriptManager>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate> 
       <br /><br />
       <table align="center" width="60%">
      
<%--Date Of Birth--%>
       <tr>
       <td><asp:Label ID="lblmanDate" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
       <td><asp:Label ID="lbldate" runat="server"  Text="Date Of  Birth" Font-Bold="True" 
               Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
       <td><asp:TextBox ID="txtdate" runat="server" ValidationGroup="per" MaxLength="20" ></asp:TextBox></td>
           
       <td><asp:RequiredFieldValidator ID="Reqdate" runat="server" 
               ControlToValidate="txtdate" Display="Dynamic" 
               ErrorMessage="Date is Required" ValidationGroup="per">*</asp:RequiredFieldValidator>
           
           <cc1:CalendarExtender ID="txtdate_CalendarExtender" runat="server" 
               Enabled="True" TargetControlID="txtdate">
           </cc1:CalendarExtender>
           
           <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlToValidate="txtdate" Display="Dynamic" 
            ControlExtender="txtdate_MaskedEditExtender" EmptyValueMessage="Date Required"
            InvalidValueMessage="Date is not valid" IsValidEmpty="False"></cc1:MaskedEditValidator>
           
           <cc1:MaskedEditExtender ID="txtdate_MaskedEditExtender" runat="server" 
               TargetControlID="txtdate" MaskType="Date" Mask="99/99/9999" CultureName="en-GB" >
           </cc1:MaskedEditExtender></td>
         </tr> 
     
<%--Gender--%>
       
       <tr>
       <td><asp:Label ID="lblmangen" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
       <td><asp:Label ID="lblGender" runat="server" Text="Gender : " Font-Bold="True" 
               Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
       <td><asp:RadioButton ID="Male" runat="server" GroupName="Gender" Text="Male"/>      
           <asp:RadioButton ID="Female" runat="server" GroupName="Gender" Text="Female"/>
       </td>
       <td>
           <asp:Label ID="lblcheck" runat="server" ForeColor="Red"></asp:Label></td>
       </tr>       
     
<%-- Nationality--%>
    
    <tr>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <td><asp:Label ID="lblmannationality" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lblNationality" runat="server" Text="Nationality : " 
            Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" 
            ForeColor="Black"></asp:Label></td>
    
    <td><asp:DropDownList ID="DDLNationlality" runat="server" AppendDataBoundItems="True" 
            AutoPostBack="True" DataSourceID="SqlDataSource1" 
            DataTextField="User_Nationality" DataValueField="PK_Nationality_ID" OnSelectedIndexChanged="DDLNationlality_SelectedIndexChanged">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_Nationality_ID], [User_Nationality] FROM [tblseekNationality]">
        </asp:SqlDataSource></td>
    
    <td>
        <asp:Label ID="lblNation" runat="server" ForeColor="Red" ></asp:Label><asp:RequiredFieldValidator ID="Reqnationality" runat="server" 
        ErrorMessage="Select ur Nationality" Text="*" ControlToValidate="DDLNationlality" ValidationGroup="per" Display="Dynamic"></asp:RequiredFieldValidator>
    </td>
    </tr>    
     
    
<%--State--%>
        
    <tr>
    <td><asp:Label ID="lblmanstate" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lblState" runat="server" Text="State : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
    <td><asp:DropDownList ID="DDLState" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource2" DataTextField="User_State" 
            DataValueField="PK_State_ID" OnSelectedIndexChanged="DDLState_SelectedIndexChanged">
        <asp:ListItem Value="0">--Selelct--</asp:ListItem>
    </asp:DropDownList>       
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:JobportalConnectionString %>" 
            SelectCommand="SELECT [PK_State_ID], [User_State], [FK_Nationality_ID] FROM [tblseekState1] WHERE ([FK_Nationality_ID] = @FK_Nationality_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDLNationlality" Name="FK_Nationality_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </td>
    <td> 
        <asp:Label ID="lblreqState" runat="server" ForeColor="Red"></asp:Label><asp:RequiredFieldValidator ID="Reqstate" runat="server" 
        ErrorMessage="Select A City" ControlToValidate="DDLState" Text="*" Display="Dynamic" ValidationGroup="per"></asp:RequiredFieldValidator>
    </td>
       </ContentTemplate>
       </asp:UpdatePanel>
    </tr>        
  
<%-- City--%>
    
    <tr>
    <td><asp:Label ID="lblmancity" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lblcity" runat="server" Text="City : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
    <td><asp:TextBox ID="txtcity" runat="server" ValidationGroup="per" MaxLength="25"></asp:TextBox></td>
    <td><asp:RequiredFieldValidator ID="Reqcity" runat="server" 
         ErrorMessage="City Required" ControlToValidate="txtcity" 
         Text="*" ValidationGroup="per" Display="Dynamic"></asp:RequiredFieldValidator></td>
    <td><asp:RegularExpressionValidator ID="Regcity" runat="server" 
         ErrorMessage="Enter a valid City" ControlToValidate="txtcity" 
        Text="Enter a valid City" ValidationGroup="per" Display="Dynamic" 
        ValidationExpression="[a-zA-Z\s]+"></asp:RegularExpressionValidator></td>
       
     </tr>
   
<%--Contact--%>
    
    <tr>
    <td><asp:Label ID="lblmancontact" runat="server" ForeColor="Red" Text="*"></asp:Label></td>
    <td><asp:Label ID="lblContact" runat="server" Text="Contact No : " Font-Bold="True" 
            Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="Black"></asp:Label></td>
    <td><asp:TextBox ID="txtContact" runat="server" MaxLength="10"></asp:TextBox></td>
    <td><asp:RequiredFieldValidator ID="Reqcontact" runat="server" 
          ErrorMessage="Mobile No,. required" Text="*" ValidationGroup="per" ControlToValidate="txtcontact" 
          Display="Dynamic"></asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="Regcontact" runat="server" 
         ErrorMessage="Enter Only numeric Values" ControlToValidate="txtcontact" 
        Text="Enter a 10 digit Numeric values" Display="Dynamic" 
          ValidationExpression="\d{10}" ValidationGroup="per"></asp:RegularExpressionValidator></td>
    </tr>     
    </table> 
   
    <br /><br />
    
<%--Save--%>
    <table align="right">
    <tr><td>
    <p align="right">
    <asp:Button ID="BtnSave" runat="server" Text="Save&Proceed" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="BtnSave_Click" />
    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="BtnCancel_Click"  />
            
    </p>
    </td></tr>
    </table>
    
    <table align="center">
     <tr>
       <td><p align="center">&nbsp;<asp:ValidationSummary ID = "ValPersonal" runat = "server"
         HeaderText = "Mentioned Fields are Must: ">
		</asp:ValidationSummary>
           <p>
           </p>
           <asp:Label ID="lblSum" runat="server"></asp:Label>
           </p>
       </td>
      </tr>
    </table>
  
    </ContentTemplate>
    </asp:UpdatePanel>
    </fieldset>
    </td>
    </tr>
    </table>
    <br /><br /><br /><br />
  
</asp:Content>








