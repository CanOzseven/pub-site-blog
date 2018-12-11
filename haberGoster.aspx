<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="haberGoster.aspx.cs" Inherits="habBlog.haberGoster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <td><h1> Haber Göster</h1></td>
    
    <asp:Repeater ID="rptHaber" runat="server" OnItemCommand="rpt_OnItemCommand" OnItemDataBound="rpt_OnItemDataBound">
        <ItemTemplate>

            <table style="display: block; background-color: #eee; border: 1px solid #ddd;">
                <tr>
                    <td>
                        <span><%# Eval("haberBaslik")  %></span>
                    </td>
                    <td>Eklenme Tarihi  <%# Eval("haberTarih") %>
                    </td>
                    <td>
                        <asp:Button ID="btn_sil" Text="Sil" CommandName="delete" CommandArgument='<%# Eval("haberID") %>' runat="server"></asp:Button>
                    </td>

                </tr>

            </table>

        </ItemTemplate>
    </asp:Repeater>
        
</asp:Content>
