<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="adminGoster.aspx.cs" Inherits="habBlog.adminGoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <td><h1>Adminler</h1></td>
    </tr></table>
    <asp:Repeater ID="rptHaber" runat="server" OnItemCommand="rpt_OnItemCommand" OnItemDataBound="rpt_OnItemDataBound">

        <ItemTemplate>

            <table style="display: block; background-color: #eee; border: 1px solid #ddd;">
                <tr>
                    <td>id : <%#Eval("kullaniciAdi") %>
                    </td>
                    <td>
                        <asp:Button ID="btn_sil" Text="Sil" CommandName="delete" CommandArgument='<%# Eval("uye_id") %>' runat="server"></asp:Button>
                    </td>
                </tr>
            </table>

        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

   