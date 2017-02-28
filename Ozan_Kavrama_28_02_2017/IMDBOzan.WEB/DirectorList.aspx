<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectorList.aspx.cs" Inherits="IMDBOzan.WEB.DirectorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetmen Listesi</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="background-color: darkcyan; text-align: center">Yönetmenler</h1>
            <a href="FilmList.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            &nbsp;<div class="table-responsive">
                <table class="table table-bordered table-responsive">
                    <tr>
                        <th>Yönetmen Adı</th>
                        <th>İşlem</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("DirectorName") %></td>
                                <td>
                                    <a href="AddDirector.aspx?ID=<%#Eval("DirectorID")%>" class="btn btn-warning">Düzenle</a>
                                    <a href="DirectorList.aspx?ID=<%#Eval("DirectorID")%>" class="btn btn-danger">Sil</a>
                                    <a href="FilmList.aspx?directorID=<%#Eval("DirectorID")%>" class="btn btn-info">Detaylar</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-footer">Ozan K © 2017</div>
        </div>
    </form>
</body>
</html>
