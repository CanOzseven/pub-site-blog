<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="habBlog.anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
            <asp:Repeater ID="rptHaber" runat="server">
                <ItemTemplate>
                    <table style="float: left" width="30%" cellspacing="0" cellpadding="16%">
                        <tr>
                            <td>
                                <br />
                               <a href="detay.aspx?id=<%# Eval ("haberID")%>" /> <img src="<%# Eval ("haberResmi") %>" style="width: 225px; height: 225px" /></a> </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <a href="detay.aspx?id=<%# Eval ("haberID")%>" style="text-decoration:none;" />
                                <span><%# Eval("haberBaslik")  %></span>
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />

                                <span> <b>Yayın Tarihi :</b>  <%# Eval("haberTarih")  %></span>
                            </td>
                        </tr>
                    </table>



                </ItemTemplate>
            </asp:Repeater>
        </td>
    </tr>
</asp:Content>
