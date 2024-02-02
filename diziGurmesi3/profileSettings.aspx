<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterPage.Master" AutoEventWireup="true" CodeBehind="profileSettings.aspx.cs" Inherits="diziGurmesi3.profileSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <h2 class="text-center">Profil Ayarları</h2>
        <hr />

        <div class="row justify-content-center">
            <div class="col-md-6">
                <h3>Şifre Değiştirme</h3>
                <asp:TextBox ID="txtCurrentPassword" runat="server" TextMode="Password" placeholder="Mevcut Şifre" CssClass="form-control mb-2" /><br />
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" placeholder="Yeni Şifre" CssClass="form-control mb-2" /><br />
                <asp:TextBox ID="txtConfirmNewPassword" runat="server" TextMode="Password" placeholder="Yeni Şifre Tekrar" CssClass="form-control mb-2" /><br />
                <asp:Button ID="btnChangePassword" runat="server" Text="Şifreyi Değiştir" OnClick="btnChangePassword_Click" CssClass="btn btn-primary btn-block" />
            </div>
        </div>
    </div>
</asp:Content>
