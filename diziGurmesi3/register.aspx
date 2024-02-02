<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="diziGurmesi3.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />

        <div id="registrationForm" class="col-md-6 offset-md-3">
            <div class="form-group">
                <label for="txtAdSoyad">Ad Soyad:</label>
                <input type="text" class="form-control" id="txtAdSoyad"  runat="server" placeholder="Adınız Soyadınız">
            </div>
            <div class="form-group">
                <label for="txtKullaniciAdi">Kullanıcı Adı:</label>
                <input type="text" class="form-control" id="txtKullaniciAdi" runat="server" placeholder="Kullanıcı Adınız">
            </div>
            <div class="form-group">
                <label>Cinsiyet:</label>
                <div class="form-check">
                    <input class="form-check-input" runat="server" type="radio" name="radioCinsiyet" id="radioErkek" value="erkek">
                    <label class="form-check-label" for="radioErkek">Erkek</label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="radio" runat="server" name="radioCinsiyet" id="radioKadin" value="kadin">
                    <label class="form-check-label" for="radioKadin">Kadın</label>
                </div>
            </div>
            <div class="form-group">
                <label for="txtEmail">E-Posta:</label>
                <input type="email" class="form-control" id="txtEposta" runat="server" placeholder="E-Posta Adresiniz">
            </div>
            <div class="form-group">
                <label for="txtSifre">Şifre:</label>
                <input type="password" class="form-control" runat="server" id="txtSifre" placeholder="Şifreniz">
            </div>
            <div class="form-group">
                <label for="txtSifreTekrar">Şifre Tekrar:</label>
                <input type="password" class="form-control" runat="server" id="txtSifreTekrar" placeholder="Şifrenizi Tekrar Girin">
            </div>
            <div class="form-group">
                <label for="txtTelefon">Telefon Numarası:</label>
                <input type="tel" class="form-control" runat="server" id="txtTelefon" placeholder="Telefon Numaranız">
            </div>
            <asp:Button ID="btnKayitOl" runat="server" CssClass="btn btn-primary btn-block" Text="Kayıt Ol" OnClick="btnKayitOl_Click" />
            <br />
            <p>Hesabınız var ise : </p>
            <div class="kayit">
                <asp:Button ID="btnGirisYap" runat="server" CssClass="btn btn-primary btn-block" Text="Giris Yap" OnClick="btnGirisYap_Click" />
            </div>
        </div>
    </div>
    <br /><br /><br />
</asp:Content>
