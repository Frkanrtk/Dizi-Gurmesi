<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="legends.aspx.cs" Inherits="diziGurmesi3.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .legends-dizi {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex;
            align-items: flex-start;
        }

        .legends-dizi-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px;
        }

        .legends-dizi-icerik {
            display: flex;
            flex-direction: column;
        }

        .legends-dizi-aciklama {
            font-style: italic;
        }

        .devam-link {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="efsaneDizilerContainer" runat="server"></div>
</asp:Content>