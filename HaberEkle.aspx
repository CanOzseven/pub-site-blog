<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="HaberEkle.aspx.cs" Inherits="habBlog.HaberEkle" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
          <tr>
          <td><div class="baslik">
            <h1>Haber Ekle</h1>
               
              </div>
           </td>
    <div class="icerik">
          
                <table width="100%" cellspacing="0" cellpadding="0">
                    <tr>
                        <td>
                            <asp:Label ID="haberBaslik" runat="server">Haber Başlığı</asp:Label>
                            <br />
                        </td>
                      
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="haberBaslikText" runat="server" Height="23px" Width="478px"></asp:TextBox>
                            <br />
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="HaberDetay" runat="server">Haber Detay <br /></asp:Label>
                           
                        </td>
                      
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="HaberDetayText" runat="server" Height="62px" TextMode="MultiLine" Width="476px"></asp:TextBox>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="HaberResmi" runat="server">Haber Resmi</asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <br />
                            <asp:Button ID="Button1" runat="server" Text="Dosya Yükle" OnClick="Button1_Click" />
                            <br />
                          <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="CornflowerBlue"></asp:Label>
                            <br />
                        </td>
                        </tr>
                    <tr>
                        <td>
                            <br />
                            <asp:Button ID="gonder" runat="server" Text="Gönder" OnClick="gonderClick" />
                        </td>
                         
                         
                        </tr>
                     <tr>
                         <td>
                              <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="CornflowerBlue">

                            </asp:Label>
                         </td>
                     </tr>
                </table>
              
        </div> 
</td>
              </td>
          </tr>
</asp:Content>
