<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="diziTrendDetay.aspx.cs" Inherits="diziGurmesi3.diziTrendDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="diziTrendDetayContainer" runat="server">
        <h2 id="divDiziAdi" runat="server"></h2>
        <p id="divDiziAciklama" runat="server"></p>
        <div id="divDiziFragman" runat="server" style="text-align: center;"></div>
        <div id="divDiziPuan" runat="server"></div>
    </div>
</asp:Content>
