<%@ Page Title="" Language="C#" MasterPageFile="~/adminPanel.Master" AutoEventWireup="true" CodeBehind="adminPanelDiziler.aspx.cs" Inherits="diziGurmesi3.adminPanelDiziler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2>Diziler</h2>
                <hr />
                <div class="form-group">
                    <label for="txtDiziAdi">Dizi Adı:</label>
                    <asp:TextBox ID="txtDiziAdi" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtDiziAciklama">Dizi Açıklama:</label>
                    <asp:TextBox ID="txtDiziAciklama" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtDiziPuani">Dizi Puanı:</label>
                    <asp:TextBox ID="txtDiziPuani" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtDiziFragman">Dizi Fragman:</label>
                    <asp:TextBox ID="txtDiziFragman" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="ddlDiziKategori">Dizi Kategori:</label>
                    <asp:DropDownList ID="ddlDiziKategori" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Animasyon" Value="Animasyon"></asp:ListItem>
                        <asp:ListItem Text="3 Boyutlu" Value="3boyutlu"></asp:ListItem>
                        <asp:ListItem Text="Bilim Kurgu" Value="BilimKurgu"></asp:ListItem>
                        <asp:ListItem Text="Aile" Value="Aile"></asp:ListItem>
                        <asp:ListItem Text="Aksiyon" Value="Aksiyon"></asp:ListItem>
                        <asp:ListItem Text="Belgesel" Value="Belgesel"></asp:ListItem>
                        <asp:ListItem Text="Biyografi" Value="Biyografi"></asp:ListItem>
                        <asp:ListItem Text="Casusluk" Value="Casusluk"></asp:ListItem>
                        <asp:ListItem Text="Çizgi" Value="Cizgi"></asp:ListItem>
                        <asp:ListItem Text="Çocuk" Value="Cocuk"></asp:ListItem>
                        <asp:ListItem Text="Dans" Value="Dans"></asp:ListItem>
                        <asp:ListItem Text="Dram" Value="Dram"></asp:ListItem>
                        <asp:ListItem Text="Fantastik" Value="Fantastik"></asp:ListItem>
                        <asp:ListItem Text="Gerilim" Value="Gerilim"></asp:ListItem>
                        <asp:ListItem Text="Gizem" Value="Gizem"></asp:ListItem>
                        <asp:ListItem Text="Komedi" Value="Komedi"></asp:ListItem>
                        <asp:ListItem Text="Korku" Value="Korku"></asp:ListItem>
                        <asp:ListItem Text="Macera" Value="Macera"></asp:ListItem>
                        <asp:ListItem Text="Müzikal" Value="Muzikal"></asp:ListItem>
                        <asp:ListItem Text="Polisiye" Value="Polisiye"></asp:ListItem>
                        <asp:ListItem Text="Romantik" Value="Romantik"></asp:ListItem>
                        <asp:ListItem Text="Savaş" Value="Savas"></asp:ListItem>
                        <asp:ListItem Text="Spor" Value="Spor"></asp:ListItem>
                        <asp:ListItem Text="Suç" Value="Suc"></asp:ListItem>
                        <asp:ListItem Text="Tarih" Value="Tarih"></asp:ListItem>
                        <asp:ListItem Text="Psikolojik" Value="Psikolojik"></asp:ListItem>
                        <asp:ListItem Text="Gençlik" Value="Genclik"></asp:ListItem>
                        <asp:ListItem Text="Politik" Value="Politik"></asp:ListItem>
                        <asp:ListItem Text="Anime" Value="Anime"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="txtDiziFoto">Dizi Foto:</label>
                    <asp:TextBox ID="txtDiziFoto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnDiziEkle" runat="server" Text="Dizi Ekle" OnClick="btnDiziEkle_Click" CssClass="btn btn-danger" />
                    <asp:Button ID="btnDiziBul" runat="server" Text="Dizi Bul" OnClick="btnDiziBul_Click" CssClass="btn btn-danger" />
                    <asp:Button ID="btnDiziGuncelle" runat="server" Text="Dizi Güncelle" OnClick="btnDiziGuncelle_Click" CssClass="btn btn-danger" />
                    <asp:Button ID="btnDiziSil" runat="server" Text="Dizi Sil" OnClick="btnDiziSil_Click" CssClass="btn btn-danger" />
                </div>
                <hr />
                <h3>Diziler</h3>
                <asp:GridView ID="gridViewDiziler" runat="server" AutoGenerateColumns="False" DataKeyNames="DiziSiraID">
                    <Columns>
                        <asp:BoundField DataField="DiziSiraID" HeaderText="Sıra ID" SortExpression="DiziSiraID" ReadOnly="True" />
                        <asp:BoundField DataField="DiziAdi" HeaderText="Dizi Adı" SortExpression="DiziAdi" />
                        <asp:BoundField DataField="DiziAciklama" HeaderText="Dizi Açıklama" SortExpression="DiziAciklama" />
                        <asp:BoundField DataField="DiziPuan" HeaderText="Dizi Puanı" SortExpression="DiziPuan" />
                        <asp:BoundField DataField="DiziFragman" HeaderText="Dizi Fragman" SortExpression="DiziFragman" />
                        <asp:BoundField DataField="DiziKategori" HeaderText="Dizi Kategori" SortExpression="DiziKategori" />
                        <asp:BoundField DataField="DiziFoto" HeaderText="Dizi Foto" SortExpression="DiziFoto" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
