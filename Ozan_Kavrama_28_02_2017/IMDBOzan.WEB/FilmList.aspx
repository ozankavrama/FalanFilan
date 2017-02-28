<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmList.aspx.cs" Inherits="IMDBOzan.WEB.FilmList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Listesi</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="background-color: darkcyan; text-align: center">Filmler</h1>
            <p>&nbsp;</p>
            <a href="FilmList.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <p>&nbsp;</p>
            <div class="btn-group">
                <button type="button" class="btn btn-primary">Seçenekler</button>
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                    <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="AddFilm.aspx">Film Ekle</a></li>
                    <li><a href="AddDirector.aspx">Yönetmen Ekle</a></li>
                    <li><a href="AddType.aspx">Tür Ekle</a></li>
                    <li><a href="FilmList.aspx">Film Listesi</a></li>
                    <li><a href="DirectorList.aspx">Yönetmen Listesi</a></li>
                </ul>
            </div>
            <p>&nbsp;</p>
            <table class="table table-condensed table-responsive">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="Label1" Text="Film Türü"></asp:Label></td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlType" AutoPostBack="true" OnSelectedIndexChanged="ddlType_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="Label2" Text="Yönetmen"></asp:Label></td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlDirector" AutoPostBack="true" OnSelectedIndexChanged="ddlDirector_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
            </table>
            &nbsp;<div class="table-responsive">
                <table class="table table-bordered table-responsive">
                    <tr>
                        <th>Film Adı</th>
                        <th>Yönetmen Adı</th>
                        <th>Tür</th>
                        <th>Ortalama Puan</th>
                        <th>İşlem</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("FilmName") %></td>
                                <td><%# Eval("DirectorName") %></td>
                                <td><%# Eval("TypeName") %></td>
                                <td><%# Eval("Point").ToString()=="-1"?"-":Eval("Point") %></td>
                                <td>
                                    <a href="AddFilm.aspx?ID=<%#Eval("FilmID")%>" class="btn btn-warning">Düzenle</a>
                                    <a href="FilmList.aspx?filmID=<%#Eval("FilmID")%>" class="btn btn-danger">Sil</a>
                                    <a href="FilmDetails.aspx?ID=<%#Eval("FilmID")%>" class="btn btn-info">Detaylar</a>
                                    <a href="VoteFilm.aspx?ID=<%#Eval("FilmID")%>" class="btn btn-primary">Oy Ver</a>
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
