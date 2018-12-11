<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="habBlog.giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ana">
        <div class="bas">Admin Giriş Paneli</div>
        <form id="uye" runat="server">
            <table>
                <tr>
                    <td>Kullanıcı adı </td>
                    <td>
                        <asp:TextBox ID="kadi" runat="server" /></td>
                </tr>
                <tr>
                    <td>Şifre </td>
                    <td>
                        <asp:TextBox ID="sifre" TextMode="Password" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Giriş" OnClick="gonder"></asp:Button>

                    </td>
                </tr>
                <tr>
                    <td><a href="anasayfa.aspx">Geri Dön</a></td>
                    
                </tr>
            </table>
            <p>
                <h3><b><asp:Label ID="Label1" runat="server"></asp:Label></b></h3>
            </p>

        </form>
    </div>
    
</asp:Content>
