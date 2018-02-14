<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Zadatak71.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>



        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlKomercialist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlKomercialist_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlRacun" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlRacun_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Kartica: "></asp:Label>
                    <asp:Label ID="txtKartica" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnDeleteRacun" runat="server" OnClick="btnDeleteRacun_Click" Text="Delete Racun" />
                </td>
                <td>
                    <asp:Button ID="btnUpdateKupac" runat="server" OnClick="btnUpdateKupac_Click" Text="UpdateKupac" />
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="hideKupacID" runat="server" />
    </form>
</body>
</html>
