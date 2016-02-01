<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Adminer.Login" %>
<%@ Register assembly="Twitter.Web.Controls" namespace="Twitter.Web.Controls" tagprefix="twc" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="http://code.jquery.com/jquery.js"></script>
    <script src="content/js/bootstrap.min.js"></script>
     <!-- Bootstrap -->
    <link href="content/css/bootstrap.min.css" rel="stylesheet" media="screen" /> 
    <style type="text/css">
        body {
            padding-top: 40px;
        }
    </style>   
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">      
            <twc:Alert ID="Alert1" runat="server" AlertType="Error" Visible="false">
                <Content>
                    <strong>Erro!</strong> Verifique se introduziu correctamente o username e a password.
                </Content>
            </twc:Alert>  
            <twc:FieldSet ID="fieldSet1" runat="server" Legend="Introduza as suas credenciais">
                <Content>
                    <twc:TextBox ID="txtUsername" runat="server" PlaceHolder="Username" />
                    <twc:TextBox ID="txtPassword" runat="server" TextMode="Password" PlaceHolder="Password" />
                    <br />
                    <twc:Button ID="btnOK" runat="server" Toogle="true" Text="Entrar" ButtonSize="Default" ButtonType="Primary" OnClick="btnOK_Click" />              
                </Content>
            </twc:FieldSet>           
        </div>
    </form>
</body>
</html>
