<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="allseries.aspx.cs" Inherits="diziGurmesi3.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .dizi {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex;
            align-items: flex-start;
        }

        .dizi-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px;
        }

        .dizi-icerik {
            display: flex;
            flex-direction: column;
        }

        .dizi-aciklama {
            font-style: italic;
        }

        .devam-link {
            margin-top: 10px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="diziContainer" runat="server"></div>
</asp:Content>
