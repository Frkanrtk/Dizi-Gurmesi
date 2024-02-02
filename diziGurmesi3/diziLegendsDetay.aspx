<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="diziLegendsDetay.aspx.cs" Inherits="diziGurmesi3.diziLegendsDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .dizi-detay-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            text-align: center;
        }

        .dizi-foto {
            max-width: 400px;
            height: auto;
            margin-bottom: 20px;
        }

        .dizi-aciklama {
            font-style: italic;
            margin-bottom: 20px;
        }

        .dizi-fragman {
            margin-bottom: 20px;
        }

        .dizi-puan {
            text-align: center; 
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="dizi-detay-container">
        <div id="divDiziAdi" runat="server"></div>
        <div id="divDiziAciklama" class="dizi-aciklama" runat="server"></div>
        <div id="divDiziFragman" class="dizi-fragman" runat="server"></div>
        <div id="divDiziPuan" class="dizi-puan" runat="server"></div>
    </div>
</asp:Content>
