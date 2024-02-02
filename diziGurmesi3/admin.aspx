<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="diziGurmesi3.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tam-orta-container">
        <div class="giris-ekrani-container">
            <div class="giris-input">
                <label for="txtAdminID">Admin ID:</label>
                <input type="text" id="txtAdminID" name="txtAdminID" runat="server" class="form-control" placeholder="Admin ID girin" required />
            </div>
            <div class="giris-input">
                <label for="txtAdminUsername">Admin Kullanıcı Adı:</label>
                <input type="text" id="txtAdminUsername" name="txtAdminUsername" runat="server" class="form-control" placeholder="Admin kullanıcı adınızı girin" required />
            </div>
            <div class="giris-input">
                <label for="txtAdminPassword">Admin Şifre:</label>
                <input type="password" id="txtAdminPassword" name="txtAdminPassword" runat="server" class="form-control" placeholder="Admin şifrenizi girin" required />
            </div>
            <div class="giris-input">
                <asp:Button ID="btnAdminGiris" runat="server" CssClass="btn btn-danger btn-block" Text="Admin Girişi Yap" OnClick="btnAdminGiris_Click" />
            </div>
        </div>
    </div>
</asp:Content>
