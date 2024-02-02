<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="diziDetay.aspx.cs" Inherits="diziGurmesi3.diziDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
        Namespace="System.Web.UI" TagPrefix="asp" %>
    <style>
        .youtube-embed {
            width: 560px; 
            height: 315px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="diziDetayContainer" runat="server">
        <h2 runat="server" id="divDiziAdi"></h2>
        <p runat="server" id="divDiziAciklama"></p>
        <div runat="server" id="divDiziFragman" style="text-align: center;"></div>
        <div runat="server" id="divDiziPuan"></div>
       
    </div>

</asp:Content>
