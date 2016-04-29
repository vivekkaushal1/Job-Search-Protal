<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="ViewProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
 <table align="center" width="60%">
  <tr>
  <td>
   <fieldset>
    <legend>General Info</legend>
       <asp:ScriptManager ID="ScriptManager1" runat="server">
       </asp:ScriptManager>
    <table align="center">
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
    
    
    <%--Save--%>
    <table align="right">
    <tr><td>
    <p align="right">
    <asp:Button ID="Btnedit" runat="server" Text="Edit" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="Btnedit_Click"  />
    <asp:Button ID="Btnupdate" runat="server" Text="Update" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="Btnupdate_Click"  />
    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="BtnCancel_Click"  />
    <asp:Button ID="btnback" runat="server" Text="Back" ValidationGroup="per" 
            BackColor="Silver" Font-Bold="True" Font-Names="Times New Roman" 
            Font-Size="Medium" ForeColor="Black" onclick="btnback_Click"  />
            
    </p>
    </td></tr>
    
    
    </table>
   </fieldset>
  </td>
  </tr>
 </table>
</asp:Content>
