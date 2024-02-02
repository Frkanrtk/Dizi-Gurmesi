<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="diziGurmesi3.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> <br /> 
    <div class="tam-orta-container">
        <div class="giris-ekrani-container">
            <div class="giris-input">
                <label for="txtEmail">E-posta:</label>
                <input type="email" runat="server" id="txtEmail" name="txtEmail" class="form-control" placeholder="E-posta adresinizi girin" required />
            </div>
            <div class="giris-input">
                <label for="txtPassword">Şifre:</label>
                <input type="password" runat="server" id="txtPassword" name="txtPassword" class="form-control" placeholder="Şifrenizi girin" required />
            </div>
            <div class="giris-input">
                <asp:Button ID="btnGirisYap2" runat="server" CssClass="btn btn-primary btn-block" Text="Giris Yap" OnClick="btnGirisYap_Click" />
            </div>
            <p>Hesabınız yok ise : </p>
            <div class="giris-input">
                <a href="register.aspx" class="btn btn-primary btn-block">Kayıt Ol</a>
            </div>
            <br />
            <br />
            <br />
            <div class="yonetici-giris text-right">
                <a href="admin.aspx" class="btn btn-danger">Yönetici Girişi</a>
            </div>
        </div>
    </div>
</asp:Content>
