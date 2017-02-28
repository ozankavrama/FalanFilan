<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoteFilm.aspx.cs" Inherits="IMDBOzan.WEB.VoteFilm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oylama</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="background-color: darkcyan; text-align: center">Film Oyla</h1>
            <a href="FilmList.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered table-responsive">
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label1" runat="server" Text="Film Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmName" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label3" runat="server" Text="Puan:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEskiPuan" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label2" runat="server" Text="Sizin Puanınız:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPuan" CssClass="form-control" runat="server" TextMode="Number" min="0" max="10" step="0,5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Oy Ver" OnClick="btnKaydet_Click" />
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
