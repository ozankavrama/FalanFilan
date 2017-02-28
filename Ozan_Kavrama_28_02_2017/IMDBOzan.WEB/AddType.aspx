<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddType.aspx.cs" Inherits="IMDBOzan.WEB.AddType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tür Ekle</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="background-color: darkcyan; text-align: center">Tür Ekle</h1>
            <a href="FilmList.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered table-responsive">
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label1" runat="server" Text="Tür Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTypeName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Ekle" OnClick="btnKaydet_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
