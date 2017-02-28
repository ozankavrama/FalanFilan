<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmDetails.aspx.cs" Inherits="IMDBOzan.WEB.FilmDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Detay</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style type="text/css">
        .auto-style1 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="background-color: darkcyan; text-align: center">Film Bilgileri</h1>
            <a href="FilmList.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered table-responsive">
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label1" runat="server" Text="Film Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmName" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label2" runat="server" Text="Film Konusu:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmDescription" CssClass="auto-style1" runat="server" ReadOnly="true" TextMode="MultiLine" Height="199px" Width="850px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label3" runat="server" Text="Çıkış Tarihi:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPublishDate" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label4" runat="server" Text="Film Türü:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTypes" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label5" runat="server" Text="Yönetmen:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDirector" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <div class="panel panel-default">
            <div class="panel-footer">Ozan K © 2017</div>
        </div>
    </form>
</body>
</html>
