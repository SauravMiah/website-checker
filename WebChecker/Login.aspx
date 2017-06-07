<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebsiteCheckerV2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Website Checker</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="shortcut icon" href="favicon.ico" type="image/png" />
    <link rel="apple-touch-icon" href="Assets/images/apple-touch-icon-57×57.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="Assets/images/apple-touch-icon-72×72.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="Assets/images/apple-touch-icon-114×114.png" />

    <link href="Assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Assets/css/styles.css" rel="stylesheet" />
    <script src="Assets/scripts/jquery-1.9.1.js"></script>
    <script src="Assets/scripts/jquery-ui-1.11.4.min.js"></script>
    <script src="Assets/scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="pageForm" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="log-wrapper" >
            <div class="form-group">
                <a href="login" title="Home">
                    <center><img src="assets/images/Logo-EVOLANTIS-shadow.png" alt="" style="width:80%;" /></center>
                </a>
            </div>
            <div class="login-container">
                <div class="alert alert-danger" role="alert" id="logMsg" runat="server" visible="false"></div>
                <div class="form-group">
                    <label class="control-label">Username:</label>
                    <asp:TextBox ID="txtUser" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label">Password:</label>
                    <asp:TextBox ID="txtPass" CssClass="form-control" TextMode="password" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLogin" CssClass="btn btn-primary btn-block" runat="server" OnClick="btnLogin_Click" Text="Login" />
                </div>
            </div>
        </div>

    </form>
</body>
</html>
