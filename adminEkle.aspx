<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="adminEkle.aspx.cs" Inherits="habBlog.adminEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <td><h1>Admin Ekle</h1></td>
    <div class="adminEkleStil">
         
        <table>
                <tr>
                    <td>Kullanıcı adı </td>
                    <td>
                        <asp:TextBox ID="adminKadi" runat="server" /></td>
                </tr>
                <tr>
                    <td>Şifre </td>
                    <td>
                        <asp:TextBox ID="adminsifre" TextMode="Password" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Yeni Admin Ekle" OnClick="adminEklebuton"></asp:Button>
                    </td>
                </tr>
         </table>
             <p>
                <h3><b><asp:Label ID="Label1" runat="server"></asp:Label></b></h3>
            </p>
             
    </div>
 

</asp:Content>
