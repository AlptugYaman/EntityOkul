<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webEntityOkul.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlSiniflar" runat="server" AutoPostBack="True" Width="120px" OnSelectedIndexChanged="ddlSiniflar_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gvOgrenciler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="476px" DataKeyNames="ID" OnSelectedIndexChanged="gvOgrenciler_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField SelectText="seç" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <EmptyDataTemplate>
                <div style="background-color:navy">
                    <font face="Verdana" size="3" color="white">Bu sınıfta öğrenci bulunmamaktadır.</font>
                </div>
            </EmptyDataTemplate>
        </asp:GridView>
        <br />
        <asp:LinkButton ID="lbtnEkle" runat="server" OnClick="lbtnEkle_Click">Yeni Öğrenci Ekle</asp:LinkButton>
        <br />
        <asp:Label ID="lblOgrenciID" runat="server"></asp:Label>
        <br />
        <asp:Panel ID="PanelEkle" runat="server" Visible="false">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Adı"></asp:Label></td>
                    <td><asp:TextBox ID="txtAdi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label8" runat="server" Text="Soyadı"></asp:Label></td>
                    <td><asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Telefon"></asp:Label></td>
                    <td><asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Adres"></asp:Label></td>
                    <td><asp:TextBox ID="txtAdres" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="TCKNo"></asp:Label></td>
                    <td><asp:TextBox ID="txtTCKNo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="ToplamTutar"></asp:Label></td>
                    <td><asp:TextBox ID="txtToplamTutar" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="TaksitSayısı"></asp:Label></td>
                    <td><asp:TextBox ID="txtTaksitSayisi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnKaydet" runat="server" OnClick="btnKaydet_Click" Text="Kaydet" />
                    </td>
                    <td>
                        <asp:Button ID="btnDegistir" runat="server" OnClick="btnDegistir_Click" Text="Değiştir" />
                        &nbsp;
                        <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" Width="61px" />
                    </td>
                </tr>               
            </table>
        </div> 
     </asp:Panel>         
    </div>
    </form>
</body>
</html>
