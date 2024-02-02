<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterPage.Master" AutoEventWireup="true" CodeBehind="userTrend.aspx.cs" Inherits="diziGurmesi3.userTrend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .trend-dizi {
            margin-bottom: 20px;
            border: 1px solid #ccc;
            padding: 10px;
            display: flex; 
            align-items: center; 
        }

        .trend-dizi-foto {
            max-width: 200px;
            height: auto;
            margin-right: 10px; 
        }

        .trend-dizi-aciklama {
            font-style: italic;
        }
         .devam-link {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="userTrendDiziContainer" runat="server"></div>
</asp:Content>
