<%@ Page Title="" Language="C#" MasterPageFile="~/adminPanel.Master" AutoEventWireup="true" CodeBehind="adminPanelKullanicilar.aspx.cs" Inherits="diziGurmesi3.WebForm9" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <h2>Kullanıcı Listesi</h2>

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="txtUserID">Kullanıcı ID:</label>
                <input type="text" runat="server" id="txtUserID" class="form-control" placeholder="Kullanıcı ID" />
            </div>
            <div class="form-group">
                <label for="txtAdSoyad">Ad Soyad:</label>
                <input type="text" runat="server" id="txtAdSoyad" class="form-control" placeholder="Ad Soyad" />
            </div>
            <div class="form-group">
                <label for="txtKullaniciAdi">Kullanıcı Adı:</label>
                <input type="text" runat="server" id="txtKullaniciAdi" class="form-control" placeholder="Kullanıcı Adı" />
            </div>
            <div class="form-group">
                <label for="txtEmail">E-Posta:</label>
                <input type="email" runat="server" id="txtEmail" class="form-control" placeholder="E-Posta" />
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
                <label for="txtTelefon">Sifre:</label>
                <input type="text" runat="server" id="txtSifre" class="form-control" placeholder="Sifre" />
            </div>
            <div class="form-group">
                <label for="txtTelefon">Telefon Numarası:</label>
                <input type="tel" runat="server" id="txtTelefon" class="form-control" placeholder="Telefon Numarası" />
            </div>
            <asp:Button ID="btnBul" runat="server" CssClass="btn btn-danger" Text="Bul" OnClick="btnBul_Click" />
            <asp:Button ID="btnGuncelle" runat="server" CssClass="btn btn-danger" Text="Güncelle" OnClick="btnGuncelle_Click" />
            <asp:Button ID="btnSil" runat="server" CssClass="btn btn-danger" Text="Sil" OnClick="btnSil_Click" />
        </div>
        <div class="col-md-8">
            <asp:GridView ID="gridViewKullanicilar" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="Kullanıcı ID" />
                    <asp:BoundField DataField="AdSoyad" HeaderText="Ad Soyad" />
                    <asp:BoundField DataField="KullaniciAdi" HeaderText="Kullanıcı Adı" />
                    <asp:BoundField DataField="Cinsiyet" HeaderText="Cinsiyet" />
                    <asp:BoundField DataField="Eposta" HeaderText="E-Posta" />
                    <asp:BoundField DataField="Sifre" HeaderText="Sifre" />
                    <asp:BoundField DataField="Telefon" HeaderText="Telefon Numarası" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
