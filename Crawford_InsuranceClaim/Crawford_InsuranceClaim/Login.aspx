<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Crawford_InsuranceClaim.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    
</head>
<body>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <%--<script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css' media="screen" />--%>
 <form id="form1" runat="server" class="frmalg">
    <div class="container">
            <center>
                <h3>Login</h3>
            </center>

            <label for="uname"><b>Username</b></label>
            <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter Username" required="required"></asp:TextBox>
            <label for="psw"><b>Password</b></label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Enter Password" required="required"></asp:TextBox>
            <asp:Button ID="btnLogin" Text="Login" runat="server"  CssClass="lgnbtn" OnClick="btnLogin_Click" />
            <asp:Button runat="server" ID="btn_cancel" Text="Cancel" class="cnbtn" OnClick="btn_cancel_Click" />
      </div>
        <div id="dvMessage" runat="server" visible="false">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        </div>
  </form>
   
    
   

</body>
</html>
