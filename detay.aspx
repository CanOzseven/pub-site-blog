<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="detay.aspx.cs" Inherits="habBlog.detay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          
    <form id="form1" runat="server">
        <div class="detay-icerik">
            <h1><asp:Label ID="lbl_Baslik" runat="server" Text="Label"></asp:Label></h1>
            <span style="background-color:burlywood;">Haber Yayınlanma Tarihi : <asp:Label ID="lbl_Tarih" runat="server" Text="Label"></asp:Label></span>
            <br />
            <span style="float:left; margin:5px; padding:5px;"> <asp:Image ID="image_Haber" runat="server" Height="260px" Width="260px"/> </span>
            <br />
           <span> <asp:Label ID="lbl_icerik" runat="server" Text="Label"></asp:Label></span>
        </div>
    </form>
         
</asp:Content>
