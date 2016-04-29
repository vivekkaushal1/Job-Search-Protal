<%@ Page Language="C#" MasterPageFile="~/Iseek_MasterPage.master" AutoEventWireup="true" CodeFile="Iseek_home.aspx.cs" Inherits="Iseek_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <link href="Iseek_StyleSheet.css" rel="stylesheet" type="text/css" />
  
  <table align="center" >
   <tr>
    <td>
     <fieldset>
  
  <table align="left" >
    <tr>
     <td>
          
    <%--Images--%>
	 
    <%--Indhu Image--%>
   	<img src="images/Indhu.jpg" width="100" height="120" alt="" /> <br />
	<asp:Label ID="Label1" runat="server" Text="Name:Indhumathi.G" Font-Names="Monotype Corsiva" Font-Bold="True"></asp:Label><br />
	<asp:Label ID="Label2" runat="server" Text="SAP ID:51345192" Font-Names="Times New Roman" Font-Bold="True"></asp:Label>
    <%--End of Indhu Image--%>
     
    <br /><br />
      
      
    <%-- Indhu1 Image--%> 
    <img src="images/Indhu1.jpg" width="100" height="120" alt="" /><br />
    <asp:Label ID="Label3" runat="server" Text="Name:Indhuja.R" Font-Names="Monotype Corsiva" Font-Bold="True" ></asp:Label><br />
    <asp:Label ID="Label4" runat="server" Text="SAP ID:51345197" Font-Names="Times New Roman" Font-Bold="True"></asp:Label>
    <%--End of Indhu1 Image--%> 
    
    <br /><br />
        
    <%-- Suvi Image--%>     
	<img src="images/Suvi.jpg" width="100" height="120" alt="" /> <br />
    <asp:Label ID="Label5" runat="server" Text="Name:Suvarna.P.H" Font-Names="Monotype Corsiva" Font-Bold="True"></asp:Label><br />
    <asp:Label ID="Label6" runat="server" Text="SAP ID: 51345432" Font-Names="Times New Roman" Font-Bold="True"></asp:Label>
    <%--End of Suvi Image--%>
    
    <br /><br />
    
      </td>
     </tr>
   </table>
    <%--End of Images--%>
	  <table align="center">
	  <tr>
	  <td>
          <asp:Image ID="Image1" runat="server"  ImageUrl="images/job_search.jpg" />
	  </td>
	  </tr>
	  </table>
	<!--Login-->
	<table align="right">
	 <tr>
	  <td>
		<div>
		      <fieldset> 
                   
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanelsignin" runat="server">
                    <ContentTemplate>
                   	<legend Font-Name="Times New Roman" Font-Type="Bold">Sign-In</legend> 
                        
                      
                        <asp:RadioButton ID="Jobseeker" Text="Jobseeker" GroupName="type" runat="server" />
                        <asp:RadioButton ID="Employer" Text="Employer" GroupName="type" runat="server" />
                        <asp:Label ID="lblusertype" runat="server" ForeColor="Red"></asp:Label><br />
                        <br />
                        
                    <asp:Label ID="lblID" runat="server" Text="User ID:"></asp:Label>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>   
                                  
                    <asp:Label ID="lblpwd" runat="server" Text="Password"></asp:Label> 
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox> 
                    <br />
                    <asp:Button ID="btnsignin" runat="server" Text="SIGN IN" 
                            onclick="btnsignin_Click" />
                    <asp:Label ID="lblvalid" runat="server" ></asp:Label>
					<p><asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Forgot your password?</asp:LinkButton></p> 
                    <asp:Label ID="lblsignup" runat="server" Text="New User? Join Us Now!"></asp:Label> 
                    <asp:Button ID="btnseek" runat="server" Text="ISEEK" onclick="btnseek_Click" />
					</ContentTemplate>
					</asp:UpdatePanel>
					</fieldset>
			    </td>
			 </tr>
		 </table>
		 
		 </fieldset>
		 </td>
		 </tr>
		 </table>
		 
  
	
    <!--Login-->
   
</asp:Content>

