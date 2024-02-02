<%@ Page Title="" Language="C#" MasterPageFile="~/adminPanel.Master" AutoEventWireup="true" CodeBehind="adminPanelYorumlar.aspx.cs" Inherits="diziGurmesi3.adminPanelYorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2>Yorumlar</h2>
                <hr />
                <asp:GridView ID="gridViewYorumlar" runat="server" AutoGenerateColumns="False" DataKeyNames="YorumID">
                    <Columns>
                        <asp:BoundField DataField="YorumID" HeaderText="Yorum ID" SortExpression="YorumID" ReadOnly="True" />
                        <asp:BoundField DataField="KullaniciID" HeaderText="Kullanıcı ID" SortExpression="KullaniciID" />
                        <asp:BoundField DataField="DiziAdi" HeaderText="Dizi Adı" SortExpression="DiziAdi" />
                        <asp:BoundField DataField="Yorum" HeaderText="Yorum" SortExpression="Yorum" />
                        <asp:BoundField DataField="VerilenPuan" HeaderText="Verilen Puan" SortExpression="VerilenPuan" />
                        <asp:BoundField DataField="OnayDurumu" HeaderText="Onay Durumu" SortExpression="OnayDurumu" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
